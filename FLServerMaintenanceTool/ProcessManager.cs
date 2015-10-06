using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace FLServerMaintenanceTool
{
    class ProcessManager
    {
        public void CloseProcess(string processname)
        {
            foreach (var process in Process.GetProcessesByName(processname.Replace(".exe","")))
            {
                //Close process and free resources
                process.CloseMainWindow();
                process.Close();

                System.Threading.Thread.Sleep(5000); //wait 5s

                //if the process continues to run after 5s, kill it
                if (!process.HasExited)
                    process.Kill();
            }
        }

        public void StartProcess(string processpath)
        {
            Process.Start(processpath);
        }
    }
}
