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
        static Main instance = new Main();
        public Main()
        {
            InitializeComponent();
            instance=this;
        }
        TicketsForm ticketsForm=new TicketsForm();
        public void so(string name, string mail, string gender, string language,string status, Guid id) {
            SignInOutBtn.Text = "Sign out";
            UserNameLabel.Text = "Current User:" + name;
            AccountInformationBtn_Click(null,null);
            accountInformationForm.InputData(name,mail,gender,language,status,id);
            SignInOutBtn.Visible = true;
            TopPanel.Visible = true;
        }
        static public void backaccountinformation()
        {
             instance.AccountInformationBtn_Click(null,null);
        }
   
        ModifyForm ModifyForm=new ModifyForm();
        public static void staticshowmodify() {
            instance.showmodify();
        }
        public void showmodify() 
        {
            ShowPanel.Controls.Clear();
            ModifyForm.TopLevel = false;
            ShowPanel.Controls.Add(ModifyForm);
            ModifyForm.GetData(aaa.ID,aaa.EmailAddress,aaa.FirstName,aaa.LastName,aaa.Gender,aaa.Visitor.PreferredLanguage);
            ModifyForm.Show();
        }
        public void showforgotcode(string email,string title)
        {
            ForgotcodeForm forgotcodeForm=new ForgotcodeForm();
            ShowPanel.Controls.Clear();
            forgotcodeForm.TopLevel = false;
            ShowPanel.Controls.Add(forgotcodeForm);
            forgotcodeForm.getdataandrun(email,title);
            forgotcodeForm.Show();
        }
        static public void staticshowforgotcode(string email,string title)
        {
            instance.showforgotcode(email,title);
        }
        Account aaa = null;
        static public void staticso(Account account)
        {
            instance.so(account.Username,account.EmailAddress,account.Gender,account.Visitor.PreferredLanguage,account.AccountStatus.ToString(),account.ID);
            instance.aaa = account;    
        }
            ForgotForm forgotForm = new ForgotForm();
        public void showforgot() 
        {
            ShowPanel.Controls.Clear();
            forgotForm.TopLevel = false;
            ShowPanel.Controls.Add(forgotForm);
            forgotForm.Show();
        }
        static public void staticshowforgot() 
        { 
            instance.showforgot();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            TopPanel.Visible = false;
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
        static public void backlogin()
        {
            instance.Main_Load(null,null);
        }
        private void SignInBtn_Click(object sender, EventArgs e)
        {
            if (SignInOutBtn.Text== "Sign In")
            {
                Main_Load(null,null);
                SignInOutBtn.Text = "Sing Out";
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
            ticketsForm.getdata(aaa);
            ticketsForm.Show();
        }
    }
}
