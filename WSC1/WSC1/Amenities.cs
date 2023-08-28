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
       public static AmenitiesForm ins;
        public AmenitiesForm()
        {
            InitializeComponent();
            ins = this;
        }
        public void run()
        {
            Session1Entities entities = new Session1Entities();
            if(Global.addoredit=="edit")
            foreach (var entity in entities.Amenities.Select(x => x.Name))
                ShowDataGridView.Rows.Add(entity,Global.selectitem.ItemAmenities.Any(x=>x.Amenity.Name==entity));
            else
                foreach (var entity in entities.Amenities.Select(x => x.Name))
                    ShowDataGridView.Rows.Add(entity, false);
        }
        Dictionary<string, int> apple = new Dictionary<string, int>();
        private void ShowDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                ShowDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value =
                    !(bool)ShowDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            }
        }
        public void ur()
        {
            Session1Entities entities=new Session1Entities();
            entities.ItemAmenities.RemoveRange(entities.ItemAmenities.Where(x=>x.ItemID==Global.selectitem.ID));
            var asd = entities.Amenities.Select(x=>x.ID).ToList();
            for (int i = 0; i < ShowDataGridView.RowCount; i++)
            {
                if ((bool)ShowDataGridView.Rows[i].Cells[1].Value)
                {
                    ItemAmenity item=new ItemAmenity();
                    item.GUID=Guid.NewGuid();
                    item.ItemID=Global.selectitem.ID;
                    item.AmenityID = asd[i];
                    entities.ItemAmenities.Add(item);
                }
            }
            entities.SaveChanges();
        }
    }
}