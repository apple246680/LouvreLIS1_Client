using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LouvreLIS_Client
{
    public partial class ForgotcodeForm : Form
    {
        public ForgotcodeForm()
        {
            InitializeComponent();
        }
        string realmail,realtitle;
        public void getdataandrun(string email,string title) 
        {
            panel2.Visible = false;
            realtitle = title;
            realmail = email;
            TopLabel.Text = $"Please check your mailbox({MaskEmail(email)}) for one time \r\npasscode, type the verification code below in 2 minutes.";
            GetCodeLinkLabel_LinkClicked(null,null);
        }
        string MaskEmail(string email)
        {
            int atIndex = email.IndexOf('@');
            if (atIndex < 0 || atIndex < 2)
                return email;
            string firstTwoChars = email.Substring(0, 2);
            string maskedPart = new string('*', atIndex - 2);
            string domainPart = email.Substring(atIndex);
            return firstTwoChars + maskedPart + domainPart;
        }
        string result;
        private void GetCodeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (GetCodeLinkLabel.Text == "Resend verification code")
            {
                var asd = (DateTime.Now.AddMinutes(2)).ToString("yyyy/MM/dd HH:mm:ss");
                SmtpClient client = new SmtpClient("localhost", 25);
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("LouvreMail", "4yOwQZ_hu8qv");
                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("NoReply@mail.louvre.fr");
                mailMessage.To.Add(realmail);
                mailMessage.Subject = realtitle;
                result = string.Join("", Enumerable.Range(0, 10).OrderBy(x => Guid.NewGuid()).Take(6));
                mailMessage.Body = $"verification code:{result}{Environment.NewLine}The latest time to complete the verification:{asd}";
                try
                {
                    client.Send(mailMessage);
                }
                catch
                {
                    MessageBox.Show("Something wentwrong, please try again later");
                }
                i = 0;
                Timer1S.Start();
                z = 0;
            }
        }
        int i = 0;
        private void BackBtn_Click(object sender, EventArgs e)
        {
            Main.staticshowforgot();
        }
        LouvreEntities entities = new LouvreEntities();
        int z = 0;
        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (result==CodeTextbox.Text)
            {
                panel1.Visible = false;
                panel2.Visible = true;
               var asd= entities.Accounts.Where(x => x.EmailAddress == realmail);
                UsernameLabel.Text = "Username:"+asd.Select(x=>x.Username).ToList()[0];
                PasswordLabel.Text = "Password:" + asd.Select(x => x.Password).ToList()[0];
                if (realtitle == "Find my Username")
                {
                    UsernameLabel.Visible = true;
                    PasswordLabel.Visible = false;
                }
                else if (realtitle == "Find my Password") 
                {
                    UsernameLabel.Visible =false;
                    PasswordLabel.Visible = true;
                }
                else
                {
                    UsernameLabel.Visible = true;
                    PasswordLabel.Visible = true;
                }
            }
            else
            {
                z++;
                MessageBox.Show($"input error number:{z}");
                if (z==3)
                {
                    z = 0;
                    if (i==0)
                        GetCodeLinkLabel_LinkClicked(null,null);
                }
            }
        }
        private void FinishBtn_Click(object sender, EventArgs e)
        {
            Main.backlogin();
        }
        private void SignInBtn_Click(object sender, EventArgs e)
        {
            var match = entities.Accounts.FirstOrDefault(x=>x.EmailAddress==realmail);
            Main.staticso(match);
        }
        private void Timer1S_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 120)
            {
                GetCodeLinkLabel.Text = "Resend verification code";
                i = 0;
                Timer1S.Stop();
            }
            else
                GetCodeLinkLabel.Text = $"(Resend after {120-i} seconds)";
        }
    }
}
