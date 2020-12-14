using System;
using System.Drawing;
using System.Windows.Forms;


namespace Calculator {
    public partial class Help : Form {
        public Help() {
            InitializeComponent();
        }

        public Help(string text) : this() {
            this.TransparencyKey = this.BackColor;
            this.label.AutoSize = true;
            this.SetText(text);
        }

        public void SetText(string text) {
            this.label.Text = text.ToLower();
            double k = 1.0;
            if (text.Length >= 6) {
                k = 1.2 * this.label.Width / this.Width;
            }
            this.Size = new Size(
                (int)(k * this.Width),
                (int)(k * this.Height));
            this.label.Location = new Point(
                (this.Width - this.label.Width) / 2,
                (this.Height - this.label.Height) / 2);
        }
    }
}
