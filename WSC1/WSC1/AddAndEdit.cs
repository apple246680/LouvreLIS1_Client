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
    public partial class AddAndEditForm : UserControl
    {
        public AddAndEditForm()
        {
            InitializeComponent();
        }
        private void listingDetallsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel.Controls.Clear();
            ListingDetaillsForm listingDetaillsForm = new ListingDetaillsForm();
            ShowPanel.Controls.Add(listingDetaillsForm);
            if (Global.addoredit=="edit")
                listingDetaillsForm.run(Global.selectitem);
            listingDetaillsForm.Show();
        }
        private void AddAndEditForm_Load(object sender, EventArgs e)
        {
            listingDetallsToolStripMenuItem_Click(null,null);
            NextBtn.Visible = Global.addoredit == "add";
            CloseBtn.Visible = Global.addoredit == "edit";
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            ListingDetaillsForm.ins.send();
        }
        private void amenitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel.Controls.Clear();
            AmenitiesForm amenities = new AmenitiesForm();
            ShowPanel.Controls.Add(amenities);
            if (Global.addoredit == "edit")
                amenities.run();
            amenities.Show();
        }

        private void diistanceToAttractionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel.Controls.Clear();
            DistanceToAttractionForm distance = new DistanceToAttractionForm();
            ShowPanel.Controls.Add(distance);
            if (Global.addoredit == "edit")
                distance.run();
            distance.Show();
        }
    }
}
