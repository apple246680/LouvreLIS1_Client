namespace LouvreLIS_Management
{
    partial class VisitorAccountManagementForm
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
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.FullNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreferredLanguageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperationColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.PreferredLanguageLabel = new System.Windows.Forms.Label();
            this.UsernameTextbox = new System.Windows.Forms.TextBox();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.GenderComobox = new System.Windows.Forms.ComboBox();
            this.EmailTextbox = new System.Windows.Forms.TextBox();
            this.StatusCombobox = new System.Windows.Forms.ComboBox();
            this.PreferredLanguageCombobox = new System.Windows.Forms.ComboBox();
            this.FilterBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullNameColumn,
            this.GenderColumn,
            this.MailColumn,
            this.StatusColumn,
            this.PreferredLanguageColumn,
            this.OperationColumn});
            this.DataGridView.Location = new System.Drawing.Point(12, 86);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.RowTemplate.Height = 27;
            this.DataGridView.Size = new System.Drawing.Size(776, 311);
            this.DataGridView.TabIndex = 0;
            this.DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellClick);
            // 
            // FullNameColumn
            // 
            this.FullNameColumn.HeaderText = "Full Name";
            this.FullNameColumn.MinimumWidth = 6;
            this.FullNameColumn.Name = "FullNameColumn";
            this.FullNameColumn.ReadOnly = true;
            this.FullNameColumn.Width = 125;
            // 
            // GenderColumn
            // 
            this.GenderColumn.HeaderText = "Gender";
            this.GenderColumn.MinimumWidth = 6;
            this.GenderColumn.Name = "GenderColumn";
            this.GenderColumn.ReadOnly = true;
            this.GenderColumn.Width = 125;
            // 
            // MailColumn
            // 
            this.MailColumn.HeaderText = "Mail";
            this.MailColumn.MinimumWidth = 6;
            this.MailColumn.Name = "MailColumn";
            this.MailColumn.ReadOnly = true;
            this.MailColumn.Width = 125;
            // 
            // StatusColumn
            // 
            this.StatusColumn.HeaderText = "Status";
            this.StatusColumn.MinimumWidth = 6;
            this.StatusColumn.Name = "StatusColumn";
            this.StatusColumn.ReadOnly = true;
            this.StatusColumn.Width = 125;
            // 
            // PreferredLanguageColumn
            // 
            this.PreferredLanguageColumn.HeaderText = "Preferred language";
            this.PreferredLanguageColumn.MinimumWidth = 6;
            this.PreferredLanguageColumn.Name = "PreferredLanguageColumn";
            this.PreferredLanguageColumn.ReadOnly = true;
            this.PreferredLanguageColumn.Width = 125;
            // 
            // OperationColumn
            // 
            this.OperationColumn.HeaderText = "Operation";
            this.OperationColumn.MinimumWidth = 6;
            this.OperationColumn.Name = "OperationColumn";
            this.OperationColumn.ReadOnly = true;
            this.OperationColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.OperationColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.OperationColumn.Width = 125;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(8, 8);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(80, 17);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "Username:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(131, 8);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(51, 17);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name:";
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Location = new System.Drawing.Point(257, 8);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(60, 17);
            this.GenderLabel.TabIndex = 3;
            this.GenderLabel.Text = "Gender:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(363, 8);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(106, 17);
            this.EmailLabel.TabIndex = 4;
            this.EmailLabel.Text = "Email Address:";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(492, 9);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(54, 17);
            this.StatusLabel.TabIndex = 5;
            this.StatusLabel.Text = "Status:";
            // 
            // PreferredLanguageLabel
            // 
            this.PreferredLanguageLabel.AutoSize = true;
            this.PreferredLanguageLabel.Location = new System.Drawing.Point(647, 8);
            this.PreferredLanguageLabel.Name = "PreferredLanguageLabel";
            this.PreferredLanguageLabel.Size = new System.Drawing.Size(141, 17);
            this.PreferredLanguageLabel.TabIndex = 6;
            this.PreferredLanguageLabel.Text = "Preferred Language:";
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.Location = new System.Drawing.Point(11, 29);
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.Size = new System.Drawing.Size(119, 25);
            this.UsernameTextbox.TabIndex = 7;
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(134, 29);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(119, 25);
            this.NameTextbox.TabIndex = 8;
            // 
            // GenderComobox
            // 
            this.GenderComobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderComobox.FormattingEnabled = true;
            this.GenderComobox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderComobox.Location = new System.Drawing.Point(260, 29);
            this.GenderComobox.Name = "GenderComobox";
            this.GenderComobox.Size = new System.Drawing.Size(100, 25);
            this.GenderComobox.TabIndex = 9;
            // 
            // EmailTextbox
            // 
            this.EmailTextbox.Location = new System.Drawing.Point(366, 29);
            this.EmailTextbox.Name = "EmailTextbox";
            this.EmailTextbox.Size = new System.Drawing.Size(119, 25);
            this.EmailTextbox.TabIndex = 10;
            // 
            // StatusCombobox
            // 
            this.StatusCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusCombobox.FormattingEnabled = true;
            this.StatusCombobox.Items.AddRange(new object[] {
            "Pending",
            "Normal",
            "Disabled"});
            this.StatusCombobox.Location = new System.Drawing.Point(495, 30);
            this.StatusCombobox.Name = "StatusCombobox";
            this.StatusCombobox.Size = new System.Drawing.Size(127, 25);
            this.StatusCombobox.TabIndex = 11;
            // 
            // PreferredLanguageCombobox
            // 
            this.PreferredLanguageCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PreferredLanguageCombobox.FormattingEnabled = true;
            this.PreferredLanguageCombobox.Items.AddRange(new object[] {
            "French (France)",
            "English (United States)"});
            this.PreferredLanguageCombobox.Location = new System.Drawing.Point(628, 30);
            this.PreferredLanguageCombobox.Name = "PreferredLanguageCombobox";
            this.PreferredLanguageCombobox.Size = new System.Drawing.Size(160, 25);
            this.PreferredLanguageCombobox.TabIndex = 12;
            // 
            // FilterBtn
            // 
            this.FilterBtn.Location = new System.Drawing.Point(13, 57);
            this.FilterBtn.Name = "FilterBtn";
            this.FilterBtn.Size = new System.Drawing.Size(775, 23);
            this.FilterBtn.TabIndex = 13;
            this.FilterBtn.Text = "Filter";
            this.FilterBtn.UseVisualStyleBackColor = true;
            this.FilterBtn.Click += new System.EventHandler(this.FilterBtn_Click);
            // 
            // VisitorAccountManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 409);
            this.Controls.Add(this.FilterBtn);
            this.Controls.Add(this.PreferredLanguageCombobox);
            this.Controls.Add(this.StatusCombobox);
            this.Controls.Add(this.EmailTextbox);
            this.Controls.Add(this.GenderComobox);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.UsernameTextbox);
            this.Controls.Add(this.PreferredLanguageLabel);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.DataGridView);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VisitorAccountManagementForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenderColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreferredLanguageColumn;
        private System.Windows.Forms.DataGridViewLinkColumn OperationColumn;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label PreferredLanguageLabel;
        private System.Windows.Forms.TextBox UsernameTextbox;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.ComboBox GenderComobox;
        private System.Windows.Forms.TextBox EmailTextbox;
        private System.Windows.Forms.ComboBox StatusCombobox;
        private System.Windows.Forms.ComboBox PreferredLanguageCombobox;
        private System.Windows.Forms.Button FilterBtn;
    }
}