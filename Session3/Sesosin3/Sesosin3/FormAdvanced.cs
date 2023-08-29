using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
namespace Sesosin3
{
    public partial class FormAdvanced : Form
    {
        public FormAdvanced()
        {
            InitializeComponent();
            ResultGroupBox.Visible = false;
            Init();
        }
        public List<object> AmenityData { get; set; }
        public Dictionary<string, string> AmenityBeforeSelect { get; set; }
        public void Init()
        {
            AmenityData = new List<object>();
            AmenityBeforeSelect = new Dictionary<string, string>()
            {
                { Amenity1.Name, "" },
                { Amenity2.Name, "" },
                { Amenity3.Name, "" }
            };
            using (Session3Entities entities = new Session3Entities())
            {
                var areaData = entities.Areas.Select(t => new { t.ID, t.Name }).ToList();
                areaData.Insert(0, new { ID = (long)-1, Name = "" });
                AreaComboBox.DisplayMember = "Name";
                AreaComboBox.ValueMember = "ID";
                AreaComboBox.DataSource = areaData;
                AttractionComboBox.DropDownStyle = ComboBoxStyle.DropDown;
                TitleComboBox.DropDownStyle = ComboBoxStyle.DropDown;
                AttractionComboBox.Text = "";
                TitleComboBox.Text = "";
                FromDateTimerPicker.Value = DateTime.Now.Date;
                FromDateTimerPicker.MinDate = DateTime.Now.Date;
                ToDateTimerPicker.Value = DateTime.Now.Date;
                ToDateTimerPicker.MinDate = DateTime.Now.Date;
                nightsNumber.Value = nightsNumber.Minimum;
                PeopleNumber.Value = PeopleNumber.Minimum;
                MinPrice.ResetText();
                MaxPrice.ResetText();
                var itemTypeData = entities.ItemTypes.Select(t => new { t.ID, t.Name }).ToList();
                itemTypeData.Insert(0, new { ID = (long)-1, Name = "" });
                TypeComboBox.DisplayMember = "Name";
                TypeComboBox.ValueMember = "ID";
                TypeComboBox.DataSource = itemTypeData;
                AmenityData = entities.Amenities.Select(t => new { t.ID, t.Name }).ToList().Cast<object>().ToList();
                AmenityData.Insert(0, new { ID = (long)-1, Name = "" });
                Amenity1.DisplayMember = "Name";
                Amenity1.ValueMember = "ID";
                Amenity1.DataSource = AmenityData;
                Amenity2.DisplayMember = "Name";
                Amenity2.ValueMember = "ID";
                Amenity2.DataSource = AmenityData;
                Amenity3.DisplayMember = "Name";
                Amenity3.ValueMember = "ID";
                Amenity3.DataSource = AmenityData;
            }
        }
        private void SimpleSearchBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            this.Init();
        }
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            int options = 4;
            if (FromDateTimerPicker.Value > ToDateTimerPicker.Value)
            {
                MessageBox.Show("From date can't over to date.");
                return;
            }
            if (!String.IsNullOrEmpty(MinPrice.Text)
                && (!String.IsNullOrEmpty(MaxPrice.Text)))
            {
                if (MinPrice.Value > MaxPrice.Value)
                {
                    MessageBox.Show("Starting price can't over Maxinum price.");
                    return;
                }
            }
            List<ComboBox> amenityComboBoxList = new List<ComboBox>()
            {
                Amenity1,
                Amenity2,
                Amenity3
            };
            using (Session3Entities entities = new Session3Entities())
            {
                var items = entities.Items.ToList();
                if (!String.IsNullOrEmpty(AreaComboBox.Text))
                {
                    long areaId = (long)AreaComboBox.SelectedValue;
                    items = items.Where(t => t.AreaID == areaId).ToList();
                    options++;
                }
                if (!String.IsNullOrEmpty(AttractionComboBox.Text))
                {
                    long id = (long)AttractionComboBox.SelectedValue;
                    items = items.Where(t => t.ItemAttractions.Any(x => x.AttractionID == id)).ToList();
                    options++;
                }
                if (!String.IsNullOrEmpty(TitleComboBox.Text))
                {
                    items = items.Where(t => t.Title == TitleComboBox.Text).ToList();
                    options++;
                }
                if (!String.IsNullOrEmpty(TypeComboBox.Text))
                {
                    long id = (long)TypeComboBox.SelectedValue;
                    items = items.Where(t => t.ItemTypeID == id).ToList();
                    options++;
                }
                var amenityIdList = amenityComboBoxList.Where(t => t.Text != "").Select(t => (long)t.SelectedValue).ToList();
                if (amenityIdList.Count() != 0)
                {
                    options += amenityIdList.Count();
                    items = items.Where(t => t.ItemAmenities.Any(x => amenityIdList.Contains(x.ID))).ToList();
                }
                if (!String.IsNullOrEmpty(MinPrice.Text))
                {
                    options++;
                }
                if (!String.IsNullOrEmpty(MaxPrice.Text))
                {
                    options++;
                }
                int nights = (int)nightsNumber.Value;
                int people = (int)PeopleNumber.Value;
                DateTime from = FromDateTimerPicker.Value;
                DateTime to = ToDateTimerPicker.Value;
                items = items.Where(t => t.ItemPrices.Any(x => x.Date >= from && x.Date <= to)
                    && t.Capacity >= people).OrderBy(t => t.Title).ToList();
                ResultDataGridView.Rows.Clear();
                items.ForEach(t =>
                {
                    var score = t.ItemScores.Any() ? Math.Round(t.ItemScores.Average(x => x.Value), 2).ToString() : "";
                    var totalComplate = t.ItemPrices.Any() ?
                        t.ItemPrices.Count(x => x.BookingDetails.Any(y => !y.isRefund)) : 0;
                    foreach (var x in t.ItemPrices.Where(x => x.Date >= from && x.Date <= to).ToList())
                    {
                        DateTime endDate = x.Date.AddDays(nights);
                        var priceData = t.ItemPrices.Where(y => y.Date >= x.Date && y.Date < endDate).ToList();
                        var amount = priceData.Count() != 0
                            ? priceData.Sum(y => y.Price).ToString() + "$" : "Price data not found.";
                        if (!String.IsNullOrEmpty(MinPrice.Text)
                            && priceData.Count() != 0 && MinPrice.Value > priceData.Sum(y => y.Price))
                        {
                            continue;
                        }
                        if (!String.IsNullOrEmpty(MaxPrice.Text)
                            && priceData.Count() != 0 && MaxPrice.Value < priceData.Sum(y => y.Price))
                        {
                            continue;
                        }
                        ResultDataGridView.Rows.Add(t.Title, t.Areas.Name, score, totalComplate, amount, x.Date.ToString("dd/MM/yyyy"));
                    }
                });
                ResultLabel.Text = $"Displaying {items.Count()} options from {options} properties";
                ResultGroupBox.Visible = true;
            }
        }
        private void Amenity1_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (AmenityBeforeSelect[comboBox.Name] == comboBox.Text)
                return;
            List<ComboBox> comboBoxeList = new List<ComboBox>()
            {
                Amenity1,
                Amenity2,
                Amenity3
            };
            comboBoxeList.ForEach(t =>
            {
                if (comboBox != t)
                {
                    t.SelectedValueChanged -= Amenity1_SelectedValueChanged;
                    var data = AmenityData.Where(x => ((dynamic)x).Name == ""
                        || t.Text == ((dynamic)x).Name
                        || (x != comboBox.SelectedItem && comboBoxeList.All(y => y.Text != ((dynamic)x).Name))).ToList();
                    int index = data.IndexOf(t.SelectedItem);
                    t.DataSource = data;
                    t.SelectedIndex = index;
                    t.SelectedValueChanged += Amenity1_SelectedValueChanged;
                }
                else
                    AmenityBeforeSelect[comboBox.Name] = comboBox.Text;
            });
        }
        private void Area_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(AreaComboBox.Text))
            {
                using (Session3Entities entities = new Session3Entities())
                {
                    long areaId = (long)AreaComboBox.SelectedValue;
                    var attractionData = entities.Attractions.Where(t => t.AreaID == areaId).Select(t => new { t.ID, t.Name }).ToList();
                    attractionData.Insert(0, new { ID = (long)-1, Name = "" });
                    AttractionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                    AttractionComboBox.DisplayMember = "Name";
                    AttractionComboBox.ValueMember = "ID";
                    AttractionComboBox.DataSource = attractionData;
                    var items = entities.Items.Where(t => t.AreaID == areaId).Select(t => new { t.ID, t.Title }).ToList();
                    items.Insert(0, new { ID = (long)-1, Title = "" });
                    TitleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                    TitleComboBox.DisplayMember = "Title";
                    TitleComboBox.ValueMember = "ID";
                    TitleComboBox.DataSource = items;
                }
            }
        }
    }
}
