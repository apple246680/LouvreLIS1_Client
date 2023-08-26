using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WSC1;

namespace System
{
    public partial class CreateAccountForm : UserControl
    {
        public CreateAccountForm()
        {
            InitializeComponent();
        }

        private void BaclLoginBtn_Click(object sender, EventArgs e)
        {
            Global.ShowLoginForm();
        }

        private void UELALinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(Application.StartupPath+"\\Terms.txt");
            AgreeUELACheckBox.Enabled = true;
        }
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
        Session1Entities entities = new Session1Entities();
            if (entities.Users.Any(x => x.Username == UsernameTextbox.Text)&& !string.IsNullOrEmpty(UsernameTextbox.Text))
            {
                MessageBox.Show("have it username");
                return;
            }
            else
            {
                User user = new User();
                if (!string.IsNullOrEmpty(PasswordTextbox.Text)&& !string.IsNullOrEmpty(FullNameTextbox.Text)&&!string.IsNullOrEmpty(RetypePasswordTextbox.Text))
                {
                    if (PasswordTextbox.Text == RetypePasswordTextbox.Text)
                        user.Password = PasswordTextbox.Text;
                    else
                    {
                        MessageBox.Show("password!=retypepassword");
                        return;
                    }
                    if (AgreeUELACheckBox.Checked==false)
                    {
                        MessageBox.Show("check EULA");
                        return;
                    }
                    if (!string.IsNullOrEmpty(FullNameTextbox.Text))
                    {
                        user.GUID = Guid.NewGuid();
                        user.UserTypeID = 2;
                        user.Username = UsernameTextbox.Text;
                        user.FullName = FullNameTextbox.Text;
                        user.BirthDate = DatePicker.Value;
                        user.Gender = MaleRadioButton.Checked;
                        user.FamilyCount=(int)FamilyNumberNumericUpDown.Value;
                        entities.Users.Add(user);
                        entities.SaveChanges();
                        MessageBox.Show("add ok");
                        Global.ShowManagementForm();
                    }
                    else
                        MessageBox.Show("full name need full");
                }
                else
                    MessageBox.Show("item cnat null");
            }
        }
    }
}