using System;
using Ini;

namespace FLServerMaintenanceTool
{
    public static class Common
    {
        public static String SettingsFolder
        {
            get
            {
                return string.Format("{0}\\Sairento\\FLServerMaintainance\\", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            }
        }

        public static String SettingsFile
        {
            get
            {
                return string.Format("{0}settings.ini", SettingsFolder);
            }
        }

        public static IniFile IniFile
        {
            get
            {
                return new IniFile(SettingsFile);
            }
        }

        public static String BackupFolder
        {
            get
            {
                return string.Format("{0}\\", IniFile.IniReadValue("folders", "backup"));
            }
        }

        public static String AccountsFolder
        {
            get
            {
                return string.Format("{0}\\", IniFile.IniReadValue("folders", "accounts"));
            }
        }

        public static String FLFolder
        {
            get
            {
                return string.Format("{0}\\", IniFile.IniReadValue("folders", "freelancer"));
            }
        }

        public static String ExeFolder
        {
            get
            {
                return string.Format("{0}EXE\\", FLFolder);
            }
        }

        public static Boolean MaintainanceRunning { get; set; }
    }
}