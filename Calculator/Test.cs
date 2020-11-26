using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculator {
    public partial class Test : Form {
        public Test() {
            InitializeComponent();
            InitGraphics();
            InitEvents();
        }

        private Graphics graphics;

        private void InitGraphics() {
            graphics = this.CreateGraphics();
        }

        private void InitEvents() {
            this.Click += this_Click;
        }

        private void this_Click(object sender, EventArgs e) {
            Point location = (e as MouseEventArgs).Location;
            Brush brush = new SolidBrush(GetColor());
            graphics.FillRectangle(brush, location.X, location.Y, 5, 5);
        }

        private static Random random = new Random();

        public static Color GetColor() {
            int r = random.Next(256);
            int g = random.Next(256);
            int b = random.Next(256);
            return Color.FromArgb(r, g, b);
        }

        private void label_Click(object sender, EventArgs e) {
            this.Dispose();
        }

        private void label_MouseHover(object sender, EventArgs e) {
            (sender as Label).ForeColor = Color.Black;
        }

        private void label_MouseLeave(object sender, EventArgs e) {
            (sender as Label).ForeColor = Color.White;
        }
    }
}
