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
using System.Globalization;

namespace LouvreLIS_Client
{
    public partial class AccountInformationForm : Form
    {
        LouvreEntities Entities = new LouvreEntities();
        public AccountInformationForm()=>InitializeComponent();
        string RealName = "",RealMail="";Guid RealId= Guid.Empty;
        public void InputData(string Name,string Mail,string Gender,string Language, string Status, Guid Id) 
        {
            Entities = new LouvreEntities();
                CodePanel.Visible = false;
            RealId = Id;
            RealName = Name;
            RealMail = Mail;
            UserNameLabel.Text = "Username:"+MaskString(RealName);
            EmailLabel.Text = "email:" + MaskEmail(RealMail);
            if (Status == "1")
            {
                VerifyLinkLabel.Visible = true;
                VerifyLabel.Visible = false;
            }
            else if(Status == "2")
            {
                VerifyLinkLabel.Visible = false;
                VerifyLabel.Visible = true;
            }
            GengerLabel.Text = "Genger:" + (Gender == "1" ? "Male" : "Female");
            PreferredLanguageLabel.Text = "Preferred Language:" +new CultureInfo(Language).DisplayName;
        }
        string MaskString(string Input)
        {
            if (Input.Length <= 4)
                return Input;
            string firstFourChars = Input.Substring(0, 4);
            string maskedPart = new string('*', Input.Length - 4);
            return firstFourChars + maskedPart;
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
        int errorPoint = 0;
        private void VerifyBtn_Click(object sender, EventArgs e)
        {
            if (CodeTextbox.Text== Result)
            {
                CodePanel.Visible = false;
               var Findaccount= Entities.Accounts.Find(RealId);
                Findaccount.AccountStatus = 2;
                Entities.SaveChanges();
                VerifyLinkLabel.Visible = false;
                VerifyLabel.Visible = true;
            }
            else
            {
                errorPoint++;
                CodePanel.Visible = true;
                    MessageBox.Show($"input error number:{errorPoint}");
                if (errorPoint == 3)
                {
                    errorPoint = 0;
                    if (Time == 0)
                        VerifyLinkLabel_LinkClicked(null,null);
                }
            }
        }
        string Result = "";
        int Time = 0;
        private void ModifyBtn_Click(object sender, EventArgs e)
        {
            Main.staticshowmodify();
        }
        private void Timer1S_Tick(object sender, EventArgs e)
        {
            Time++;
            if (Time == 120)
            {
                Time = 0;
                Result = "";
                Timer1S.Stop();
            }
        }
        private void ShowBtn_MouseDown(object sender, MouseEventArgs e)
        {
                UserNameLabel.Text = "Username:" + RealName;
                ShowBtn.Text = "hide";
        }
        private void ShowBtn_MouseUp(object sender, MouseEventArgs e)
        {
            UserNameLabel.Text = "Username:" + MaskString(RealName);
            ShowBtn.Text = "show";
        }
        private void VerifyLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SmtpClient Client = new SmtpClient("localhost",25);
            Client.UseDefaultCredentials = false;
            Client.Credentials = new NetworkCredential("LouvreMail", "4yOwQZ_hu8qv");
            MailMessage mailMessage = new MailMessage();
            mailMessage.From=new MailAddress("NoReply@mail.louvre.fr");
            mailMessage.To.Add(RealMail);
            mailMessage.Subject = "Email Verification";
            var asd = (DateTime.Now.AddMinutes(2)).ToString("yyyy/MM/dd HH:mm:ss");
            if (Time == 0)
            {
                Result = "";
                int[] allowedNumbers = { 0, 2, 3, 4, 5, 6, 8, 9 };
                Random random = new Random();
                for (int i = 0; i < 6; i++)
                    Result += allowedNumbers[random.Next(allowedNumbers.Length)].ToString();
                mailMessage.Body = $"verification code:{Result}{Environment.NewLine}The latest time to complete the verification:{asd}";
                try
                {
                    Client.Send(mailMessage);
                }
                catch
                {
                    MessageBox.Show("Something wentwrong, please try again later");
                }
                Timer1S.Start();
                errorPoint = 0;
            CodePanel.Visible = true;
            MessageBox.Show("Your 6-digits verification code has been sent. Please type the verification code in 2 minutes.");
            }
            else
                if(Time < 30)
                MessageBox.Show($"Please wait {120- Time} seconds before resending the verification code.");  
        }
    }
}