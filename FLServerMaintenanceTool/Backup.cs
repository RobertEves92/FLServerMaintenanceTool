using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FLServerMaintenanceTool
{
    class Backup
    {
        //Application Properties shortcuts
        string BackupFolder { get { return Properties.Settings.Default.BackupsFolder; } }
        string AccountsFolder { get { return Properties.Settings.Default.AccountsFolder; } }

        string TimedBackupFolder { get { return BackupFolder + now.Year + "-" + now.Month + "-" + now.Day + " " + now.Hour + "-" + now.Minute + "-" + now.Second + "\\"; } }
        string AccountsBackupFolder { get { return TimedBackupFolder + "\\Accounts\\"; } }
        DateTime now;

        public Backup()
        {
            //Get Current Date and Time
            now = DateTime.Now;
        }

        public void RunBackup()
        {
            //Create Timed backup folder
            Directory.CreateDirectory(TimedBackupFolder);

            //Copy player accounts / server settings
            DirectoryCopy(AccountsFolder, AccountsBackupFolder, true);
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
