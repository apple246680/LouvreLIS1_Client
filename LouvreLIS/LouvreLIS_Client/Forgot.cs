using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LouvreLIS_Client
{
    public partial class ForgotForm : Form
    {
        public ForgotForm()
        {
            InitializeComponent();
        }
        private void UsernameCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            SendBtnText();
        }
        public void SendBtnText()
        {
            if (UsernameCheckbox.Checked && PasswordCheckbox.Checked)
                SendBtn.Text = "Find my Username and Password";
            else if (UsernameCheckbox.Checked)
                SendBtn.Text = "Find my Username";
            else if (PasswordCheckbox.Checked)
                SendBtn.Text = "Find my Password";
            else
                SendBtn.Text = "Choose Username or Password";
        }
        private void PasswordCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            SendBtnText();
        }
        LouvreEntities Entities = null;
        private void SendBtn_Click(object sender, EventArgs e)
        {
           Entities = new LouvreEntities();
            if (SendBtn.Text != "Choose Username or Password")
            {
                if (Entities.Accounts.Any(x => x.EmailAddress == EmailTextbox.Text))
                    Main.StaticShowForgotCode(EmailTextbox.Text, SendBtn.Text);
                else
                    MessageBox.Show("Invalid email address.");
            }
            else
                MessageBox.Show("please choose");
        }
    }
}
