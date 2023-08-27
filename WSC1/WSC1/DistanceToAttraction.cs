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
    public partial class DistanceToAttractionForm : UserControl
    {
        public DistanceToAttractionForm()
        {
            InitializeComponent();
        }
        public void run()
        {
            Session1Entities entities = new Session1Entities();
            foreach (var entity in entities.ItemAttractions.Where(x=>x.ItemID==Global.selectitem.ID))
            {
               ShowDataGridView.Rows.Add(entity.Attraction.Name,entity.Attraction.Area.Name,entity.Distance,entity.DurationOnFoot,entity.DurationByCar);
            }
        }
    }
}
