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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        LouvreEntities entities = new LouvreEntities(); 
        private void button1_Click(object sender, EventArgs e)
        {
            var Natch = entities.Accounts.FirstOrDefault(x=>(x.EmailAddress==AccountTextBox.Text||x.Username==AccountTextBox.Text)&&x.Password==PasswordTextbox.Text);
            if (Natch != null && Natch.AccountStatus!=0) 
                if (entities.Employees.Any(x => x.AccountID == Natch.ID))
                    MessageBox.Show("Cannot sign in for employees.");
                else
                {
                    MessageBox.Show("OK");
                    Main.StaticShowAccountinfo(Natch);
                }
            else if (Natch != null && Natch.AccountType == 0)
                MessageBox.Show("Cannot sign in your account, please contact helpdesk service.");
            else
                MessageBox.Show("Invalid account or password");
        }
        private void ForgotLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Main.StaticShowForgot();
        }
    }
}
