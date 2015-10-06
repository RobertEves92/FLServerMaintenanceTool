using System;
using System.Diagnostics;

namespace FLServerMaintenanceTool
{
    class ProcessManager
    {
        public void CloseProcess(string processname)
        {
            foreach (var process in Process.GetProcessesByName(processname))
            {
                //Close process and free resources
                process.CloseMainWindow();
                process.Close();

                System.Threading.Thread.Sleep(2500); //wait 2.5s
            }
        }

        public void StartProcess(string processpath)
        {
            Process.Start(processpath);
        }
    }
}
