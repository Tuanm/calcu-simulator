using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculator {
    public partial class Box : Form {
        public Box() {
            InitializeComponent();
            InitGraphics();
            InitEvents();
        }

        public Box(Form previous) : this() {
            this.previous = previous;
            points = new List<Point>();
        }

        private Form previous;
        private Graphics graphics;
        private List<Point> points;

        private void InitGraphics() {
            graphics = this.CreateGraphics();
            graphics.SmoothingMode = SmoothingMode.HighQuality;
        }

        private void InitEvents() {
            this.Click += this_Click;
            this.Load += this_Load;
            this.MouseMove += this_MouseMove;
            this.exit.MouseHover += label_MouseHover;
            this.exit.MouseLeave += label_MouseLeave;
            this.open.Click += open_Click;
            this.save.Click += save_Click;
            this.clear.Click += clear_Click;
            foreach (Control control in this.Controls) {
                if (control is FontAwesome.Sharp.IconButton) {
                    control.MouseHover += (object sender, EventArgs e) => {
                        (sender as FontAwesome.Sharp.IconButton)
                            .IconColor = Color.Black;
                    };
                    control.MouseLeave += (object sender, EventArgs e) => {
                        (sender as FontAwesome.Sharp.IconButton)
                            .IconColor = Color.White;
                    };
                }
            }
        }

        private void this_Click(object sender, EventArgs e) {
            Point location = (e as MouseEventArgs).Location;
            Brush brush = new SolidBrush(GetColor());
            graphics.FillRectangle(brush, location.X - 2, location.Y - 2, 5, 5);
            if (points.Count < 4) {
                points.Add(location);
                this.Draw();
            }
        }

        private static Random random = new Random();

        public static Color GetColor() {
            int r = random.Next(256);
            int g = random.Next(256);
            int b = random.Next(256);
            return Color.FromArgb(r, g, b);
        }

        private void exit_Click(object sender, EventArgs e) {
            this.Dispose();
            this.previous.Show();
        }

        private void label_MouseHover(object sender, EventArgs e) {
            (sender as Label).ForeColor = Color.Black;
        }

        private void label_MouseLeave(object sender, EventArgs e) {
            (sender as Label).ForeColor = Color.White;
        }

        private void this_Load(object sender, EventArgs e) {
            this.previous.Hide();
        }

        private void this_MouseMove(object sender, MouseEventArgs e) {
            current.Text = $"({e.X}, {e.Y})";
            current.Location = new Point(e.X, current.Location.Y);
        }
    }
}
