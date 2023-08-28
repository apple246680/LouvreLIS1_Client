using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSC1
{
    public partial class TravelerForm : UserControl
    {
        public TravelerForm()
        {
            InitializeComponent();
        }
        private void SearchTextBox_Leave(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == "")
                SearchTextBox.Text = "Search destination or Listing Title or Attraction";
        }
        private void SearchTextBox_Enter(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == "Search destination or Listing Title or Attraction")
                SearchTextBox.Text = string.Empty;
        }
        private void TravelerForm_Load(object sender, EventArgs e)
        {
            Session1Entities entities = new Session1Entities();
            var asd = entities.Items.Where(x=>x.UserID==Global.UserId).Select(x => new
            {
                Title = x.Title,
                Capacity = x.Capacity,
                Area = x.Area.Name,
                Type = x.ItemType.Name
            }).ToList();
            ShowDataGridView.DataSource = asd;
            ItemCountLabel.Text = $"{asd.Count}items found.";
        }
        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            Session1Entities entities = new Session1Entities();
            if (SearchTextBox.Text != "Search destination or Listing Title or Attraction")
            {
                var asd = entities.Items.Where(x => x.UserID == Global.UserId).Where(x => x.Title.Contains(SearchTextBox.Text)||x.Area.Name.Contains(SearchTextBox.Text)||x.Capacity.ToString().Contains(SearchTextBox.Text)).Select(x => new
                {
                    Title = x.Title,
                    Capacity = x.Capacity,
                    Area = x.Area.Name,
                    Type = x.ItemType.Name
                }).ToList();
                ShowDataGridView.DataSource = asd;
                ItemCountLabel.Text = $"{asd.Count}items found.";
            }
        }
    }
}
