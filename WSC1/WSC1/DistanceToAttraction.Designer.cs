namespace WSC1
{
    partial class DistanceToAttractionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.ShowDataGridView = new System.Windows.Forms.DataGridView();
            this.AttractionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AreaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistanceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FootTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ShowDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(557, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Specify the distance from each close by attaction and the time it takes to get to" +
    " them:";
            // 
            // ShowDataGridView
            // 
            this.ShowDataGridView.AllowUserToAddRows = false;
            this.ShowDataGridView.AllowUserToDeleteRows = false;
            this.ShowDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AttractionColumn,
            this.AreaColumn,
            this.DistanceColumn,
            this.FootTimeColumn,
            this.CarTimeColumn});
            this.ShowDataGridView.Location = new System.Drawing.Point(13, 36);
            this.ShowDataGridView.Name = "ShowDataGridView";
            this.ShowDataGridView.ReadOnly = true;
            this.ShowDataGridView.RowHeadersWidth = 51;
            this.ShowDataGridView.RowTemplate.Height = 27;
            this.ShowDataGridView.Size = new System.Drawing.Size(761, 369);
            this.ShowDataGridView.TabIndex = 1;
            // 
            // AttractionColumn
            // 
            this.AttractionColumn.HeaderText = "Attaction";
            this.AttractionColumn.MinimumWidth = 6;
            this.AttractionColumn.Name = "AttractionColumn";
            this.AttractionColumn.ReadOnly = true;
            this.AttractionColumn.Width = 125;
            // 
            // AreaColumn
            // 
            this.AreaColumn.HeaderText = "Area";
            this.AreaColumn.MinimumWidth = 6;
            this.AreaColumn.Name = "AreaColumn";
            this.AreaColumn.ReadOnly = true;
            this.AreaColumn.Width = 125;
            // 
            // DistanceColumn
            // 
            this.DistanceColumn.HeaderText = "Dostance";
            this.DistanceColumn.MinimumWidth = 6;
            this.DistanceColumn.Name = "DistanceColumn";
            this.DistanceColumn.ReadOnly = true;
            this.DistanceColumn.Width = 125;
            // 
            // FootTimeColumn
            // 
            this.FootTimeColumn.HeaderText = "On Foot(minutes)";
            this.FootTimeColumn.MinimumWidth = 6;
            this.FootTimeColumn.Name = "FootTimeColumn";
            this.FootTimeColumn.ReadOnly = true;
            this.FootTimeColumn.Width = 125;
            // 
            // CarTimeColumn
            // 
            this.CarTimeColumn.HeaderText = "By Car(minutes)";
            this.CarTimeColumn.MinimumWidth = 6;
            this.CarTimeColumn.Name = "CarTimeColumn";
            this.CarTimeColumn.ReadOnly = true;
            this.CarTimeColumn.Width = 125;
            // 
            // DistanceToAttractionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ShowDataGridView);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.Name = "DistanceToAttractionForm";
            this.Size = new System.Drawing.Size(790, 430);
            ((System.ComponentModel.ISupportInitialize)(this.ShowDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ShowDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttractionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AreaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistanceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FootTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarTimeColumn;
    }
}
