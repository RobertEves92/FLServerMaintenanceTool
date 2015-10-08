using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace FLServerMaintenanceTool
{
    public static class ProcessHelper
    {
        public static void CloseProcesses()
        {
            string[] processesToClose = Common.IniFile.IniReadValue("processes", "shutdown").Split(',');

            foreach (string s in processesToClose)
            {
                CloseProcess(s);
            }
        }

        public static void StartProcesses()
        {
            string[] processesToStart = Common.IniFile.IniReadValue("processes", "restart").Split(',');

            foreach (string s in processesToStart)
            {
                StartProcess(s);
            }
        }

        private static void CloseProcess(string processname)
        {
            Console.Write("Ending Process " + processname + "...");
            foreach (var process in Process.GetProcessesByName(processname))
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
            Console.Write("Starting Process " + processpath + "...");
            Process.Start(processpath);
            Console.WriteLine("DONE");
        }

        internal static void StartSettingsProcess()
        {
            StartProcess("FLServerMaintainanceSettings.exe");
        }
    }
}
