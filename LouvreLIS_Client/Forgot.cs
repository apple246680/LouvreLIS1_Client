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
            run();
        }
        public void run() {
            if (UsernameCheckbox.Checked)
                button1.Text = "Find my Username";
            if (PasswordCheckbox.Checked)
                button1.Text = "Find my Password";
            if (UsernameCheckbox.Checked && PasswordCheckbox.Checked)
                button1.Text = "Find my Username and Password";
            if (UsernameCheckbox.Checked==false&&PasswordCheckbox.Checked==false)
                    button1.Text = "Choose Username or Password";
        }
        private void PasswordCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            run();
        }
        LouvreEntities entities = new LouvreEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            if (entities.Accounts.Any(x => x.EmailAddress == EmailTextbox.Text))
                MessageBox.Show("Invalid email address.");
            else
            {
                var asd=Enumerable.Range(0,10).OrderBy(x=>Guid.NewGuid()).Take(6);
                string result = string.Join("", asd);
            }

        }
    }
}
