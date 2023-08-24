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

namespace LouvreLIS_Management
{
    public partial class StaffAccountManagementForm : Form
    {
        public StaffAccountManagementForm()
        {
            InitializeComponent();
        }
        private void FilterBtn_Click(object sender, EventArgs e)
        {
            DataGridView.Rows.Clear();
            LouvreLISEntities entities = new LouvreLISEntities();
            var asd = entities.Employees.ToList().Select(x => new {
                FirstName = x.Account.FirstName,
                LastName = x.Account.LastName,
                ID=x.EmployeeID,
                Fullname = x.Account.LastName + " " + x.Account.FirstName,
                Gender = x.Account.Gender == "1" ? "Male" : "Female",
                Mail = x.Account.EmailAddress,
                Status = x.Account.AccountStatus == 0 ? "Disabled" : x.Account.AccountStatus == 1 ? "Pending" : "Normal",
                Role = x.EmployeeType.ToString()=="0"? "Sales" : x.EmployeeType.ToString()=="2"? "System Administrator" : "Executive Staff",
                Operation = x.EmployeeType.ToString() == "0" ? "" : x.EmployeeType.ToString() == "2" ? "Demote from Admin" : x.Account.AccountStatus.ToString()=="2"? "Promote to Admin" : ""
            }).ToList();
            if (!string.IsNullOrEmpty(NameTextbox.Text))
                asd = asd.Where(x => x.FirstName.Contains(NameTextbox.Text.Split(' ')[1]) && x.LastName.Contains(NameTextbox.Text.Split(' ')[0])).ToList();
            foreach (var item in asd)
                DataGridView.Rows.Add(item.ID,item.Fullname, item.Gender, item.Mail, item.Status, item.Role, item.Operation);
            for (int rowIndex = 0; rowIndex < DataGridView.Rows.Count; rowIndex++)
            {
                var Cell = DataGridView.Rows[rowIndex].Cells[6];
                if (Cell != null &&Cell.Value.ToString()=="")
                {
                    DataGridViewTextBoxCell textCell = new DataGridViewTextBoxCell();
                    textCell.Value = Cell.Value;
                    DataGridView.Rows[rowIndex].Cells[6] = textCell;
                }
            }
        }
        public string ssd { get; set; }
        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DataGridView.Columns[6].Index && e.RowIndex >= 0)
            {
                LouvreLISEntities entities = new LouvreLISEntities();
                string sda = DataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                var asd = entities.Employees.Where(x => x.EmployeeID == sda).FirstOrDefault();
                if (DataGridView.Rows[e.RowIndex].Cells[6].Value.ToString() == "Promote to Admin")
                {
                    if (entities.Employees.Where(x=>x.EmployeeType.ToString()=="2"&&x.Account.AccountStatus.ToString()=="2").Count()<=5)
                        asd.EmployeeType = 2;
                    else
                        MessageBox.Show("Too many administrator accounts, please deactivate or demote other accounts with administrator role.");
                }
                else if (DataGridView.Rows[e.RowIndex].Cells[6].Value.ToString() == "Demote from Admin")
                {
                    if (DataGridView.Rows[e.RowIndex].Cells[3].Value.ToString()==ssd)
                        MessageBox.Show("Sorry, you cannot demote your account.");
                    else
                        asd.EmployeeType = 1;
                }
                entities.SaveChanges();
                FilterBtn_Click(null,null);
            }
        }
    }
}
