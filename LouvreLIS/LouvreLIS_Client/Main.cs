using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LouvreLIS_Client
{
    public partial class Main : Form
    {
        static Main Instance = new Main();
        public Main()
        {
            InitializeComponent();
            Instance=this;
        }
        TicketsForm ticketsForm=new TicketsForm();
        public void ShowAccountinfo(string Name, string Mail, string Gender, string Language,string Status, Guid Id) {
            SignInOutBtn.Text = "Sign out";
            UserNameLabel.Text = "Current User:" + Name;
            AccountInformationToolStripMenuItem_Click(null,null);
            accountInformationForm.InputData(Name,Mail,Gender,Language,Status,Id);
            SignInOutBtn.Visible = true;
            menuStrip1.Visible = true;
        }
        static public void BackAccountInformation()
        {
            Instance.AccountInformationToolStripMenuItem_Click(null,null);
        }
        ModifyForm ModifyForm=new ModifyForm();
        public static void staticshowmodify() {
            Instance.ShowModify();
        }
        public void ShowModify() 
        {
            ShowPanel.Controls.Clear();
            ModifyForm.TopLevel = false;
            ShowPanel.Controls.Add(ModifyForm);
            ModifyForm.GetData(VeryAccount.ID,VeryAccount.EmailAddress,VeryAccount.FirstName,VeryAccount.LastName,VeryAccount.Gender,VeryAccount.Visitor.PreferredLanguage);
            ModifyForm.Show();
        }
        public void ShowForgotCode(string email,string title)
        {
            ForgotcodeForm forgotcodeForm=new ForgotcodeForm();
            ShowPanel.Controls.Clear();
            forgotcodeForm.TopLevel = false;
            ShowPanel.Controls.Add(forgotcodeForm);
            forgotcodeForm.GetDataAndRun(email,title);
            forgotcodeForm.Show();
        }
        static public void StaticShowForgotCode(string email,string title)
        {
            Instance.ShowForgotCode(email,title);
        }
        Account VeryAccount = null;
        static public void StaticShowAccountinfo(Account account)
        {
            Instance.ShowAccountinfo(account.Username,account.EmailAddress,account.Gender,account.Visitor.PreferredLanguage,account.AccountStatus.ToString(),account.ID);
            Instance.VeryAccount = account;    
        }
            ForgotForm forgotForm = new ForgotForm();
        public void ShowForgot() 
        {
            ShowPanel.Controls.Clear();
            forgotForm.TopLevel = false;
            ShowPanel.Controls.Add(forgotForm);
            forgotForm.Show();
        }
        static public void StaticShowForgot() 
        {
            Instance.ShowForgot();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            menuStrip1.Visible = false;
            ShowPanel.Controls.Clear();
            loginForm.TopLevel= false;
            ShowPanel.Controls.Add(loginForm);
            loginForm.Show();
        }
            AccountInformationForm accountInformationForm = new AccountInformationForm();
        private void AccountInformationBtn_Click(object sender, EventArgs e)
        {
            ShowPanel.Controls.Clear();
            accountInformationForm.TopLevel = false;
            ShowPanel.Controls.Add(accountInformationForm);
            accountInformationForm.Show();
        }
        static public void Backlogin()
        {
            Instance.Main_Load(null,null);
        }
        private void SignInBtn_Click(object sender, EventArgs e)
        {
            if (SignInOutBtn.Text== "Sign In"&&UserNameLabel.Text== "Current User:")
            {
                Main_Load(null,null);
            }
            else
            {
                UserNameLabel.Text = "Current User:";
                Main_Load(null, null);
                SignInOutBtn.Text = "Sign In";
            }
        }
        private void MyTicketBtn_Click(object sender, EventArgs e)
        {
            ShowPanel.Controls.Clear();
            ticketsForm.TopLevel = false;
            ShowPanel.Controls.Add(ticketsForm);
            ticketsForm.GetData(VeryAccount);
            ticketsForm.Show();
        }
        private void AccountInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel.Controls.Clear();
            accountInformationForm.TopLevel = false;
            ShowPanel.Controls.Add(accountInformationForm);
            accountInformationForm.Show();
        }

        private void MyTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel.Controls.Clear();
            ticketsForm.TopLevel = false;
            ShowPanel.Controls.Add(ticketsForm);
            ticketsForm.GetData(VeryAccount);
            ticketsForm.Show();
        }
    }
}
