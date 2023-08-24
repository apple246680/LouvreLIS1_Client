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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace LouvreLIS_Client
{
    public partial class ForgotcodeForm : Form
    {
        public ForgotcodeForm()
        {
            InitializeComponent();
        }
        string RealMail,RealTitle;
        public void GetDataAndRun(string Email,string Title) 
        {
            VerificationSuccessfulPanel.Visible = false;
            RealTitle = Title;
            RealMail = Email;
            TopLabel.Text = $"Please check your mailbox({MaskEmail(Email)}) for one time \r\npasscode, type the verification code below in 2 minutes.";
            GetCodeLinkLabel_LinkClicked(null,null);
        }
        string MaskEmail(string Email)
        {
            int atIndex = Email.IndexOf('@');
            if (atIndex < 0 || atIndex < 2)
                return Email;
            string firstTwoChars = Email.Substring(0, 2);
            string maskedPart = new string('*', atIndex - 2);
            string domainPart = Email.Substring(atIndex);
            return firstTwoChars + maskedPart + domainPart;
        }
        string Result;
        private void GetCodeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (GetCodeLinkLabel.Text == "Resend verification code")
            {
                var EffectiveTime = (DateTime.Now.AddMinutes(2)).ToString("yyyy/MM/dd HH:mm:ss");
                SmtpClient Client = new SmtpClient("localhost", 25);
                Client.UseDefaultCredentials = false;
                Client.Credentials = new NetworkCredential("LouvreMail", "4yOwQZ_hu8qv");
                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("NoReply@mail.louvre.fr");
                mailMessage.To.Add(RealMail);
                mailMessage.Subject = RealTitle;
                Result = string.Join("", Enumerable.Range(0, 10).OrderBy(x => Guid.NewGuid()).Take(6));
                mailMessage.Body = $"verification code:{Result}{Environment.NewLine}The latest time to complete the verification:{EffectiveTime}";
                try
                {
                    Client.Send(mailMessage);
                }
                catch
                {
                    MessageBox.Show("Something wentwrong, please try again later");
                }
                Per30S = 0;
                Expired = false;
                Per120S = 0;
                Timer1S.Start();
                Timer1S2.Start();
                errorPoint = 0;
            }
        }
        int Per30S = 0;
        private void BackBtn_Click(object sender, EventArgs e)
        {
            Main.StaticShowForgot();
        }
        LouvreEntities Entities = new LouvreEntities();
        int errorPoint = 0;
        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (Result == CodeTextbox.Text && Expired == false)
            {
                VerifyPanel.Visible = false;
                VerificationSuccessfulPanel.Visible = true;
               var FindAccount= Entities.Accounts.Where(x => x.EmailAddress == RealMail);
                UsernameLabel.Text = "Username:"+ FindAccount.Select(x=>x.Username).ToList()[0];
                PasswordLabel.Text = "Password:" + FindAccount.Select(x => x.Password).ToList()[0];
                if (RealTitle == "Find my Username")
                {
                    UsernameLabel.Visible = true;
                    PasswordLabel.Visible = false;
                }
                else if (RealTitle == "Find my Password") 
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
                errorPoint++;
                MessageBox.Show($"input error number:{errorPoint}");
                if (errorPoint == 3)
                {
                    errorPoint = 0;
                    if (Per30S ==0)
                        GetCodeLinkLabel_LinkClicked(null,null);
                }
            }
        }
        private void FinishBtn_Click(object sender, EventArgs e)
        {
            Main.Backlogin();
        }
        private void SignInBtn_Click(object sender, EventArgs e)
        {
            var match = Entities.Accounts.FirstOrDefault(x=>x.EmailAddress==RealMail);
            Main.StaticShowAccountinfo(match);
        }
        int Per120S = 0;bool Expired = false;
        private void Timer1S2_Tick(object sender, EventArgs e)
        {
            Per120S++;
            if (Per120S == 120)
            {
                Expired = true;
                Per120S = 0;
                Timer1S2.Stop();
            }
        }
        private void Timer1S_Tick(object sender, EventArgs e)
        {
            Per30S++;
            if (Per30S == 30)
            {
                GetCodeLinkLabel.Text = "Resend verification code";
                Per30S = 0;
                Timer1S.Stop();
            }
            else
                GetCodeLinkLabel.Text = $"(Resend after {30-Per30S} seconds)";
        }
    }
}
