using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSC2
{
    public partial class Main : Form
    {
        public static Main ins;
        public Main()
        {
            InitializeComponent();
            ins = this;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Global.ShowSearchProperties();
        }
    }
}
