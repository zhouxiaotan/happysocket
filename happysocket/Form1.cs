using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace happysocket
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoFile_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoFile.Checked)
            {
                pnlFile.Visible = true;
                lblFileName.Text = "File Name";
            }
        }

        private void rdoText_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoText.Checked)
            {
                pnlFile.Visible = false;
            }
            
        }

        private void rdoFolder_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoFolder.Checked)
            {
                pnlFile.Visible = true;
                lblFileName.Text = "Folder Name";
            }
        }

        private void rdoInterval_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoInterval.Checked)
            {
                numInterval.Enabled = true;
            }

        }

        private void rdoNoInterval_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNoInterval.Checked)
            {
                numInterval.Enabled = false;
            }
        }

        private void rdoNotStop_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNotStop.Checked)
            {
                numTimes.Enabled = false;
            }
        }

        private void rdoTimes_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTimes.Checked)
            {
                numTimes.Enabled = true;
            }
        }
    }
}
