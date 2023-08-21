using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LouvreLIS_Management
{
    public partial class AccountInfoForm : Form
    {
        public AccountInfoForm()
        {
            InitializeComponent();
        }
        public void run(Account asd)
        {
            EmployeeIDLabel.Text = "EmployeeID:" + asd.Employee.EmployeeID;
            EmployeeTypeLabel.Text = "EmployeeType:" +(asd.Employee.EmployeeType == '0' ? "Sales" : asd.Employee.EmployeeType == '1' ? "Executive Staff" : "System Administrator");
            EmailLabel.Text = "Email:" + asd.EmailAddress;
            GenderLabel.Text = "Gender:"+ (asd.Gender == "1" ? "Male" : "Female");
            LastNameLabel.Text="Last Name:"+asd.LastName;
            FirstNameLabel.Text = "First Name:" + asd.FirstName;
        }
    }
}
