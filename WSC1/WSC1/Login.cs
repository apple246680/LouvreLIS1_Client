using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WSC1;

namespace System
{
    public partial class LoginForm : UserControl
    {
       public static LoginForm ins;
        public LoginForm()
        {
            InitializeComponent();
            ins = this;
        }
        private void CreateAccountLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Global.ShowCreateAccountForm();
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Main.ins.Close();
        }
        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = !ShowPasswordCheckBox.Checked;
        }
        Session1Entities entities;
        public static void run()
        {
            ins.LoginBtn_Click(null, null);
        }
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (Global.UserId.HasValue)
            {
                Global.ShowManagementForm();
                return;
            }
            entities = new Session1Entities();
            if (!string.IsNullOrEmpty(EmployeeTextBox.Text))
            {
                var match = entities.Users.FirstOrDefault(x=>x.Username==EmployeeTextBox.Text&&x.UserType.Name== "employee"&&x.Password==PasswordTextBox.Text);
                if (match != null)
                {
                    MessageBox.Show("employee login ok");
                    Global.UserId = match.ID;
                    if (KeepSigninCheckBox.Checked)
                    {
                       WSC1.Properties.Settings.Default.KeppLogin = Global.UserId.ToString();
                    }
                    else
                    {
                        WSC1.Properties.Settings.Default.KeppLogin = "";
                    }
                    WSC1.Properties.Settings.Default.Save();
                    Global.ShowManagementForm();
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
            else if(!string.IsNullOrEmpty(UserTextBox.Text))
            {
                var match = entities.Users.FirstOrDefault(x => x.Username == UserTextBox.Text && x.UserType.Name == "user" && x.Password == PasswordTextBox.Text);
                if (match != null)
                {
                    MessageBox.Show("user login ok");
                    Global.UserId = match.ID;
                    if (KeepSigninCheckBox.Checked)
                    {
                        WSC1.Properties.Settings.Default.KeppLogin = Global.UserId.ToString();
                    }
                    else
                    {
                        WSC1.Properties.Settings.Default.KeppLogin = "";
                    }
                    WSC1.Properties.Settings.Default.Save();
                    Global.ShowManagementForm();
                }
                else
                {
                    MessageBox.Show("error");
                }
            }

        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(WSC1.Properties.Settings.Default.KeppLogin))
            {
                Global.UserId = Convert.ToInt32(WSC1.Properties.Settings.Default.KeppLogin);
                LoginBtn_Click(sender, e);
            }
        }
    }
}
