using System;

namespace FLServerMaintenanceTool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "FL Server Maintainance";

            Countdown.StartCountdown();

            Console.WriteLine("Auto Maintainance Started");
            ProcessHelper.CloseProcesses();
            Backup.RunBackup();
            ProcessHelper.StartProcesses();
            Console.WriteLine("Auto Maintainance Completed");
            Console.ReadLine();
        }
    }
}
