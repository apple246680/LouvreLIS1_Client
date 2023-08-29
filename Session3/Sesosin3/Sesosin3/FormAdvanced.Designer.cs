namespace Sesosin3
{
    partial class FormAdvanced
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
            this.ResultGroupBox = new System.Windows.Forms.GroupBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ResultDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TopGroupBox = new System.Windows.Forms.GroupBox();
            this.SimpleSearchBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.Amenity3 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Amenity2 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Amenity1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.MaxPrice = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.MinPrice = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PeopleNumber = new System.Windows.Forms.NumericUpDown();
            this.nightsNumber = new System.Windows.Forms.NumericUpDown();
            this.ToDateTimerPicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.FromDateTimerPicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.TitleComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AttractionComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AreaComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultDataGridView)).BeginInit();
            this.TopGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeopleNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nightsNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultGroupBox
            // 
            this.ResultGroupBox.Controls.Add(this.ResultLabel);
            this.ResultGroupBox.Controls.Add(this.ResultDataGridView);
            this.ResultGroupBox.Location = new System.Drawing.Point(44, 325);
            this.ResultGroupBox.Name = "ResultGroupBox";
            this.ResultGroupBox.Size = new System.Drawing.Size(1222, 373);
            this.ResultGroupBox.TabIndex = 2;
            this.ResultGroupBox.TabStop = false;
            this.ResultGroupBox.Text = "Search results";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(55, 343);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(0, 22);
            this.ResultLabel.TabIndex = 11;
            // 
            // ResultDataGridView
            // 
            this.ResultDataGridView.AllowUserToAddRows = false;
            this.ResultDataGridView.AllowUserToDeleteRows = false;
            this.ResultDataGridView.AllowUserToResizeColumns = false;
            this.ResultDataGridView.AllowUserToResizeRows = false;
            this.ResultDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.ResultDataGridView.Location = new System.Drawing.Point(51, 46);
            this.ResultDataGridView.Name = "ResultDataGridView";
            this.ResultDataGridView.ReadOnly = true;
            this.ResultDataGridView.RowHeadersVisible = false;
            this.ResultDataGridView.RowHeadersWidth = 51;
            this.ResultDataGridView.RowTemplate.Height = 27;
            this.ResultDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ResultDataGridView.Size = new System.Drawing.Size(1139, 289);
            this.ResultDataGridView.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Property";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 107;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Area";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 77;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Average Score";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 145;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total completed reservations";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 245;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Amount payable";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 154;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Check-in at";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 119;
            // 
            // TopGroupBox
            // 
            this.TopGroupBox.Controls.Add(this.SimpleSearchBtn);
            this.TopGroupBox.Controls.Add(this.ClearBtn);
            this.TopGroupBox.Controls.Add(this.SearchBtn);
            this.TopGroupBox.Controls.Add(this.Amenity3);
            this.TopGroupBox.Controls.Add(this.label14);
            this.TopGroupBox.Controls.Add(this.Amenity2);
            this.TopGroupBox.Controls.Add(this.label13);
            this.TopGroupBox.Controls.Add(this.Amenity1);
            this.TopGroupBox.Controls.Add(this.label12);
            this.TopGroupBox.Controls.Add(this.TypeComboBox);
            this.TopGroupBox.Controls.Add(this.label11);
            this.TopGroupBox.Controls.Add(this.MaxPrice);
            this.TopGroupBox.Controls.Add(this.label10);
            this.TopGroupBox.Controls.Add(this.MinPrice);
            this.TopGroupBox.Controls.Add(this.label9);
            this.TopGroupBox.Controls.Add(this.label6);
            this.TopGroupBox.Controls.Add(this.label7);
            this.TopGroupBox.Controls.Add(this.label8);
            this.TopGroupBox.Controls.Add(this.PeopleNumber);
            this.TopGroupBox.Controls.Add(this.nightsNumber);
            this.TopGroupBox.Controls.Add(this.ToDateTimerPicker);
            this.TopGroupBox.Controls.Add(this.label5);
            this.TopGroupBox.Controls.Add(this.FromDateTimerPicker);
            this.TopGroupBox.Controls.Add(this.label4);
            this.TopGroupBox.Controls.Add(this.TitleComboBox);
            this.TopGroupBox.Controls.Add(this.label3);
            this.TopGroupBox.Controls.Add(this.AttractionComboBox);
            this.TopGroupBox.Controls.Add(this.label2);
            this.TopGroupBox.Controls.Add(this.AreaComboBox);
            this.TopGroupBox.Controls.Add(this.label1);
            this.TopGroupBox.Location = new System.Drawing.Point(44, 12);
            this.TopGroupBox.Name = "TopGroupBox";
            this.TopGroupBox.Size = new System.Drawing.Size(1243, 307);
            this.TopGroupBox.TabIndex = 3;
            this.TopGroupBox.TabStop = false;
            this.TopGroupBox.Text = "Advanced Search";
            // 
            // SimpleSearchBtn
            // 
            this.SimpleSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpleSearchBtn.Location = new System.Drawing.Point(330, 251);
            this.SimpleSearchBtn.Name = "SimpleSearchBtn";
            this.SimpleSearchBtn.Size = new System.Drawing.Size(280, 39);
            this.SimpleSearchBtn.TabIndex = 25;
            this.SimpleSearchBtn.Text = "Simple Search";
            this.SimpleSearchBtn.UseVisualStyleBackColor = true;
            this.SimpleSearchBtn.Click += new System.EventHandler(this.SimpleSearchBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.Location = new System.Drawing.Point(632, 250);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(280, 39);
            this.ClearBtn.TabIndex = 25;
            this.ClearBtn.Text = "Clear form";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.Location = new System.Drawing.Point(942, 249);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(280, 39);
            this.SearchBtn.TabIndex = 25;
            this.SearchBtn.Text = "Search properties...";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // Amenity3
            // 
            this.Amenity3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Amenity3.FormattingEnabled = true;
            this.Amenity3.Location = new System.Drawing.Point(922, 209);
            this.Amenity3.Name = "Amenity3";
            this.Amenity3.Size = new System.Drawing.Size(300, 30);
            this.Amenity3.TabIndex = 24;
            this.Amenity3.SelectedValueChanged += new System.EventHandler(this.Amenity1_SelectedValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(830, 216);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 22);
            this.label14.TabIndex = 23;
            this.label14.Text = "Amenity:";
            // 
            // Amenity2
            // 
            this.Amenity2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Amenity2.FormattingEnabled = true;
            this.Amenity2.Location = new System.Drawing.Point(511, 210);
            this.Amenity2.Name = "Amenity2";
            this.Amenity2.Size = new System.Drawing.Size(300, 30);
            this.Amenity2.TabIndex = 22;
            this.Amenity2.SelectedValueChanged += new System.EventHandler(this.Amenity1_SelectedValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(419, 217);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 22);
            this.label13.TabIndex = 21;
            this.label13.Text = "Amenity:";
            // 
            // Amenity1
            // 
            this.Amenity1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Amenity1.FormattingEnabled = true;
            this.Amenity1.Location = new System.Drawing.Point(103, 211);
            this.Amenity1.Name = "Amenity1";
            this.Amenity1.Size = new System.Drawing.Size(300, 30);
            this.Amenity1.TabIndex = 20;
            this.Amenity1.SelectedValueChanged += new System.EventHandler(this.Amenity1_SelectedValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 22);
            this.label12.TabIndex = 19;
            this.label12.Text = "Amenity:";
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Location = new System.Drawing.Point(853, 157);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(300, 30);
            this.TypeComboBox.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(724, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 22);
            this.label11.TabIndex = 17;
            this.label11.Text = "Property type";
            // 
            // MaxPrice
            // 
            this.MaxPrice.DecimalPlaces = 2;
            this.MaxPrice.Location = new System.Drawing.Point(530, 154);
            this.MaxPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.MaxPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaxPrice.Name = "MaxPrice";
            this.MaxPrice.Size = new System.Drawing.Size(136, 28);
            this.MaxPrice.TabIndex = 16;
            this.MaxPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(385, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 22);
            this.label10.TabIndex = 15;
            this.label10.Text = "Maximun price:";
            // 
            // MinPrice
            // 
            this.MinPrice.DecimalPlaces = 2;
            this.MinPrice.Location = new System.Drawing.Point(159, 158);
            this.MinPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.MinPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MinPrice.Name = "MinPrice";
            this.MinPrice.Size = new System.Drawing.Size(142, 28);
            this.MinPrice.TabIndex = 14;
            this.MinPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 22);
            this.label9.TabIndex = 13;
            this.label9.Text = "Starting price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1106, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "people";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(894, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "nights and";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(744, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 22);
            this.label8.TabIndex = 12;
            this.label8.Text = "for";
            // 
            // PeopleNumber
            // 
            this.PeopleNumber.Location = new System.Drawing.Point(998, 101);
            this.PeopleNumber.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.PeopleNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PeopleNumber.Name = "PeopleNumber";
            this.PeopleNumber.Size = new System.Drawing.Size(92, 28);
            this.PeopleNumber.TabIndex = 8;
            this.PeopleNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nightsNumber
            // 
            this.nightsNumber.Location = new System.Drawing.Point(796, 101);
            this.nightsNumber.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nightsNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nightsNumber.Name = "nightsNumber";
            this.nightsNumber.Size = new System.Drawing.Size(92, 28);
            this.nightsNumber.TabIndex = 9;
            this.nightsNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ToDateTimerPicker
            // 
            this.ToDateTimerPicker.CustomFormat = "dd/MM/yyyy";
            this.ToDateTimerPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ToDateTimerPicker.Location = new System.Drawing.Point(462, 103);
            this.ToDateTimerPicker.Name = "ToDateTimerPicker";
            this.ToDateTimerPicker.Size = new System.Drawing.Size(259, 28);
            this.ToDateTimerPicker.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(395, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "To:";
            // 
            // FromDateTimerPicker
            // 
            this.FromDateTimerPicker.CustomFormat = "dd/MM/yyyy";
            this.FromDateTimerPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FromDateTimerPicker.Location = new System.Drawing.Point(103, 102);
            this.FromDateTimerPicker.Name = "FromDateTimerPicker";
            this.FromDateTimerPicker.Size = new System.Drawing.Size(259, 28);
            this.FromDateTimerPicker.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "From:";
            // 
            // TitleComboBox
            // 
            this.TitleComboBox.FormattingEnabled = true;
            this.TitleComboBox.Location = new System.Drawing.Point(938, 39);
            this.TitleComboBox.Name = "TitleComboBox";
            this.TitleComboBox.Size = new System.Drawing.Size(300, 30);
            this.TitleComboBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(806, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Property Title";
            // 
            // AttractionComboBox
            // 
            this.AttractionComboBox.FormattingEnabled = true;
            this.AttractionComboBox.Location = new System.Drawing.Point(500, 39);
            this.AttractionComboBox.Name = "AttractionComboBox";
            this.AttractionComboBox.Size = new System.Drawing.Size(300, 30);
            this.AttractionComboBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Attraction:";
            // 
            // AreaComboBox
            // 
            this.AreaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AreaComboBox.FormattingEnabled = true;
            this.AreaComboBox.Location = new System.Drawing.Point(91, 36);
            this.AreaComboBox.Name = "AreaComboBox";
            this.AreaComboBox.Size = new System.Drawing.Size(300, 30);
            this.AreaComboBox.TabIndex = 1;
            this.AreaComboBox.SelectedIndexChanged += new System.EventHandler(this.Area_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Area:";
            // 
            // FormAdvanced
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1313, 710);
            this.Controls.Add(this.TopGroupBox);
            this.Controls.Add(this.ResultGroupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormAdvanced";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seoul Stay - Search Properties or Listings (Advanced) ";
            this.ResultGroupBox.ResumeLayout(false);
            this.ResultGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultDataGridView)).EndInit();
            this.TopGroupBox.ResumeLayout(false);
            this.TopGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeopleNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nightsNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ResultGroupBox;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.DataGridView ResultDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.GroupBox TopGroupBox;
        private System.Windows.Forms.DateTimePicker ToDateTimerPicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker FromDateTimerPicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox TitleComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox AttractionComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox AreaComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Amenity1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown MaxPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown MinPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown PeopleNumber;
        private System.Windows.Forms.NumericUpDown nightsNumber;
        private System.Windows.Forms.ComboBox Amenity3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox Amenity2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button SimpleSearchBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button SearchBtn;
    }
}