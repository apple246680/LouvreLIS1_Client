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
    public partial class VisitorAccountManagementForm : Form
    {
        public VisitorAccountManagementForm()
        {
            InitializeComponent();
        }

        private void FilterBtn_Click(object sender, EventArgs e)
        {
            DataGridView.Rows.Clear();
            LouvreLISEntities Entities = new LouvreLISEntities();
           var asd= Entities.Visitors.ToList().Select(x => new {
               FirstName=x.Account.FirstName,
               LastName=x.Account.LastName,
               UserName=x.Account.Username,
               Fullname= x.Account.LastName+ " " + x.Account.FirstName,
               Gender= x.Account.Gender == "1" ? "Male" : "Female",
               Mail=x.Account.EmailAddress,
               Status=x.Account.AccountStatus==0? "Disabled" : x.Account.AccountStatus==1? "Pending" : "Normal",
               PreferredLanguage= new CultureInfo(x.PreferredLanguage).DisplayName,
               Operation= x.Account.AccountStatus == 0 ? "Enable" : x.Account.AccountStatus == 1 ? "---" : "Disable"
            }).ToList();
            if (!string.IsNullOrEmpty(UsernameTextbox.Text))
                asd = asd.Where(x => x.UserName == UsernameTextbox.Text).ToList();
            else
            {
                if(!string.IsNullOrEmpty(NameTextbox.Text))
                asd=asd.Where(x=>x.FirstName.Contains(NameTextbox.Text.Split(' ')[1])&& x.LastName.Contains(NameTextbox.Text.Split(' ')[0])).ToList();
                if (!string.IsNullOrEmpty(GenderComobox.Text))
                    asd = asd.Where(x=>x.Gender==GenderComobox.Text).ToList();
                asd = asd.Where(x=>x.Mail.Contains(EmailTextbox.Text)).ToList();
                if(!string.IsNullOrEmpty(StatusCombobox.Text))
                    asd = asd.Where(x=>x.Status==StatusCombobox.Text).ToList();
                if (!string.IsNullOrEmpty(PreferredLanguageCombobox.Text))
                    asd = asd.Where(x=>x.PreferredLanguage==PreferredLanguageCombobox.Text).ToList();
            }
            foreach (var item in asd)
                DataGridView.Rows.Add(item.Fullname,item.Gender,item.Mail,item.Status,item.PreferredLanguage,item.Operation);
            for (int rowIndex = 0; rowIndex < DataGridView.Rows.Count; rowIndex++)
            {
                DataGridViewLinkCell linkCell = DataGridView.Rows[rowIndex].Cells[5] as DataGridViewLinkCell;
                if (linkCell != null && linkCell.Value != null && linkCell.Value.ToString() == "---")
                {
                    DataGridViewTextBoxCell textCell = new DataGridViewTextBoxCell();
                    textCell.Value = linkCell.Value;
                    DataGridView.Rows[rowIndex].Cells[5] = textCell;
                }
            }
        }
        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DataGridView.Columns[5].Index && e.RowIndex >= 0)
            {
                LouvreLISEntities entities = new LouvreLISEntities();
                string sda = DataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                    var asd= entities.Accounts.Where(x=>x.EmailAddress== sda).FirstOrDefault();
                if (DataGridView.Rows[e.RowIndex].Cells[5].Value.ToString() == "Enable")
                    asd.AccountStatus = 2;
                else if (DataGridView.Rows[e.RowIndex].Cells[5].Value.ToString() == "Disable")
                    asd.AccountStatus= 0;
                entities.SaveChanges();
                FilterBtn_Click(null,null);
            }
        }
    }
}