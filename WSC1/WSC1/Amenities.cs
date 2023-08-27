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
    public partial class AmenitiesForm : UserControl
    {
        public AmenitiesForm()
        {
            InitializeComponent();
        }
        public void run()
        {
            Session1Entities entities = new Session1Entities();
            foreach (var entity in entities.Amenities.Select(x => x.Name))
                dataGridView1.Rows.Add(entity,Global.selectitem.ItemAmenities.Any(x=>x.Amenity.Name==entity));
        }
    }
}
