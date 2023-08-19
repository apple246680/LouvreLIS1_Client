﻿using System;
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
            var match = entities.Accounts.FirstOrDefault(x=>(x.EmailAddress==AccountTextBox.Text||x.Username==AccountTextBox.Text)&&x.Password==PasswordTextbox.Text);
            if (match!=null &&match.AccountType==1) 
            {
                if (entities.Employees.Any(x => x.AccountID == match.ID))
                {
                    MessageBox.Show("Cannot sign in for employees.");
                }
                else
                {
                    MessageBox.Show("登入成功");
                    Main.staticso(match);
                }
            }
            else if (match != null && match.AccountType == 0)
            {
                MessageBox.Show("Cannot sign in your account, please contact helpdesk service.");
            }
            else
            {
                MessageBox.Show("Invalid account or password");
            }
        }
    }
}
