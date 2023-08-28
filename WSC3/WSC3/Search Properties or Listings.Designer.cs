namespace WSC2
{
    partial class SearchPropertiesOrListingsForm
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
            this.SimpleSearchGroupBox = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.PelpleLabel = new System.Windows.Forms.Label();
            this.PeoplenumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NightLabel = new System.Windows.Forms.Label();
            this.NightnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ForLabel = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchResultsGroupBox = new System.Windows.Forms.GroupBox();
            this.ShowDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SimpleSearchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PeoplenumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NightnumericUpDown)).BeginInit();
            this.SearchResultsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SimpleSearchGroupBox
            // 
            this.SimpleSearchGroupBox.Controls.Add(this.button2);
            this.SimpleSearchGroupBox.Controls.Add(this.PelpleLabel);
            this.SimpleSearchGroupBox.Controls.Add(this.PeoplenumericUpDown);
            this.SimpleSearchGroupBox.Controls.Add(this.NightLabel);
            this.SimpleSearchGroupBox.Controls.Add(this.NightnumericUpDown);
            this.SimpleSearchGroupBox.Controls.Add(this.ForLabel);
            this.SimpleSearchGroupBox.Controls.Add(this.SearchBtn);
            this.SimpleSearchGroupBox.Controls.Add(this.DateTimePicker);
            this.SimpleSearchGroupBox.Controls.Add(this.SearchTextBox);
            this.SimpleSearchGroupBox.Location = new System.Drawing.Point(3, 16);
            this.SimpleSearchGroupBox.Name = "SimpleSearchGroupBox";
            this.SimpleSearchGroupBox.Size = new System.Drawing.Size(794, 124);
            this.SimpleSearchGroupBox.TabIndex = 0;
            this.SimpleSearchGroupBox.TabStop = false;
            this.SimpleSearchGroupBox.Text = "Simple search";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(587, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Advanced Search";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // PelpleLabel
            // 
            this.PelpleLabel.AutoSize = true;
            this.PelpleLabel.Location = new System.Drawing.Point(530, 89);
            this.PelpleLabel.Name = "PelpleLabel";
            this.PelpleLabel.Size = new System.Drawing.Size(51, 17);
            this.PelpleLabel.TabIndex = 7;
            this.PelpleLabel.Text = "people";
            // 
            // PeoplenumericUpDown
            // 
            this.PeoplenumericUpDown.Location = new System.Drawing.Point(477, 81);
            this.PeoplenumericUpDown.Name = "PeoplenumericUpDown";
            this.PeoplenumericUpDown.Size = new System.Drawing.Size(47, 25);
            this.PeoplenumericUpDown.TabIndex = 6;
            // 
            // NightLabel
            // 
            this.NightLabel.AutoSize = true;
            this.NightLabel.Location = new System.Drawing.Point(379, 81);
            this.NightLabel.Name = "NightLabel";
            this.NightLabel.Size = new System.Drawing.Size(75, 17);
            this.NightLabel.TabIndex = 5;
            this.NightLabel.Text = "night   and";
            // 
            // NightnumericUpDown
            // 
            this.NightnumericUpDown.Location = new System.Drawing.Point(318, 78);
            this.NightnumericUpDown.Name = "NightnumericUpDown";
            this.NightnumericUpDown.Size = new System.Drawing.Size(45, 25);
            this.NightnumericUpDown.TabIndex = 4;
            // 
            // ForLabel
            // 
            this.ForLabel.AutoSize = true;
            this.ForLabel.Location = new System.Drawing.Point(268, 80);
            this.ForLabel.Name = "ForLabel";
            this.ForLabel.Size = new System.Drawing.Size(25, 17);
            this.ForLabel.TabIndex = 3;
            this.ForLabel.Text = "for";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(577, 27);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(134, 23);
            this.SearchBtn.TabIndex = 2;
            this.SearchBtn.Text = "Search properties";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePicker.Location = new System.Drawing.Point(62, 72);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(200, 25);
            this.DateTimePicker.TabIndex = 1;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(93, 25);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(359, 25);
            this.SearchTextBox.TabIndex = 0;
            // 
            // SearchResultsGroupBox
            // 
            this.SearchResultsGroupBox.Controls.Add(this.ShowDataGridView);
            this.SearchResultsGroupBox.Location = new System.Drawing.Point(4, 147);
            this.SearchResultsGroupBox.Name = "SearchResultsGroupBox";
            this.SearchResultsGroupBox.Size = new System.Drawing.Size(793, 350);
            this.SearchResultsGroupBox.TabIndex = 1;
            this.SearchResultsGroupBox.TabStop = false;
            this.SearchResultsGroupBox.Text = "Search results";
            // 
            // ShowDataGridView
            // 
            this.ShowDataGridView.AllowUserToAddRows = false;
            this.ShowDataGridView.AllowUserToDeleteRows = false;
            this.ShowDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.ShowDataGridView.Location = new System.Drawing.Point(26, 25);
            this.ShowDataGridView.Name = "ShowDataGridView";
            this.ShowDataGridView.ReadOnly = true;
            this.ShowDataGridView.RowHeadersWidth = 51;
            this.ShowDataGridView.RowTemplate.Height = 27;
            this.ShowDataGridView.Size = new System.Drawing.Size(761, 299);
            this.ShowDataGridView.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Property";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Area";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Average Score";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total completed reservations";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Amount payable";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // SearchPropertiesOrListingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SearchResultsGroupBox);
            this.Controls.Add(this.SimpleSearchGroupBox);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.Name = "SearchPropertiesOrListingsForm";
            this.Size = new System.Drawing.Size(800, 500);
            this.SimpleSearchGroupBox.ResumeLayout(false);
            this.SimpleSearchGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PeoplenumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NightnumericUpDown)).EndInit();
            this.SearchResultsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ShowDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SimpleSearchGroupBox;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label PelpleLabel;
        private System.Windows.Forms.NumericUpDown PeoplenumericUpDown;
        private System.Windows.Forms.Label NightLabel;
        private System.Windows.Forms.NumericUpDown NightnumericUpDown;
        private System.Windows.Forms.Label ForLabel;
        private System.Windows.Forms.GroupBox SearchResultsGroupBox;
        private System.Windows.Forms.DataGridView ShowDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
