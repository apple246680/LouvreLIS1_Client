using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Net;
using System.Net.Mail;
using System.Data.Entity.Core.Metadata.Edm;
using System.Xml;
namespace LouvreLIS_Client
{
    public partial class AccountInformationForm : Form
    {
        LouvreEntities entities = new LouvreEntities();
        public AccountInformationForm()=>InitializeComponent();
        string realname = "",realmail="";Guid realid= Guid.Empty;
        public void InputData(string name,string mail,string gender,string language, string status, Guid id) 
        {
            entities = new LouvreEntities();
                CodePanel.Visible = false;
            realid = id;
            realname = name;
            realmail = mail;
            UserNameLabel.Text = "Username:"+MaskString(realname);
            EmailLabel.Text = "email:" + MaskEmail(realmail);
            if (status=="0")
            {
                VerifyLinkLabel.Visible = true;
                VerifyLabel.Visible = false;
            }
            else
            {
                VerifyLinkLabel.Visible = false;
                VerifyLabel.Visible = true;
            }
            GengerLabel.Text = "Genger:" + gender == "1" ? "Male" : "Female";
            PreferredLanguageLabel.Text = "Preferred Language:" + (language=="eu-us"? "English (United States)" : "French (France)");
        }
        string MaskString(string input)
        {
            if (input.Length <= 4)
                return input;
            string firstFourChars = input.Substring(0, 4);
            string maskedPart = new string('*', input.Length - 4);
            return firstFourChars + maskedPart;
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
        int errorpoint = 0;
        private void VerifyBtn_Click(object sender, EventArgs e)
        {
            if (CodeTextbox.Text==result)
            {
                CodePanel.Visible = false;
               var a= entities.Accounts.Find(realid);
                a.AccountStatus = 1;
                entities.SaveChanges();
                VerifyLinkLabel.Visible = false;
                VerifyLabel.Visible = true;
            }
            else
            {
                errorpoint++;
                CodePanel.Visible = true;
                    MessageBox.Show($"input error number:{errorpoint}");
                if (errorpoint==3)
                {
                    errorpoint = 0;
                    if (time==0)
                        VerifyLinkLabel_LinkClicked(null,null);
                }
            }
        }
            string result = "";
        int time = 0;
        private void ModifyBtn_Click(object sender, EventArgs e)
        {
            Main.staticshowmodify();
        }

        private void Timer1S_Tick(object sender, EventArgs e)
        {
            time++;
            if (time == 120)
            {
                time = 0;
                result = "";
                Timer1S.Stop();
            }
        }

        private void ShowBtn_MouseDown(object sender, MouseEventArgs e)
        {
                UserNameLabel.Text = "Username:" + realname;
                ShowBtn.Text = "hide";
        }

        private void ShowBtn_MouseUp(object sender, MouseEventArgs e)
        {
            UserNameLabel.Text = "Username:" + MaskString(realname);
            ShowBtn.Text = "show";
        }
        private void VerifyLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SmtpClient client = new SmtpClient("localhost",25);
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("LouvreMail", "4yOwQZ_hu8qv");
            MailMessage mailMessage = new MailMessage();
            mailMessage.From=new MailAddress("NoReply@mail.louvre.fr");
            mailMessage.To.Add(realmail);
            mailMessage.Subject = "Email Verification";
            var asd = (DateTime.Now.AddMinutes(2)).ToString("yyyy/MM/dd HH:mm:ss");
            if (time ==0)
            {
                result = "";
                int[] allowedNumbers = { 0, 2, 3, 4, 5, 6, 8, 9 };
                Random random = new Random();
                for (int i = 0; i < 6; i++)
                    result += allowedNumbers[random.Next(allowedNumbers.Length)].ToString();
                mailMessage.Body = $"verification code:{result}{Environment.NewLine}The latest time to complete the verification:{asd}";
                try
                {
                    client.Send(mailMessage);
                }
                catch
                {
                    MessageBox.Show("Something wentwrong, please try again later");
                }
                Timer1S.Start();
                errorpoint = 0;
            CodePanel.Visible = true;
            MessageBox.Show("Your 6-digits verification code has been sent. Please type the verification code in 2 minutes.");
            }
            else
                if(time <30)
                MessageBox.Show($"Please wait {120-time} seconds before resending the verification code.");  
        }
    }
}