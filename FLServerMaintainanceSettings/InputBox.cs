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
        public string ConsoleMessage { get { return txtConsole.Text; } set { txtConsole.Text = value; } }
        public string UniverseMessage { get { return txtUniverse.Text; } set { txtUniverse.Text = value; } }
        public string WaitTime { get { return Convert.ToInt32(numWait.Value).ToString(); } set { numWait.Value = decimal.Parse(value); } }

        public InputBox()
        {
            InitializeComponent();
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
