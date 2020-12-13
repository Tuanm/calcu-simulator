using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;


namespace Calculator {
    static class Program {
        [DllImport("User32.dll")]
        private static extern bool SetProcessDPIAware();

        [STAThread]
        static void Main() {
            if (Environment.OSVersion.Version.Major >= 6) {
                SetProcessDPIAware();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try {
                Application.Run(new Calculator());
            } catch (Exception e) {
                MessageBox.Show(e.Message);
                Start();
            }
            
        }

        public static void Start() {
            Form cat = new Cat();
            cat.Click += (object sender, EventArgs e) => {
                cat.Dispose();
            };
            cat.WindowState = FormWindowState.Maximized;
            cat.BackgroundImageLayout = ImageLayout.Tile;
            cat.Show();
        }
    }
}
