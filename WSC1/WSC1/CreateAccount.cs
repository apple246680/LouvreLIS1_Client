using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System
{
    public partial class CreateAccountForm : UserControl
    {
        public CreateAccountForm()
        {
            InitializeComponent();
        }

        private void BaclLoginBtn_Click(object sender, EventArgs e)
        {
            Global.ShowLoginForm();
        }

        private void UELALinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(Application.StartupPath+"\\Terms.txt");
            AgreeUELACheckBox.Enabled = true;
        }
    }
}
