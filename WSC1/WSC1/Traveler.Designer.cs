namespace WSC1
{
    partial class TravelerForm
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
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.ShowDataGridView = new System.Windows.Forms.DataGridView();
            this.ItemCountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ShowDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(28, 14);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(384, 25);
            this.SearchTextBox.TabIndex = 0;
            this.SearchTextBox.Text = "Search destination or Listing Title or Attraction";
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            this.SearchTextBox.Enter += new System.EventHandler(this.SearchTextBox_Enter);
            this.SearchTextBox.Leave += new System.EventHandler(this.SearchTextBox_Leave);
            // 
            // ShowDataGridView
            // 
            this.ShowDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowDataGridView.Location = new System.Drawing.Point(28, 46);
            this.ShowDataGridView.Name = "ShowDataGridView";
            this.ShowDataGridView.RowHeadersWidth = 51;
            this.ShowDataGridView.RowTemplate.Height = 27;
            this.ShowDataGridView.Size = new System.Drawing.Size(719, 234);
            this.ShowDataGridView.TabIndex = 1;
            // 
            // ItemCountLabel
            // 
            this.ItemCountLabel.AutoSize = true;
            this.ItemCountLabel.Location = new System.Drawing.Point(57, 283);
            this.ItemCountLabel.Name = "ItemCountLabel";
            this.ItemCountLabel.Size = new System.Drawing.Size(88, 17);
            this.ItemCountLabel.TabIndex = 2;
            this.ItemCountLabel.Text = "items found.";
            // 
            // TravelerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ItemCountLabel);
            this.Controls.Add(this.ShowDataGridView);
            this.Controls.Add(this.SearchTextBox);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.Name = "TravelerForm";
            this.Size = new System.Drawing.Size(750, 300);
            this.Load += new System.EventHandler(this.TravelerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ShowDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.DataGridView ShowDataGridView;
        private System.Windows.Forms.Label ItemCountLabel;
    }
}
