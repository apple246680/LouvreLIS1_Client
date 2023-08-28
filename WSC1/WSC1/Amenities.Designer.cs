namespace WSC1
{
    partial class AmenitiesForm
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
            this.ChooseLabel = new System.Windows.Forms.Label();
            this.ShowDataGridView = new System.Windows.Forms.DataGridView();
            this.AmenityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ShowDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ChooseLabel
            // 
            this.ChooseLabel.AutoSize = true;
            this.ChooseLabel.Location = new System.Drawing.Point(75, 21);
            this.ChooseLabel.Name = "ChooseLabel";
            this.ChooseLabel.Size = new System.Drawing.Size(190, 17);
            this.ChooseLabel.TabIndex = 0;
            this.ChooseLabel.Text = "Choose Available Amenities:\r\n";
            // 
            // ShowDataGridView
            // 
            this.ShowDataGridView.AllowUserToAddRows = false;
            this.ShowDataGridView.AllowUserToDeleteRows = false;
            this.ShowDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AmenityColumn,
            this.Column});
            this.ShowDataGridView.Location = new System.Drawing.Point(4, 48);
            this.ShowDataGridView.Name = "ShowDataGridView";
            this.ShowDataGridView.ReadOnly = true;
            this.ShowDataGridView.RowHeadersWidth = 51;
            this.ShowDataGridView.RowTemplate.Height = 27;
            this.ShowDataGridView.Size = new System.Drawing.Size(783, 379);
            this.ShowDataGridView.TabIndex = 1;
            this.ShowDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShowDataGridView_CellClick);
            // 
            // AmenityColumn
            // 
            this.AmenityColumn.HeaderText = "Amenity";
            this.AmenityColumn.MinimumWidth = 6;
            this.AmenityColumn.Name = "AmenityColumn";
            this.AmenityColumn.ReadOnly = true;
            this.AmenityColumn.Width = 125;
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
            // AmenitiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ShowDataGridView);
            this.Controls.Add(this.ChooseLabel);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.Name = "AmenitiesForm";
            this.Size = new System.Drawing.Size(790, 430);
            ((System.ComponentModel.ISupportInitialize)(this.ShowDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ChooseLabel;
        private System.Windows.Forms.DataGridView ShowDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmenityColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column;
    }
}
