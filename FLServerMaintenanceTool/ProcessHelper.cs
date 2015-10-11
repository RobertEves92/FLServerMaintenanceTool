using System;
using System.Diagnostics;

namespace FLServerMaintenanceTool
{
    /// <summary>
    /// Class for managing process functions
    /// </summary>
    public static class ProcessHelper
    {
        /// <summary>
        /// Close processes listed in the settings file
        /// </summary>
        public static void CloseProcesses()
        {
            string[] processesToClose = Common.IniFile.IniReadValue("processes", "shutdown").Split(',');

            foreach (string s in processesToClose)
            {
                CloseProcess(s);
            }
        }

        /// <summary>
        /// Open processes listed in the settings file
        /// </summary>
        public static void StartProcesses()
        {
            string[] processesToStart = Common.IniFile.IniReadValue("processes", "restart").Split(',');

            foreach (string s in processesToStart)
            {
                StartProcess(s);
            }
        }

        internal static void StartSettingsProcess()
        {
            StartProcess("FLServerMaintainanceSettings.exe");
        }

        private static void CloseProcess(string processname)
        {
            Console.Write(string.Format("Ending Process {0}...", processname));
            foreach (Process process in Process.GetProcessesByName(processname))
            {
                //Close process and free resources
                process.CloseMainWindow();
                process.Close();

                System.Threading.Thread.Sleep(5000); //wait 5s
            }
            Console.WriteLine("DONE");
        }

        private static void StartProcess(string processpath)
        {
            Console.Write(string.Format("Starting Process {0}...", processpath));
            Process.Start(processpath);
            Console.WriteLine("DONE");
        }
    }
}