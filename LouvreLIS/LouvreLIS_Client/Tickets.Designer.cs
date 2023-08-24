namespace LouvreLIS_Client
{
    partial class TicketsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TicketDataGridView = new System.Windows.Forms.DataGridView();
            this.VisitDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisitTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TicketNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.View = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TicketDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TicketDataGridView
            // 
            this.TicketDataGridView.AllowUserToAddRows = false;
            this.TicketDataGridView.AllowUserToDeleteRows = false;
            this.TicketDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TicketDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VisitDate,
            this.VisitTime,
            this.TicketNumber,
            this.PurchaseDate,
            this.Status,
            this.View});
            this.TicketDataGridView.Location = new System.Drawing.Point(3, 1);
            this.TicketDataGridView.Name = "TicketDataGridView";
            this.TicketDataGridView.ReadOnly = true;
            this.TicketDataGridView.RowHeadersWidth = 51;
            this.TicketDataGridView.RowTemplate.Height = 27;
            this.TicketDataGridView.Size = new System.Drawing.Size(775, 387);
            this.TicketDataGridView.TabIndex = 0;
            this.TicketDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TicketDataGridView_CellClick);
            // 
            // VisitDate
            // 
            this.VisitDate.HeaderText = "Visit Date";
            this.VisitDate.MinimumWidth = 6;
            this.VisitDate.Name = "VisitDate";
            this.VisitDate.ReadOnly = true;
            this.VisitDate.Width = 125;
            // 
            // VisitTime
            // 
            this.VisitTime.HeaderText = "Visit Time";
            this.VisitTime.MinimumWidth = 6;
            this.VisitTime.Name = "VisitTime";
            this.VisitTime.ReadOnly = true;
            this.VisitTime.Width = 125;
            // 
            // TicketNumber
            // 
            this.TicketNumber.HeaderText = "Ticket Number";
            this.TicketNumber.MinimumWidth = 6;
            this.TicketNumber.Name = "TicketNumber";
            this.TicketNumber.ReadOnly = true;
            this.TicketNumber.Width = 125;
            // 
            // PurchaseDate
            // 
            this.PurchaseDate.HeaderText = "Purchase Date";
            this.PurchaseDate.MinimumWidth = 6;
            this.PurchaseDate.Name = "PurchaseDate";
            this.PurchaseDate.ReadOnly = true;
            this.PurchaseDate.Width = 125;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 125;
            // 
            // View
            // 
            this.View.HeaderText = "View";
            this.View.MinimumWidth = 6;
            this.View.Name = "View";
            this.View.ReadOnly = true;
            this.View.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.View.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.View.Width = 125;
            // 
            // TicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.TicketDataGridView);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TicketsForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TicketDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TicketDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisitDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisitTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewButtonColumn View;
    }
}