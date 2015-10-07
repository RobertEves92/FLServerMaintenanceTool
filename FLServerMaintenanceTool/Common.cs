using System;
using Ini;

namespace FLServerMaintenanceTool
{
    public static class Common
    {
        public static String SettingsFolder { get { return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Sairento\\FLServerMaintainance\\"; } }
        public static String SettingsFile { get { return SettingsFolder + "settings.ini"; } }
        public static IniFile IniFile { get { return new IniFile(SettingsFile); } }
        public static String BackupFolder { get { return IniFile.IniReadValue("folders", "backup") + "\\"; } }
        public static String AccountsFolder { get { return IniFile.IniReadValue("folders", "accounts") + "\\"; } }
        public static String FLFolder { get { return IniFile.IniReadValue("folders", "freelancer") + "\\"; } }
        public static String ExeFolder { get { return FLFolder + "EXE\\"; } }
        public static Boolean MaintainanceRunning { get; set; }
    }
}