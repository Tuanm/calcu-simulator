using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;


namespace Calculator {
    static class Program {
        [STAThread]
        static void Main() {

            if (Environment.OSVersion.Version.Major >= 6) {
                SetProcessDPIAware();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Calculator());
        }

        [DllImport("User32.dll")]
        private static extern bool SetProcessDPIAware();

        public static void ForFun(int n = 5, int sleep = 0, bool bg = false) {
            int width = 1200;
            int height = 800;
            for (var index = 0; index < n; index++) {
                Thread thread = new Thread(() => {
                    Random random = new Random();
                    PopUp popup = new PopUp(100, 100);
                    popup.Show();
                    while (true) {
                        Thread.Sleep(sleep);
                        Point location = Cursor.Position;
                        int x = random.Next(width);
                        int y = random.Next(height);
                        popup.Location = new Point(x, y);
                    }
                });
                thread.IsBackground = bg;
                thread.Name = $"STOP ME! ({index})";
                thread.Start();
            }
        }
    }
}
