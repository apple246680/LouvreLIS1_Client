using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace LouvreLIS_Client
{
    public partial class ModifyForm : Form
    {
        public ModifyForm()
        {
            InitializeComponent();
        }
        Guid needguid= Guid.Empty;
        public void GetData(Guid Id,string Email,string Firstname,string Lastname,string Gender,string Language) 
        { 
            needguid = Id;
            EmailTextbox.Text= Email;
            FirstNameTextbox.Text= Firstname;
            LastNameTextbox.Text= Lastname;
            GenderCombobox.Text = Gender == "1" ? "Male" : "Female";
            PreferredLanguageCombobox.Text =new CultureInfo(Language).DisplayName;
        }
        private void ReviseBtn_Click(object sender, EventArgs e)
        {
            LouvreEntities Entities = new LouvreEntities();
            var FindData= Entities.Accounts.Find(needguid);      
            if (FindData != null&&EmailTextbox.Text!=""&&FirstNameTextbox.Text!=""&&LastNameTextbox.Text!=""&&GenderCombobox.Text!=""&&PreferredLanguageCombobox.Text!="")
            {
                if (EmailTextbox.Text != FindData.EmailAddress)
                {
                    FindData.EmailAddress = EmailTextbox.Text;
                    FindData.AccountStatus = 0;
                }
                FindData.FirstName = FirstNameTextbox.Text;
                FindData.LastName = LastNameTextbox.Text;
                FindData.Gender = GenderCombobox.Text== "Male" ? "1":"2";
                FindData.Visitor.PreferredLanguage= GetCultureCodeByDisplayName(PreferredLanguageCombobox.Text);
                Entities.SaveChanges();
                MessageBox.Show("OK");
                Main.BackAccountInformation();
                
            }
        }
        string GetCultureCodeByDisplayName(string displayName)
        {
            foreach (CultureInfo ci in CultureInfo.GetCultures(CultureTypes.AllCultures))
            {
                if (ci.DisplayName == displayName)
                {
                    return ci.Name;
                }
            }
            return "No find";
        }
    }
}