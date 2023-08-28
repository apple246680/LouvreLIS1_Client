using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSC2
{
    public static class Global
    {
        public static void ShowSearchProperties()
        {
            Main.ins.Controls.Clear();
            SearchPropertiesOrListingsForm searchProperties = new SearchPropertiesOrListingsForm();
            Main.ins.Controls.Add(searchProperties);
            searchProperties.Show();
        }
    }
}
