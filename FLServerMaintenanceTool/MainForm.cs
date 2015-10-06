using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FLServerMaintenanceTool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Common.AutoRun)
            {
                //Run
            }
            else
            {
                lblCountdown.Text = "Auto Maintainance not running - restart with /autorun";
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Common.MaintainanceRunning)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to cancel auto maintainance?", "Cancel Maintainance?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    //TODO Cancel
                }
            }
            else
            {
                MessageBox.Show("Auto Maintainance is already running.", "Cannot Cancel Maintainance", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }
        }
    }
}
