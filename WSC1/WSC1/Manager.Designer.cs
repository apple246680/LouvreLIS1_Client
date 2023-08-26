namespace WSC1
{
    partial class ManagerForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddBtn = new System.Windows.Forms.Button();
            this.ShowDataGridView = new System.Windows.Forms.DataGridView();
            this.TitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CapacityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AreaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ShowDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(3, 3);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(111, 31);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Add Listing";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ShowDataGridView
            // 
            this.ShowDataGridView.AllowUserToAddRows = false;
            this.ShowDataGridView.AllowUserToDeleteRows = false;
            this.ShowDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TitleColumn,
            this.CapacityColumn,
            this.AreaColumn,
            this.TypeColumn,
            this.Column});
            this.ShowDataGridView.Location = new System.Drawing.Point(4, 41);
            this.ShowDataGridView.Name = "ShowDataGridView";
            this.ShowDataGridView.ReadOnly = true;
            this.ShowDataGridView.RowHeadersWidth = 51;
            this.ShowDataGridView.RowTemplate.Height = 27;
            this.ShowDataGridView.Size = new System.Drawing.Size(743, 256);
            this.ShowDataGridView.TabIndex = 1;
            this.ShowDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShowDataGridView_CellClick);
            // 
            // TitleColumn
            // 
            this.TitleColumn.HeaderText = "Title";
            this.TitleColumn.MinimumWidth = 6;
            this.TitleColumn.Name = "TitleColumn";
            this.TitleColumn.ReadOnly = true;
            this.TitleColumn.Width = 125;
            // 
            // CapacityColumn
            // 
            this.CapacityColumn.HeaderText = "Capacity";
            this.CapacityColumn.MinimumWidth = 6;
            this.CapacityColumn.Name = "CapacityColumn";
            this.CapacityColumn.ReadOnly = true;
            this.CapacityColumn.Width = 125;
            // 
            // AreaColumn
            // 
            this.AreaColumn.HeaderText = "Area";
            this.AreaColumn.MinimumWidth = 6;
            this.AreaColumn.Name = "AreaColumn";
            this.AreaColumn.ReadOnly = true;
            this.AreaColumn.Width = 125;
            // 
            // TypeColumn
            // 
            this.TypeColumn.HeaderText = "Type";
            this.TypeColumn.MinimumWidth = 6;
            this.TypeColumn.Name = "TypeColumn";
            this.TypeColumn.ReadOnly = true;
            this.TypeColumn.Width = 125;
            // 
            // Column
            // 
            this.Column.HeaderText = "";
            this.Column.MinimumWidth = 6;
            this.Column.Name = "Column";
            this.Column.ReadOnly = true;
            this.Column.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column.Width = 125;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ShowDataGridView);
            this.Controls.Add(this.AddBtn);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.Name = "ManagerForm";
            this.Size = new System.Drawing.Size(750, 300);
            ((System.ComponentModel.ISupportInitialize)(this.ShowDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.DataGridView ShowDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapacityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AreaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeColumn;
        private System.Windows.Forms.DataGridViewLinkColumn Column;
    }
}
