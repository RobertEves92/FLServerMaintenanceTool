using System;
using System.IO;

namespace FLServerMaintenanceTool
{
    public static class Backup
    {
        private static string TimedBackupFolder { get { return Common.BackupFolder + now.Year + "-" + now.Month + "-" + now.Day + " " + now.Hour + "-" + now.Minute + "-" + now.Second + "\\"; } }
        private static string AccountsBackupFolder { get { return TimedBackupFolder + "\\Accounts\\"; } }
        private static string FLHookBackupFolder { get { return TimedBackupFolder + "\\flhook\\"; } }
        private static readonly string[] flHookFiles = { "flhook.dll", "flhook.ini", "zlib.dll" };
        private static DateTime now;

        public static void RunBackup()
        {
            //Get Current Date and Time
            now = DateTime.Now;

            //Create Timed backup folder
            Console.Write("Creating Backup Folder...");
            Directory.CreateDirectory(TimedBackupFolder);
            Console.WriteLine("DONE");

            //Copy player accounts / server settings
            Console.Write("Backing Up Accounts and Server Files...");
            DirectoryCopy(Common.AccountsFolder, AccountsBackupFolder, true);
            Console.WriteLine("DONE");

            //Copy FLHook files
            Console.Write("Backing Up FLHook Files...");
            Directory.CreateDirectory(FLHookBackupFolder);
            foreach (string s in flHookFiles)
            {
                File.Copy(Common.ExeFolder + s, FLHookBackupFolder + s);
            }
            Console.WriteLine("DONE");

            //Copy FLHook Logs
            Console.Write("Backup Up FLHook Logs...");
            DirectoryCopy(Common.ExeFolder + "flhook_logs", TimedBackupFolder + "flhook_logs", true);
            Directory.Delete(Common.ExeFolder + "flhook_logs", true); //Stops log build up, we only want logs since the last backup
            File.Create(Common.ExeFolder + "flhook_logs\\events.log"); //Create a new blank events log as some FL server programs try to access it when loaded without checking it exists
            Console.WriteLine("DONE");

            //Copy FLHook Plugins
            Console.Write("Backing Up FLHook Plugins and Settings...");
            DirectoryCopy(Common.ExeFolder + "flhook_plugins", TimedBackupFolder + "flhook_plugins", true);
            Console.WriteLine("DONE");
        }

        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            // If the destination directory doesn't exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, false);
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }
    }
}
