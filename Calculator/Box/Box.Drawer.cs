using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator {
    partial class Box {
        private static Point GetTheRestPoint(Point first, Point second, Point third) {
            return new Point(first.X + second.X - third.X,
                first.Y + second.Y - third.Y);
        }

        private void Draw() {
            if (points.Count < 4) return;
            Point A = points[0];
            Point B = points[1];
            Point D = points[2];
            Point A_ = points[3];
            Point C = GetTheRestPoint(B, D, A);
            Point B_ = GetTheRestPoint(B, A_, A);
            Point C_ = GetTheRestPoint(C, A_, A);
            Point D_ = GetTheRestPoint(D, A_, A);
            Pen pen = new Pen(GetColor(), 2);
            this.graphics.DrawLine(pen, A, B);
            this.graphics.DrawLine(pen, A, D);
            this.graphics.DrawLine(pen, A, A_);
            this.graphics.DrawLine(pen, B, C);
            this.graphics.DrawLine(pen, B, B_);
            this.graphics.DrawLine(pen, C, D);
            this.graphics.DrawLine(pen, C, C_);
            this.graphics.DrawLine(pen, D, D_);
            this.graphics.DrawLine(pen, A_, B_);
            this.graphics.DrawLine(pen, A_, D_);
            this.graphics.DrawLine(pen, B_, C_);
            this.graphics.DrawLine(pen, C_, D_);
            points.Clear();
        }

        private void save_Click(object sender, EventArgs e) {
            /*
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = @"C:\Users\";
            saveFileDialog.Filter
                = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            saveFileDialog.Title = "Save";
            saveFileDialog.RestoreDirectory = true;
            */
            string path = @"D:\graphics.png";
            Bitmap bitmap = new Bitmap(this.Width, this.Height);
            Graphics g = Graphics.FromImage(bitmap);
            Rectangle rect = this.RectangleToScreen(this.ClientRectangle);
            Point start = new Point(rect.X, rect.Y + exit.Height);
            Size range = new Size(this.Width, this.Height - 2 * exit.Height);
            g.CopyFromScreen(start, Point.Empty, range);
            bitmap.Save(path);
        }

        private void clear_Click(object sender, EventArgs e) {
            this.graphics.Clear(this.BackColor);
        }
    }
}
