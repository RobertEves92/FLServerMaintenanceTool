using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FLServerMaintainanceSettings
{
    public partial class InputBox : Form
    {
        public string ConsoleMessage { get { return txtConsole.Text; } }
        public string UniverseMessage { get { return txtUniverse.Text; } }
        public int WaitTime { get { return Convert.ToInt32(numWait.Value); } }

        public InputBox()
        {
            InitializeComponent();
        }

        public InputBox(string console, string universe, int wait)
        {
            InitializeComponent();
            txtConsole.Text = console;
            txtUniverse.Text = universe;
            numWait.Value = wait;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
