using System;
using System.Runtime.InteropServices;
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
            Application.Run(new Calculator());
        }
    }
}
