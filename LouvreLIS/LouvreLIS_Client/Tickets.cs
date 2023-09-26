using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
namespace LouvreLIS_Client
{
    public partial class TicketsForm : Form
    {
        public TicketsForm()
        {
            InitializeComponent();
        }
        public void GetData(Account asd)
        {
            TicketDataGridView.Rows.Clear();
            foreach (var item in asd.Visitor.TicketDatas)
                TicketDataGridView.Rows.Add(item.VisitDateTime.ToString("MM/dd/yyyy"),
                    item.VisitDateTime.ToString("HH:mm"), item.TicketStatus.ToString() == "0" ? "N/A" : item.TicketNumber, 
                    item.TicketStatus.ToString() == "0" ? "N/A" : item.PurchaseDate.Value.ToString("MM/dd/yyyy HH:mm"),
                    item.TicketStatus.ToString() == "0" ? "Unpaid" : item.TicketStatus.ToString() == "1" ? "Normal" : "Suspended",
                    item.TicketStatus.ToString() == "0" ? "N/A" : "🍳");
        }
        private void TicketDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PreviewTicketForm previewticketForm = new PreviewTicketForm();
            if (e.ColumnIndex == TicketDataGridView.Columns[5].Index && e.RowIndex >= 0)
            {
                if (TicketDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString() == "🍳")
                {
                    string textInRow = TicketDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                    previewticketForm.GetDataAndRun(textInRow);
                    previewticketForm.Show();
                }
            }
        }
    }
}
