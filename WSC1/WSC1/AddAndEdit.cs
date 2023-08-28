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
            amenitiesToolStripMenuItem_Click(sender,e);
            listingDetallsToolStripMenuItem_Click(sender,e);
            if (Global.addoredit=="add")
            {
            i++;
            listingDetallsToolStripMenuItem.Enabled = i == 1;
            amenitiesToolStripMenuItem.Enabled = i == 2;
            diistanceToAttractionToolStripMenuItem.Enabled = i == 3;
            }
            NextBtn.Visible = Global.addoredit == "add";
            CloseBtn.Visible = Global.addoredit == "edit";
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            ListingDetaillsForm.ins.send();
            AmenitiesForm.ins.ur();
            Global.ShowManagementForm();
            MessageBox.Show("send ok");
        }
        private void amenitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel.Controls.Clear();
            AmenitiesForm amenities = new AmenitiesForm();
            ShowPanel.Controls.Add(amenities);
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
        int i = 0;
        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (ListingDetaillsForm.ins.iasdfa())
            {
                MessageBox.Show("error");
                return;
            }
            i++;
            if (i == 2) 
            { 
                amenitiesToolStripMenuItem_Click(sender,e);
                ListingDetaillsForm.ins.send();
            }
            if (i == 3) 
            { 
                diistanceToAttractionToolStripMenuItem_Click(sender,e);
                AmenitiesForm.ins.ur();
            }
            if(i==4)
                Global.ShowManagementForm();
            listingDetallsToolStripMenuItem.Enabled = i == 1;
            amenitiesToolStripMenuItem.Enabled = i == 2;
            diistanceToAttractionToolStripMenuItem.Enabled = i == 3;
        }
    }
}
