using System;
using System.IO;
using System.Windows.Forms;
using Ini;

namespace FLServerMaintainanceSettings
{
    public partial class SettingsForm : Form
    {
        private static bool warnClose = true;
        private static IniFile iniFile;
        private static String SettingsFolder{get{return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Sairento\\FLServerMaintainance\\";}}
        private static String SettingsFile { get { return SettingsFolder+ "settings.ini"; } }

        public SettingsForm()
        {
            InitializeComponent();
            if(!System.IO.Directory.Exists(SettingsFolder))
                System.IO.Directory.CreateDirectory(SettingsFolder);

            iniFile = new IniFile(SettingsFile);
        }

        private void BtnCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (warnClose)
            {
                DialogResult result = MessageBox.Show("Cancel all changes?", "Cancel?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == System.Windows.Forms.DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void BtnSaveClick(object sender, EventArgs e)
        {
            //Save new settings
            iniFile.IniWriteValue("folders", "freelancer", txtFreelancerFolder.Text);
            iniFile.IniWriteValue("folders", "accounts", txtAccountFolder.Text);
            iniFile.IniWriteValue("folders", "backup", txtBackupFolder.Text);

            iniFile.IniWriteValue("server", "address", txtServerAddress.Text);
            iniFile.IniWriteValue("server", "port", numServerPort.Value.ToString());
            iniFile.IniWriteValue("server", "password", txtServerPassword.Text);

            iniFile.IniWriteValue("processes", "shutdown", txtProcessesShutdown.Text.Replace("\r\n",","));
            iniFile.IniWriteValue("processes", "restart", txtProcessesRestart.Text.Replace("\r\n", ","));

            //add foreach loop here to save countdown messages

            //close without warning
            warnClose = false;
            this.Close();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(SettingsFile))
            {
                //Read settings from file if the file exists
                txtFreelancerFolder.Text = iniFile.IniReadValue("folders", "freelancer");
                txtAccountFolder.Text = iniFile.IniReadValue("folders", "accounts");
                txtBackupFolder.Text = iniFile.IniReadValue("folders", "backup");

                txtServerAddress.Text = iniFile.IniReadValue("server", "address");
                numServerPort.Value = decimal.Parse(iniFile.IniReadValue("server", "port"));
                txtServerPassword.Text = iniFile.IniReadValue("server", "password");

                txtProcessesShutdown.Text = iniFile.IniReadValue("processes", "shutdown").Replace(",", "\r\n");
                txtProcessesRestart.Text = iniFile.IniReadValue("processes", "restart").Replace(",", "\r\n");

                //add foreach loop here to load countdown items
            }
        }

        private void BtnSetFLFolderClick(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            txtFreelancerFolder.Text = folderBrowserDialog.SelectedPath;
        }

        private void BtnSetAccountsFolderClick(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            txtAccountFolder.Text = folderBrowserDialog.SelectedPath;
        }

        private void BtnSetBackupFolderClick(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            txtBackupFolder.Text = folderBrowserDialog.SelectedPath;
        }
    }
}
