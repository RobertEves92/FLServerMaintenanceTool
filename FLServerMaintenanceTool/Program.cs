using System;
using System.Windows.Forms;

namespace FLServerMaintenanceTool
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            foreach (string s in args)
            {
                if (s == "/autorun")
                    Common.AutoRun = true;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (Common.AutoRun)
                Application.Run(new MainForm());
            else
                Application.Run(new SettingsForm());
        }
    }
}
