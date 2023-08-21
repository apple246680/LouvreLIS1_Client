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
    public partial class ModifyForm : Form
    {
        static ModifyForm ins;
        public ModifyForm()
        {
            InitializeComponent();
            ins = this;
        }
        Guid needguid= Guid.Empty;
        public void GetData(Guid id,string email,string firstname,string lastname,string gender,string language) 
        { 
            needguid = id;
            EmailTextbox.Text=email;
            FirstNameTextbox.Text=firstname;
            LastNameTextbox.Text=lastname;
            GenderCombobox.Text = gender == "1" ? "Male" : "Female";
            PreferredLanguageCombobox.Text=language== "fr-fr"? "French (France)" : "American (English)";
        }
        private void ReviseBtn_Click(object sender, EventArgs e)
        {
            LouvreEntities entities = new LouvreEntities();
            var finddata=entities.Accounts.Find(needguid);      
            if (finddata != null&&EmailTextbox.Text!=""&&FirstNameTextbox.Text!=""&&LastNameTextbox.Text!=""&&GenderCombobox.Text!=""&&PreferredLanguageCombobox.Text!="")
            {
                if (EmailTextbox.Text != finddata.EmailAddress)
                {
                    finddata.EmailAddress = EmailTextbox.Text;
                    finddata.AccountStatus = 0;
                }
                finddata.FirstName = FirstNameTextbox.Text;
                finddata.LastName = LastNameTextbox.Text;
                finddata.Gender = GenderCombobox.Text=="男"?"1":"2";
                finddata.Visitor.PreferredLanguage= PreferredLanguageCombobox.Text== "French (France)"? "fr-fr" : "en-us";
                entities.SaveChanges();
                MessageBox.Show("成功");
                Main.backaccountinformation();
                
            }
        }
    }
}