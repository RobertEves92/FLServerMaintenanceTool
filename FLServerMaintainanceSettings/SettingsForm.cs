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

        /// <summary>
        /// Settings Form constructor
        /// </summary>
        public SettingsForm()
        {
            this.InitializeComponent();
            if (!System.IO.Directory.Exists(SettingsFolder))
            {
                System.IO.Directory.CreateDirectory(SettingsFolder);
            }

            iniFile = new IniFile(SettingsFile);
        }

        private static String SettingsFolder
        {
            get
            {
                return string.Format("{0}\\Sairento\\FLServerMaintainance\\", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            }
        }

        private static String SettingsFile
        {
            get
            {
                return string.Format("{0}settings.ini", SettingsFolder);
            }
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
            this.SaveSettings();

            //close without warning
            warnClose = false;
            this.Close();
        }

        private void SaveSettings()
        {
            //Save new settings
            iniFile.IniWriteValue("folders", "freelancer", this.txtFreelancerFolder.Text);
            iniFile.IniWriteValue("folders", "accounts", this.txtAccountFolder.Text);
            iniFile.IniWriteValue("folders", "backup", this.txtBackupFolder.Text);

            iniFile.IniWriteValue("server", "address", this.txtServerAddress.Text);
            iniFile.IniWriteValue("server", "port", this.numServerPort.Value.ToString());
            iniFile.IniWriteValue("server", "password", this.txtServerPassword.Text);

            iniFile.IniWriteValue("processes", "shutdown", this.txtProcessesShutdown.Text.Replace("\r\n", ","));
            iniFile.IniWriteValue("processes", "restart", this.txtProcessesRestart.Text.Replace("\r\n", ","));

            iniFile.IniWriteValue("countdown", "enabled", this.chkCountdown.Checked.ToString());
            iniFile.IniWriteValue("countdown", "count", this.listViewCountdown.Items.Count.ToString());
            for (int i = 0; i < this.listViewCountdown.Items.Count; i++)
            {
                iniFile.IniWriteValue("countdown", string.Format("item{0}console", i), this.listViewCountdown.Items[i].Text);
                iniFile.IniWriteValue("countdown", string.Format("item{0}universe", i), this.listViewCountdown.Items[i].SubItems[1].Text);
                iniFile.IniWriteValue("countdown", string.Format("item{0}wait", i), this.listViewCountdown.Items[i].SubItems[2].Text);
            }
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(SettingsFile))
            {
                //Read settings from file if the file exists
                this.txtFreelancerFolder.Text = iniFile.IniReadValue("folders", "freelancer");
                this.txtAccountFolder.Text = iniFile.IniReadValue("folders", "accounts");
                this.txtBackupFolder.Text = iniFile.IniReadValue("folders", "backup");

                this.txtServerAddress.Text = iniFile.IniReadValue("server", "address");
                this.numServerPort.Value = decimal.Parse(iniFile.IniReadValue("server", "port"));
                this.txtServerPassword.Text = iniFile.IniReadValue("server", "password");

                this.txtProcessesShutdown.Text = iniFile.IniReadValue("processes", "shutdown").Replace(",", "\r\n");
                this.txtProcessesRestart.Text = iniFile.IniReadValue("processes", "restart").Replace(",", "\r\n");

                this.listViewCountdown.Items.Clear();
                this.chkCountdown.Checked = Boolean.Parse(iniFile.IniReadValue("countdown", "enabled"));
                int items = int.Parse(iniFile.IniReadValue("countdown", "count"));
                for (int i = 0; i < items; i++)
                {
                    var item = new ListViewItem();
                    item.Text = iniFile.IniReadValue("countdown", string.Format("item{0}console", i));
                    item.SubItems.Add(new ListViewItem.ListViewSubItem(item, iniFile.IniReadValue("countdown", string.Format("item{0}universe", i))));
                    item.SubItems.Add(new ListViewItem.ListViewSubItem(item, iniFile.IniReadValue("countdown", string.Format("item{0}wait", i))));
                    this.listViewCountdown.Items.Add(item);
                }
            }
            else
            {
                //Get default FL install folder
                this.txtFreelancerFolder.Text = string.Format("{0}\\Microsoft Games\\Freelancer", Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles));
                //Get default FL server executable
                this.txtProcessesRestart.Text = string.Format("{0}\\EXE\\flserver.exe", this.txtFreelancerFolder.Text);
                //Get current user MP folder
                this.txtAccountFolder.Text = string.Format("{0}\\My Games\\Freelancer\\Accts\\MultiPlayer", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
                //run save method to save default values
                this.SaveSettings();
            }
        }

        private void BtnSetFLFolderClick(object sender, EventArgs e)
        {
            this.folderBrowserDialog.ShowDialog();
            this.txtFreelancerFolder.Text = this.folderBrowserDialog.SelectedPath;
        }

        private void BtnSetAccountsFolderClick(object sender, EventArgs e)
        {
            this.folderBrowserDialog.ShowDialog();
            this.txtAccountFolder.Text = this.folderBrowserDialog.SelectedPath;
        }

        private void BtnSetBackupFolderClick(object sender, EventArgs e)
        {
            this.folderBrowserDialog.ShowDialog();
            this.txtBackupFolder.Text = this.folderBrowserDialog.SelectedPath;
        }

        private void BtnRemoveClick(object sender, EventArgs e)
        {
            if (this.listViewCountdown.SelectedItems.Count == 0)
            {
                MessageBox.Show("No item(s) selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected countdown items?", "Delete Countdown Items?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (ListViewItem item in this.listViewCountdown.SelectedItems)
                    {
                        item.Remove();
                    }
                }
            }
        }

        private void BtnAddClick(object sender, EventArgs e)
        {
            var inputBox = new InputBox();
            if (inputBox.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var item = new ListViewItem();
                item.Text = inputBox.ConsoleMessage;
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, inputBox.UniverseMessage));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, inputBox.WaitTime));
                this.listViewCountdown.Items.Add(item);
            }
        }

        private void BtnEditClick(object sender, EventArgs e)
        {
            if (this.listViewCountdown.SelectedItems.Count > 1)
            {
                MessageBox.Show("Only one item should be selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (this.listViewCountdown.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an item to edit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var inputBox = new InputBox();
                inputBox.ConsoleMessage = this.listViewCountdown.SelectedItems[0].Text;
                inputBox.UniverseMessage = this.listViewCountdown.SelectedItems[0].SubItems[1].Text;
                inputBox.WaitTime = this.listViewCountdown.SelectedItems[0].SubItems[2].Text;

                if (inputBox.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.listViewCountdown.SelectedItems[0].Text = inputBox.ConsoleMessage;
                    this.listViewCountdown.SelectedItems[0].SubItems[1].Text = inputBox.UniverseMessage;
                    this.listViewCountdown.SelectedItems[0].SubItems[2].Text = inputBox.WaitTime;
                }
            }
        }

        private void ChkCountdownCheckedChanged(object sender, EventArgs e)
        {
            this.grpCountdown.Enabled = this.chkCountdown.Checked;
        }
    }
}