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
    public partial class ListingDetaillsForm : UserControl
    {
      public static ListingDetaillsForm ins;
        public ListingDetaillsForm()
        {
            InitializeComponent();
            ins = this;
        }
        Item aa;
        public void run(Item item)
        {
            aa= item;
            TypeComboBox.Text = item.ItemType.Name;
            TitleTextBox.Text = item.Title;
            CapacitynumericUpDown.Value = item.Capacity;
            BednumericUpDown.Value = item.NumberOfBeds;
            BedroomnumericUpDown.Value = item.NumberOfBedrooms;
            BathroomnumericUpDown.Value = item.NumberOfBathrooms;
            ApproximateTextBox.Text = item.ApproximateAddress;
            ExactTextBox.Text = item.ExactAddress;
            DescriptionTextBox.Text = item.Description;
            HostTextBox.Text = item.HostRules;
            MinimumnumericUpDown.Value = item.MinimumNights;
            MaximumnumericUpDown.Value = item.MaximumNights;
        }
        private void ListingDetaillsForm_Load(object sender, EventArgs e)
        {
            TypeComboBox.Items.Clear();
            Session1Entities entities = new Session1Entities();
            TypeComboBox.Items.AddRange(entities.ItemTypes.Select(x => x.Name).ToArray());
        }
        public bool iasdfa()
        {
                if(TypeComboBox.Text == "" || TitleTextBox.Text == ""|| CapacitynumericUpDown.Value == 0 || BednumericUpDown.Value == 0 || BedroomnumericUpDown.Value == 0 || BathroomnumericUpDown.Value == 0 || ApproximateTextBox.Text == "" || ExactTextBox.Text == "" || DescriptionTextBox.Text == "" || HostTextBox.Text == "" || MinimumnumericUpDown.Value == 0 || MaximumnumericUpDown.Value == 0 || MinimumnumericUpDown.Value >= MaximumnumericUpDown.Value)
                return true; 
            else return false;
        }
        public void send()
        {
            Session1Entities entities = new Session1Entities();
            var a = entities.ItemTypes.ToDictionary(x=>x.Name, x=>x.ID);
            if (Global.addoredit=="edit")
            {
               var aaa= entities.Items.Find(aa.ID);
                if (TypeComboBox.Text != "" && TitleTextBox.Text != "" && CapacitynumericUpDown.Value != 0 && BednumericUpDown.Value != 0 && BedroomnumericUpDown.Value != 0 && BathroomnumericUpDown.Value != 0 && ApproximateTextBox.Text != "" && ExactTextBox.Text != "" && DescriptionTextBox.Text != "" && HostTextBox.Text != "" && MinimumnumericUpDown.Value != 0 && MaximumnumericUpDown.Value != 0)
                {
                    aaa.Title = TitleTextBox.Text;
                    aaa.ItemTypeID = a[TypeComboBox.Text];
                    aaa.Capacity = (int)CapacitynumericUpDown.Value;
                    aaa.NumberOfBeds = (int)BednumericUpDown.Value;
                    aaa.NumberOfBathrooms = (int)BathroomnumericUpDown.Value;
                    aaa.NumberOfBedrooms = (int)BedroomnumericUpDown.Value;
                    aaa.ApproximateAddress = ApproximateTextBox.Text;
                    aaa.ExactAddress = ExactTextBox.Text;
                    aaa.Description = DescriptionTextBox.Text;
                    aaa.HostRules = HostTextBox.Text;
                    aaa.MinimumNights=(int)MinimumnumericUpDown.Value;
                    aaa.MaximumNights=(int)MaximumnumericUpDown.Value;
                    entities.SaveChanges();
                }
            }
            else
            {
                Item item = new Item();
                item.GUID = Guid.NewGuid();
                item.UserID = Global.UserId;
                item.ItemTypeID = a[TypeComboBox.Text];
                item.AreaID = new Random().Next(1, 15) ;
                item.Title = TitleTextBox.Text;
                item.Capacity = (int)CapacitynumericUpDown.Value;
                item.NumberOfBeds = (int)BednumericUpDown.Value;
                item.NumberOfBathrooms = (int)BathroomnumericUpDown.Value;
                item.NumberOfBedrooms = (int)BedroomnumericUpDown.Value;
                item.ApproximateAddress = ApproximateTextBox.Text;
                item.ExactAddress = ExactTextBox.Text;
                item.Description = DescriptionTextBox.Text;
                item.HostRules = HostTextBox.Text;
                item.MinimumNights = (int)MinimumnumericUpDown.Value;
                item.MaximumNights = (int)MaximumnumericUpDown.Value;
                entities.Items.Add(item);
                entities.SaveChanges();
                Global.selectitem = entities.Items.FirstOrDefault(x=>x.Title==TitleTextBox.Text);
            }
        }
    }
}
