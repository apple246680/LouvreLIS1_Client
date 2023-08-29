using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Sesosin3
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Init();
        }
        public void Init()
        {
            ResultGroupBox.Visible = false;
            ListBoxHint.Visible = false;
            SearchTextBox.Text = "";
            ResultDataGridView.Rows.Clear();
            ResultLabel.Text = "";
            FromDateTimePicker.Value = DateTime.Now.Date;
            FromDateTimePicker.MinDate = DateTime.Now;
        }
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            using (Session3Entities entities = new Session3Entities())
            {
                var items = entities.Items.ToList();
                if (!String.IsNullOrEmpty(SearchTextBox.Text))
                    items = items.Where(t => t.Areas.Name == SearchTextBox.Text
                        || t.Title == SearchTextBox.Text
                        || t.ItemAttractions.Any(x => x.Attractions.Name == SearchTextBox.Text)
                        || t.ItemTypes.Name == SearchTextBox.Text
                        || t.ItemAmenities.Any(x => x.Amenities.Name == SearchTextBox.Text)).ToList();
                int nights = (int)NightsNumber.Value;
                int people = (int)PeopleNumber.Value;
                DateTime from = FromDateTimePicker.Value;
                DateTime to = from.AddDays(nights);
                items = items.Where(t => t.ItemPrices.Any(x => x.Date >= from && x.Date <= to)
                    && t.Capacity >= people).OrderBy(t => t.Title).ToList();
                ResultDataGridView.Rows.Clear();
                items.ForEach(t =>
                {
                    var score = t.ItemScores.Any() ? Math.Round(t.ItemScores.Average(x => x.Value), 2).ToString() : "";
                    var totalComplate = t.ItemPrices.Any() ?
                        t.ItemPrices.Count(x => x.BookingDetails.Any(y => !y.isRefund)) : 0;
                    var amount = t.ItemPrices.Any(x => x.Date >= from && x.Date < to)
                        ? t.ItemPrices.Where(x => x.Date >= from && x.Date <= to).Sum(y => y.Price).ToString() + "$" : "Price data not found.";
                    ResultDataGridView.Rows.Add(t.Title, t.Areas.Name, score, totalComplate, amount);
                });
                ResultLabel.Text = $"Displaying {items.Count()} options";
                Text = "Seoul Stay - Search Results";
                ResultGroupBox.Visible = true;
            }
        }
        private void AdvanedBtn_Click(object sender, EventArgs e)
        {
            FormAdvanced form = new FormAdvanced();
            Visible = false;
            form.ShowDialog();
            Visible = true;
        }
        private void HintLabel_Click(object sender, EventArgs e)
        {
            SearchTextBox.Focus();
        }
        private void SearchTextBox_Enter(object sender, EventArgs e)
        {
            HintLabel.Visible = false;
        }
        private void SearchTextBox_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(SearchTextBox.Text))
                HintLabel.Visible = true;
        }
        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            ListBoxHint.Visible = false;
            if (SearchTextBox.Text.Length >= 3)
                using (Session3Entities entities = new Session3Entities())
                {
                    entities.Areas.Where(t => t.Name.Contains(SearchTextBox.Text)).ToList().ForEach(t =>
                    {
                        ListBoxHint.Items.Add(t.Name + "      Area");
                    });
                    entities.Attractions.Where(t => t.Name.Contains(SearchTextBox.Text)).ToList().ForEach(t =>
                    {
                        ListBoxHint.Items.Add(t.Name + "      Attraction");
                    });
                    entities.Items.Where(t => t.Title.Contains(SearchTextBox.Text)).ToList().ForEach(t =>
                    {
                        ListBoxHint.Items.Add(t.Title + "      Listing");
                    });
                    entities.ItemTypes.Where(t => t.Name.Contains(SearchTextBox.Text)).ToList().ForEach(t =>
                    {
                        ListBoxHint.Items.Add(t.Name + "      ItemType");
                    });

                    entities.Amenities.Where(t => t.Name.Contains(SearchTextBox.Text)).ToList().ForEach(t =>
                    {
                        ListBoxHint.Items.Add(t.Name + "      Amenities");
                    });
                    if (ListBoxHint.Items.Count != 0)
                    {
                        ListBoxHint.BringToFront();
                        ListBoxHint.Visible = true;
                        ListBoxHint.SelectedIndex = 0;
                    }
                    if (ListBoxHint.Text.Replace("      ", "@").Split('@')[0] == SearchTextBox.Text)
                        ListBoxHint.Visible = false;
                }
        }

        private void ListBoxHint_KeyDown(object sender, KeyEventArgs e)
        {
            ListBoxHint.Visible = false;
            SearchTextBox.Text = ListBoxHint.Text.Replace("      ", "@").Split('@')[0];
        }
        private void ListBoxHint_MouseClick(object sender, MouseEventArgs e)
        {
            ListBoxHint.Visible = false;
            SearchTextBox.Text = ListBoxHint.Text.Replace("      ", "@").Split('@')[0];
        }
    }
}