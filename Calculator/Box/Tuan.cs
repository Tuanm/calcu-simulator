using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator {
    public partial class Tuan : Form {
        public Tuan() {
            InitializeComponent();
        }

        public Tuan(Form pre) : this() {
            _pre = pre;
            pre.Hide();
        }

        private Form _pre;
        private Graphics _graphics;
        private Pen _pen;
        private List<Point> _points;
        private List<PointF[]> _paths;
        private Dictionary<Button, Form> _helps;
        private Form _cat;

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            this.InitializeStuffs();
            this.InitializeHelps();
            this.Refresh();
        }

        private void pictureBox_Click(object sender, EventArgs e) {
            Point point = (e as MouseEventArgs).Location;
            if (_points.Count == 4) {
                int index;
                for (index = 0; index < _points.Count; index++) {
                    if (_points[index] == Point.Empty) {
                        _points[index] = GetPointOnAxis(index, point.X, point.Y);
                        Draw();
                        return;
                    }
                }
                index = _points.IndexOf(IsNearPoint(point, _points, 20));
                if (index != -1) {
                    _points[index] = Point.Empty;
                }
                return;
            }
            switch (_points.Count) {
                case 1:
                    _points.Add(GetPointOnAxis(1, point.X, point.Y));
                    break;
                case 2:
                    _points.Add(GetPointOnAxis(2, point.X, point.Y));
                    break;
                case 3:
                    _points.Add(GetPointOnAxis(3, point.X, point.Y));
                    Draw();
                    return;
                case 0:
                    _points.Add(point);
                    InitializeAxis(_points[0]);
                    SaveImage();
                    break;
            }
            DrawPoints();
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e) {
            Point point = e.Location;
            Action<int> F = (int times) => {
                this.pictureBox.Refresh();
                if (_points.Count > 0) {
                    this._cat.Show();
                }
                Point temp = Point.Empty;
                switch (times) {
                    case 1:
                        temp = GetPointOnAxis(1, point.X, point.Y);
                        break;
                    case 2:
                        temp = GetPointOnAxis(2, point.X, point.Y);
                        break;
                    case 3:
                        temp = GetPointOnAxis(3, point.X, point.Y);
                        break;
                    case 0:
                        temp = GetPointOnAxis(0, point.X, point.Y);
                        InitializeAxis(temp);
                        break;
                }
                this._cat.Location = new Point(
                    this.Location.X + temp.X - _cat.Width / 2,
                    this.Location.Y + temp.Y - _cat.Height / 2);
                this._graphics.FillRectangle(Brushes.Blue, temp.X - 2, temp.Y - 2, 5, 5);
                DrawPoints();
            };
            Form info = _helps[infoButton];
            if (_paths.Count == 3) {
                if (_points.Count < 4) return;
                Form details = _helps[startButton];
                int index = _points.IndexOf(Point.Empty);
                if (index != -1) {
                    F(index);
                    return;
                }
                Point temp = IsNearPoint(point, _points, 20);
                if (temp != Point.Empty) {
                    this._graphics.FillRectangle(Brushes.Green, temp.X - 2, temp.Y - 2, 5, 5);
                    this.Cursor = Cursors.Hand;
                    ((Help)details).SetText($"Change");
                    details.Location = new Point(
                        point.X + this.Location.X,
                        point.Y + this.Location.Y);
                    details.Show();
                    return;
                }
                this.Cursor = Cursors.Default;
                Func<int, List<int>> Area = (int i) => {
                    double k = 1.2;
                    double[] distances2 = new double[] {
                        k * k * (Math.Pow(_points[1].X - _points[0].X, 2)
                        + Math.Pow(_points[1].Y - _points[0].Y, 2)),
                        Math.Pow(_points[2].X - _points[0].X, 2)
                        + Math.Pow(_points[2].Y - _points[0].Y, 2),
                        Math.Pow(_points[3].X - _points[0].X, 2)
                        + Math.Pow(_points[3].Y - _points[0].Y, 2)
                    };
                    int[] distance = new int[] {
                        (int)Math.Sqrt(distances2[0]),
                        (int)Math.Sqrt(distances2[1]),
                        (int)Math.Sqrt(distances2[2])
                    };
                    int[] area = new int[] {
                        distance[0] * distance[1],
                        distance[1] * distance[2],
                        distance[0] * distance[2]
                    };

                    return new List<int>() {
                        distance[i], distance[i == 2 ? 0 : i + 1],
                        area[i]
                    };
                };
                List<int> size = new List<int>() {
                    Area(0)[0],
                    Area(1)[0],
                    Area(2)[0]
                };
                ((Help)info).SetText($"Size: {size[0]} x {size[1]} x {size[2]}\n"
                    + $"Volume: {size[0] * size[1] * size[2]}");
                foreach (PointF[] path in _paths) {
                    if (IsInRegion(point, path)) {
                        this._graphics.FillPolygon(
                            new SolidBrush(Color.Black), path);
                        List<int> area = Area(_paths.IndexOf(path));
                        ((Help)details).SetText($"Size: {area[0]} x {area[1]}\n"
                            + $"Area: {area[2]}");
                        details.Location = new Point(
                            point.X + this.Location.X,
                            point.Y + this.Location.Y);
                        details.Show();
                        return;
                    }
                }
                this.pictureBox.Refresh();
                details.Hide();
                return;
            }
            F(_points.Count);
            ((Help)info).SetText("No Info.");
        }

        private void startButton_Click(object sender, EventArgs e) {
            this.startButton.Visible = false;
            this.exitButton.Visible = true;
            this.minimizeButton.Visible = true;
            this.resetButton.Visible = true;
            this.openButton.Visible = true;
            this.saveButton.Visible = true;
            this.infoButton.Visible = true;
            this.pictureBox.Click += pictureBox_Click;
            this.pictureBox.MouseMove += pictureBox_MouseMove;
            this.TransparencyKey = Color.Empty;
        }

        private void resetButton_Click(object sender, EventArgs e) {
            this._points.Clear();
            this._paths.Clear();
            this._cat.Hide();
            this.pictureBox.Image = null;
        }

        private void exitButton_Click(object sender, EventArgs e) {
            this._pre.Show();
            this.Dispose();
        }

        private void minimizeButton_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void openButton_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"C:\Users\";
            openFileDialog.Filter
                = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                // TODO
                _points.Clear();
                // Draw();
                this._cat.Hide();
                this.Cursor = Cursors.Default;
                this.pictureBox.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void saveButton_Click(object sender, EventArgs e) {
            ShowAllButtons(false); // hide all buttons
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = @"C:\Users\";
            saveFileDialog.Filter
                = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                Thread.Sleep(500);
                SaveImage(saveFileDialog.FileName);
            }
            ShowAllButtons(); // show all buttons
        }

        private void InitializeHelps() {
            _helps = new Dictionary<Button, Form>();
            _helps.Add(startButton, new Help("Create a box"));
            _helps.Add(exitButton, new Help("Exit"));
            _helps.Add(minimizeButton, new Help("Minimize"));
            _helps.Add(resetButton, new Help("Reset"));
            _helps.Add(openButton, new Help("Open Image"));
            _helps.Add(saveButton, new Help("Save Image"));
            _helps.Add(infoButton, new Help("No Info."));
            foreach (Button button in _helps.Keys) {
                button.MouseHover += (object sender, EventArgs e) => {
                    Form form = _helps[button];
                    form.Show();
                    form.Location = new Point(
                        this.Location.X + button.Location.X + button.Width / 4,
                        this.Location.Y + button.Location.Y + button.Height);
                };
                button.MouseLeave += (object sender, EventArgs e) => {
                    _helps[button].Hide();
                };
            }
        }

        private void InitializeStuffs() {
            this._graphics = this.pictureBox.CreateGraphics();
            this._graphics.SmoothingMode = SmoothingMode.HighQuality;
            this._pen = new Pen(Color.Black, 2);
            this._pen.StartCap = this._pen.EndCap = LineCap.Round;
            this._points = new List<Point>();
            this._paths = new List<PointF[]>();
            this.startButton.Location = new Point(
                this.Width / 2 - this.startButton.Width / 2,
                this.Height / 2 - this.startButton.Height / 2);
            this.startButton.Click += startButton_Click;
            this.exitButton.Click += exitButton_Click;
            this.minimizeButton.Click += minimizeButton_Click;
            this.resetButton.Click += resetButton_Click;
            this.openButton.Click += openButton_Click;
            this.saveButton.Click += saveButton_Click;
            this.TransparencyKey = this.pictureBox.BackColor;
            this._cat = new Cat();
        }

        private void InitializeAxis(Point origin, bool save = false) {
            if (this._graphics != null) {
                this.Refresh();
                int width = this.ClientSize.Width;
                int height = this.ClientSize.Height;
                double alpha = Math.PI / 6;
                Point x = new Point(
                    0,
                    (int)(origin.Y + (origin.X) * Math.Tan(alpha)));
                Point y = new Point(
                    width,
                    origin.Y);
                Point z = new Point(origin.X, 0);
                this._graphics.DrawLine(this._pen, origin, x);
                this._graphics.DrawLine(this._pen, origin, y);
                this._graphics.DrawLine(this._pen, origin, z);
                this._graphics.FillRectangle(Brushes.Green,
                    origin.X - 2, origin.Y - 2, 5, 5);
            }
        }

        private void SaveImage(string path = null) {
            ShowAllButtons(false); // hide all buttons
            Bitmap bitmap = new Bitmap(this.Width, this.Height, this._graphics);
            Graphics memoryGraphics = Graphics.FromImage(bitmap);
            memoryGraphics.CopyFromScreen(this.Location, Point.Empty, this.Size);
            if (path != null) {
                bitmap.Save(path);
            }
            this.pictureBox.Image = bitmap;
            ShowAllButtons(); // show all buttons
        }

        private void ShowAllButtons(bool shown = true) {
            exitButton.Visible = shown;
            minimizeButton.Visible = shown;
            resetButton.Visible = shown;
            openButton.Visible = shown;
            saveButton.Visible = shown;
            infoButton.Visible = shown;
            startButton.Visible = false; // this button is only shown once
        }

        private void DrawPoints() {
            foreach (var point in _points) {
                this._graphics.FillRectangle(Brushes.Green, point.X - 2, point.Y - 2, 5, 5);
            }
        }

        private static Point GetTheRestPoint(Point first, Point second, Point third) {
            return new Point(first.X + second.X - third.X,
                first.Y + second.Y - third.Y);
        }

        private void Draw() {
            ShowAllButtons(false);
            this._cat.Hide();
            this.pictureBox.Image = null;
            this.pictureBox.Update();
            Point A = _points[0];
            Point B = _points[1];
            Point D = _points[2];
            Point A_ = _points[3];
            Point C = GetTheRestPoint(B, D, A);
            Point B_ = GetTheRestPoint(B, A_, A);
            Point C_ = GetTheRestPoint(C, A_, A);
            Point D_ = GetTheRestPoint(D, A_, A);
            this._paths.Clear();
            this._paths.Add(new PointF[] { A_, B_, C_, D_ });
            this._paths.Add(new PointF[] { C, C_, D_, D });
            this._paths.Add(new PointF[] { B, B_, C_, C });
            foreach (PointF[] path in _paths) {
                this._graphics.FillPolygon(new SolidBrush(GetColor()), path);
            }
            Pen pen = new Pen(_pen.Color, 2);
            pen.DashPattern = new float[] { 5, 2, 5, 2 };
            this._graphics.DrawLine(pen, A, B);
            this._graphics.DrawLine(pen, A, D);
            this._graphics.DrawLine(pen, A, A_);
            this._graphics.DrawLine(_pen, B, C);
            this._graphics.DrawLine(_pen, B, B_);
            this._graphics.DrawLine(_pen, C, D);
            this._graphics.DrawLine(_pen, C, C_);
            this._graphics.DrawLine(_pen, D, D_);
            this._graphics.DrawLine(_pen, A_, B_);
            this._graphics.DrawLine(_pen, A_, D_);
            this._graphics.DrawLine(_pen, B_, C_);
            this._graphics.DrawLine(_pen, C_, D_);
            this.Cursor = Cursors.Default;
            SaveImage("temp.png"); // save a temporary image file
        }

        private static Random random = new Random();

        private static Color GetColor() {
            int r = random.Next(256);
            int g = random.Next(256);
            int b = random.Next(256);
            return Color.FromArgb(r, g, b);
        }

        private static bool IsInRegion(PointF point, PointF[] path) {
            Func<PointF, PointF, PointF, float> F = (PointF M, PointF A, PointF B) => {
                return (B.Y - A.Y) * (M.X - A.X) - (B.X - A.X) * (M.Y - A.Y);
            };
            PointF[] points = path;
            if (points.Length < 3) return false;
            for (var index = 1; index < points.Length; index++) {
                PointF first = points[points.Length - 1];
                if (index > 1) first = points[index - 2];
                PointF second = points[index - 1];
                bool[] signs = new bool[] {
                    F(point, first, second)
                    * F(points[index], first, second) > 0,
                    F(point, first, points[index])
                    * F(second, first, points[index]) > 0,
                    F(point, points[index], second)
                    * F(first, points[index], second) > 0
                };
                if (signs[0] && signs[1] && signs[2]) return true;
            }
            return false;
        }

        private static Point IsNearPoint(Point location, List<Point> points, float range) {
            for (var index = 1; index < points.Count; index++) {
                Point point = points[index];
                float distance2 = (point.X - location.X) * (point.X - location.X)
                    + (point.Y - location.Y) * (point.Y - location.Y);
                if (distance2 < range * range) return point;
            }
            return Point.Empty;
        }

        private Point GetPointOnAxis(int axisIndex, int x = 0, int y = 0) {
            double alpha = Math.PI / 6;
            Point origin = Point.Empty;
            if (_points.Count > 0) {
                origin = _points[0];
            }
            Point point = Point.Empty;
            switch (axisIndex) {
                case 1: // axis Ox
                    point = new Point(
                        (int)((origin.Y + origin.X * Math.Tan(alpha) - y)
                        / Math.Tan(alpha)),
                        y);
                    this.Cursor = random.Next(2) == 0 ?
                        Cursors.PanNE : Cursors.PanSW;
                    if (point.Y <= origin.Y) {
                        point.Y = 2 * origin.Y - point.Y;
                        point.X = 2 * origin.X - point.X;
                        this.Cursor = Cursors.PanSW;
                    }
                    return point;
                case 2: // axis Oy
                    point = new Point(
                        (int)(x + (y - origin.Y) / Math.Tan(alpha)),
                        origin.Y);
                    this.Cursor = Cursors.NoMoveHoriz;
                    if (point.X <= origin.X) {
                        point.Y = 2 * origin.Y - point.Y;
                        point.X = 2 * origin.X - point.X;
                        this.Cursor = Cursors.PanEast;
                    }
                    return point;
                case 3: // axis Oz
                    point =  new Point(
                        origin.X,
                        y);
                    this.Cursor = Cursors.NoMoveVert;
                    if (point.Y >= origin.Y) {
                        point.Y = 2 * origin.Y - point.Y;
                        point.X = 2 * origin.X - point.X;
                        this.Cursor = Cursors.PanNorth;
                    }
                    return point;
            }
            this.Cursor = Cursors.Hand;
            return new Point(x, y);
        }
    }
}
