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
    public partial class PopUp : Form {
        public PopUp() {
            InitializeComponent();
            this.TopMost = true;
            this.BackColor = GetColor();
        }

        public PopUp(int width, int height) : this() {
            this.ClientSize = new Size(width, height);
        }

        static Random random = new Random();

        public static Color GetColor() {
            int r = random.Next(256);
            int g = random.Next(256);
            int b = random.Next(256);
            return Color.FromArgb(r, g, b);
        }
    }
}
