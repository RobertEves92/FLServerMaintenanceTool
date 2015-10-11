using System;

namespace FLServerMaintenanceTool
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Title = "FL Server Maintainance";

            if (System.IO.File.Exists(Common.SettingsFile))
            {
                Countdown.StartCountdown();

                Console.WriteLine("Auto Maintainance Started");
                ProcessHelper.CloseProcesses();
                Backup.RunBackup();
                ProcessHelper.StartProcesses();
                Console.WriteLine("Auto Maintainance Completed");
            }
            else
            {
                Console.WriteLine("No settings file found.");
                ProcessHelper.StartSettingsProcess();
            }
            Console.ReadLine();
        }
    }
}