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
            }
        }
        int i = 0;

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Main.staticshowforgot();
        }
        private void Timer1S_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 120)
            {
                GetCodeLinkLabel.Text = "Resend verification code";
                Timer1S.Stop();
            }
            else
                GetCodeLinkLabel.Text = $"(Resend after {120-i} seconds)";
        }
    }
}
