using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WSC3;

namespace WSC2
{
    public partial class SearchPropertiesOrListingsForm : UserControl
    {
        public SearchPropertiesOrListingsForm()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            Session3Entities entities = new Session3Entities();
            var match = entities.Items.Select(x => new 
            {
                Property=x.Title,
                Area=x.Area,
                AverageScore = x.ItemScores.Where(y=>y.ItemID==x.ID).Average(z=>z.Value),
                Price=x.ItemPrices.Where(y=>y.ItemID==x.ID).Sum(y=>y.Price)
                
            
            }).ToList();
        }
    }
}
