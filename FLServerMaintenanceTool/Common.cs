using System;
using Ini;

namespace FLServerMaintenanceTool
{
    /// <summary>
    /// Common references used by multiple classes
    /// </summary>
    public static class Common
    {
        /// <summary>
        /// Gets the current users App Data folder for the maintainance tool
        /// </summary>
        public static String SettingsFolder
        {
            get
            {
                return string.Format("{0}\\Sairento\\FLServerMaintainance\\", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            }
        }

        /// <summary>
        /// Gets the full path for the settings file
        /// </summary>
        public static String SettingsFile
        {
            get
            {
                return string.Format("{0}settings.ini", SettingsFolder);
            }
        }

        /// <summary>
        /// Returns a single use reference to the IniFile class loading the maintainance tools settings file
        /// </summary>
        public static IniFile IniFile
        {
            get
            {
                return new IniFile(SettingsFile);
            }
        }

        /// <summary>
        /// Gets the backup folder path from the settings file
        /// </summary>
        public static String BackupFolder
        {
            get
            {
                return string.Format("{0}\\", IniFile.IniReadValue("folders", "backup"));
            }
        }

        /// <summary>
        /// Gets the accounts folder path from the settings file
        /// </summary>
        public static String AccountsFolder
        {
            get
            {
                return string.Format("{0}\\", IniFile.IniReadValue("folders", "accounts"));
            }
        }

        /// <summary>
        /// Gets the freelancer folder path from the settings file
        /// </summary>
        public static String FLFolder
        {
            get
            {
                return string.Format("{0}\\", IniFile.IniReadValue("folders", "freelancer"));
            }
        }

        /// <summary>
        /// Gets the EXE folder path from the freelancer folder
        /// </summary>
        public static String ExeFolder
        {
            get
            {
                return string.Format("{0}EXE\\", FLFolder);
            }
        }
    }
}