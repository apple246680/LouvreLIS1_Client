using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LouvreLIS_Management
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        LouvreLISEntities entities = new LouvreLISEntities();
        private void SigninBtn_Click(object sender, EventArgs e)
        {
            var match = entities.Accounts.FirstOrDefault(x=>x.Username==UsernameTextbox.Text&&x.Password==PasswordTextbox.Text);
            if (match != null) 
            {
                if (match.AccountStatus == 1)
                    if (match.Employee.EmployeeID.Any())
                    {
                        MessageBox.Show("OK");
                        Main.staticgetlogindata(match);
                    }
                    else
                        MessageBox.Show("Cannot sign in for visitors.");
                else
                    MessageBox.Show("Cannot sign in your account, please contact system administrator.");
            }
            else
                MessageBox.Show("Invalid account or password.");
        }
    }
}
