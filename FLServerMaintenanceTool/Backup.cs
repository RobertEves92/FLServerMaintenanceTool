using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FLServerMaintenanceTool
{
    class Backup
    {
        string BackupFolder { get { return Properties.Settings.Default.BackupsFolder; } }

        string TimedBackupFolder { get { return BackupFolder + now.Year + "-" + now.Month + "-" + now.Day + " " + now.Hour + "-" + now.Minute + "-" + now.Second + "\\"; } }

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
        }
    }
}
