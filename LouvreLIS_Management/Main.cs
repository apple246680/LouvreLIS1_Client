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

namespace LouvreLIS_Management
{
    public partial class Main : Form
    {
        static Main instance = new Main();
        public Main()
        {
            InitializeComponent();
            instance=this;
        }
        Account account = null;
        public void getlogindata(Account asd)
        {
            SignBtn.Text = "Sign Out";
            UsernameLabel.Text = "Current User:" + asd.Username;
            account = asd;
            AccountInfoBtn_Click(null, null);
            AccountInfoBtn.Visible = true;
        }
        static public void staticgetlogindata(Account asd)
        {
            instance.getlogindata(asd);
        }
        private void SignBtn_Click(object sender, EventArgs e)
        {
            if (SignBtn.Text=="Sign In")
            {
                LoginForm loginForm=new LoginForm();
                ShowPanel.Controls.Clear();
                loginForm.TopLevel = false;
                ShowPanel.Controls.Add(loginForm);
                loginForm.Show();
            }
            else
            {
                UsernameLabel.Text = "Current User:Not Signed In";
                SignBtn.Text = "Sign In";
                SignBtn_Click(sender,e);
                AccountInfoBtn.Visible = false;
            }
        }
        AccountInfoForm accountInfoForm=new AccountInfoForm();
        private void AccountInfoBtn_Click(object sender, EventArgs e)
        {
            ShowPanel.Controls.Clear();
            accountInfoForm.TopLevel = false;
            ShowPanel.Controls.Add(accountInfoForm);
            accountInfoForm.run(account);
            accountInfoForm.Show();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            SignBtn_Click(sender, e);
        }
    }
}
