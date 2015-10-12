using System;
using System.IO;

namespace FLServerMaintenanceTool
{
    /// <summary>
    /// Class for managing the backup process
    /// </summary>
    public static class Backup
    {
        private static readonly string[] flHookFiles = { "flhook.dll", "flhook.ini", "zlib.dll" };
        private static DateTime now;

        private static string TimedBackupFolder
        {
            get
            {
                return string.Format("{0}{1}-{2}-{3} {4}-{5}-{6}\\", Common.BackupFolder, now.Year, now.Month, now.Day, now.Hour, now.Minute, now.Second);
            }
        }

        private static string AccountsBackupFolder
        {
            get
            {
                return string.Format("{0}\\Accounts\\", TimedBackupFolder);
            }
        }

        private static string FLHookBackupFolder
        {
            get
            {
                return string.Format("{0}\\flhook\\", TimedBackupFolder);
            }
        }

        /// <summary>
        /// Starts the backup process
        /// </summary>
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
                File.Copy(string.Format("{0}{1}", Common.ExeFolder, s), string.Format("{0}{1}", FLHookBackupFolder, s));
            }
            Console.WriteLine("DONE");

            //Copy FLHook Logs
            Console.Write("Backup Up FLHook Logs...");
            DirectoryCopy(string.Format("{0}flhook_logs", Common.ExeFolder), string.Format("{0}flhook_logs", TimedBackupFolder), true);
            Directory.Delete(string.Format("{0}flhook_logs", Common.ExeFolder), true); //Stops log build up, we only want logs since the last backup
            System.Threading.Thread.Sleep(1000);
            Directory.CreateDirectory(string.Format("{0}flhook_logs", Common.ExeFolder));
            System.Threading.Thread.Sleep(1000);
            File.Create(string.Format("{0}flhook_logs\\events.log", Common.ExeFolder)); //Create a new blank events log as some FL server programs try to access it when loaded without checking it exists
            Console.WriteLine("DONE");

            //Copy FLHook Plugins
            Console.Write("Backing Up FLHook Plugins and Settings...");
            DirectoryCopy(string.Format("{0}flhook_plugins", Common.ExeFolder), string.Format("{0}flhook_plugins", TimedBackupFolder), true);
            Console.WriteLine("DONE");
        }

        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            var dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    string.Format("Source directory does not exist or could not be found: {0}", sourceDirName));
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