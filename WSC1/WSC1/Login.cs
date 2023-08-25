using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace System
{
    public partial class LoginForm : UserControl
    {
        public LoginForm()
        {
            InitializeComponent();
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
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            entities = new Session1Entities();
            var match = entities.Users  .FirstOrDefault(x => x.Username == UserTextBox.Text);
            if (match != null)
            {
                if (match.Password == PasswordTextBox.Text)
                {
                    if (match.UserType.TypeID== 0)
                    {
                        MessageBox.Show("OK");
                    }
                    else if (match.UserType.TypeID == 1)
                    {
                        if (EmployeeTextBox.Text==match.UserType.EmployeeNumber)
                        {
                            MessageBox.Show("notOK");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("error");
            }



        }
    }
}
