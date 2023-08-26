﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSC1
{
    public partial class ManagerForm : UserControl
    {
        public ManagerForm()
        {
            InitializeComponent();
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            Session1Entities entities = new Session1Entities();
            var asd = entities.Items.Select(x => new
            {
                Title = x.Title,
                Capacity = x.Capacity,
                Area = x.Area.Name,
                Type = x.ItemType.Name
            }).ToList();
            foreach (var x in asd)
                ShowDataGridView.Rows.Add(x.Title, x.Capacity, x.Area, x.Type, "Edit Details");
        }

        private void ShowDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == ShowDataGridView.Columns[4].Index&&e.RowIndex>=0)
            {
                Session1Entities entities=new Session1Entities();
                var sad = ShowDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (ShowDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString()== "Edit Details")
                {
                    Global.selectitemid=entities.Items.Where(x=>x.Title==sad).Select(x=>x.ID).FirstOrDefault();
                    Global.ShowAddAndEditForm();
                }
            }
        }
    }
}