using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LouvreLIS_Client
{
    public partial class TicketsForm : Form
    {
        public TicketsForm()
        {
            InitializeComponent();
        }
        public void getdata(Account asd)
        {
            TicketDataGridView.Rows.Clear();
            foreach (var item in asd.Visitor.TicketDatas)
                TicketDataGridView.Rows.Add(item.VisitDateTime.ToString("MM/dd/yyyy"), item.VisitDateTime.ToString("HH:mm"),item.TicketStatus.ToString()=="0"? "N/A" : item.TicketNumber, item.TicketStatus.ToString() == "0" ? "N/A" : item.PurchaseDate.Value.ToString("MM/dd/yyyy HH:mm"), item.TicketStatus.ToString() == "0" ? "Unpaid": item.TicketStatus.ToString() == "1" ? "Normal" : "Suspended", item.TicketStatus.ToString() == "0" ? "N/A" : "🍳");   
        }
    }
}
