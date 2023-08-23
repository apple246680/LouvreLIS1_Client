namespace LouvreLIS_Client
{
    partial class ModifyForm
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
            this.EmailLabel = new System.Windows.Forms.Label();
            this.GemderLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.PreferredLanguageLabel = new System.Windows.Forms.Label();
            this.EmailTextbox = new System.Windows.Forms.TextBox();
            this.FirstNameTextbox = new System.Windows.Forms.TextBox();
            this.LastNameTextbox = new System.Windows.Forms.TextBox();
            this.GenderCombobox = new System.Windows.Forms.ComboBox();
            this.PreferredLanguageCombobox = new System.Windows.Forms.ComboBox();
            this.ReviseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Arial", 15F);
            this.EmailLabel.Location = new System.Drawing.Point(206, 61);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(84, 28);
            this.EmailLabel.TabIndex = 0;
            this.EmailLabel.Text = "Email:";
            // 
            // GemderLabel
            // 
            this.GemderLabel.AutoSize = true;
            this.GemderLabel.Font = new System.Drawing.Font("Arial", 15F);
            this.GemderLabel.Location = new System.Drawing.Point(188, 191);
            this.GemderLabel.Name = "GemderLabel";
            this.GemderLabel.Size = new System.Drawing.Size(102, 28);
            this.GemderLabel.TabIndex = 1;
            this.GemderLabel.Text = "Gender:";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Arial", 15F);
            this.FirstNameLabel.Location = new System.Drawing.Point(147, 103);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(143, 28);
            this.FirstNameLabel.TabIndex = 2;
            this.FirstNameLabel.Text = "First Name:";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Arial", 15F);
            this.LastNameLabel.Location = new System.Drawing.Point(148, 146);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(142, 28);
            this.LastNameLabel.TabIndex = 3;
            this.LastNameLabel.Text = "Last Name:";
            // 
            // PreferredLanguageLabel
            // 
            this.PreferredLanguageLabel.AutoSize = true;
            this.PreferredLanguageLabel.Font = new System.Drawing.Font("Arial", 15F);
            this.PreferredLanguageLabel.Location = new System.Drawing.Point(48, 233);
            this.PreferredLanguageLabel.Name = "PreferredLanguageLabel";
            this.PreferredLanguageLabel.Size = new System.Drawing.Size(242, 28);
            this.PreferredLanguageLabel.TabIndex = 4;
            this.PreferredLanguageLabel.Text = "Preferred Language:";
            // 
            // EmailTextbox
            // 
            this.EmailTextbox.Font = new System.Drawing.Font("Arial", 15F);
            this.EmailTextbox.Location = new System.Drawing.Point(296, 61);
            this.EmailTextbox.Name = "EmailTextbox";
            this.EmailTextbox.Size = new System.Drawing.Size(345, 36);
            this.EmailTextbox.TabIndex = 5;
            // 
            // FirstNameTextbox
            // 
            this.FirstNameTextbox.Font = new System.Drawing.Font("Arial", 15F);
            this.FirstNameTextbox.Location = new System.Drawing.Point(296, 103);
            this.FirstNameTextbox.Name = "FirstNameTextbox";
            this.FirstNameTextbox.Size = new System.Drawing.Size(345, 36);
            this.FirstNameTextbox.TabIndex = 7;
            // 
            // LastNameTextbox
            // 
            this.LastNameTextbox.Font = new System.Drawing.Font("Arial", 15F);
            this.LastNameTextbox.Location = new System.Drawing.Point(296, 146);
            this.LastNameTextbox.Name = "LastNameTextbox";
            this.LastNameTextbox.Size = new System.Drawing.Size(345, 36);
            this.LastNameTextbox.TabIndex = 8;
            // 
            // GenderCombobox
            // 
            this.GenderCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderCombobox.Font = new System.Drawing.Font("Arial", 15F);
            this.GenderCombobox.FormattingEnabled = true;
            this.GenderCombobox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderCombobox.Location = new System.Drawing.Point(296, 191);
            this.GenderCombobox.Name = "GenderCombobox";
            this.GenderCombobox.Size = new System.Drawing.Size(345, 36);
            this.GenderCombobox.TabIndex = 9;
            // 
            // PreferredLanguageCombobox
            // 
            this.PreferredLanguageCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PreferredLanguageCombobox.Font = new System.Drawing.Font("Arial", 15F);
            this.PreferredLanguageCombobox.FormattingEnabled = true;
            this.PreferredLanguageCombobox.Items.AddRange(new object[] {
            "French (France)",
            "English (United States)"});
            this.PreferredLanguageCombobox.Location = new System.Drawing.Point(296, 235);
            this.PreferredLanguageCombobox.Name = "PreferredLanguageCombobox";
            this.PreferredLanguageCombobox.Size = new System.Drawing.Size(345, 36);
            this.PreferredLanguageCombobox.TabIndex = 10;
            // 
            // ReviseBtn
            // 
            this.ReviseBtn.Font = new System.Drawing.Font("Arial", 20F);
            this.ReviseBtn.Location = new System.Drawing.Point(296, 276);
            this.ReviseBtn.Name = "ReviseBtn";
            this.ReviseBtn.Size = new System.Drawing.Size(345, 80);
            this.ReviseBtn.TabIndex = 11;
            this.ReviseBtn.Text = "Revise";
            this.ReviseBtn.UseVisualStyleBackColor = true;
            this.ReviseBtn.Click += new System.EventHandler(this.ReviseBtn_Click);
            // 
            // ModifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.ReviseBtn);
            this.Controls.Add(this.PreferredLanguageCombobox);
            this.Controls.Add(this.GenderCombobox);
            this.Controls.Add(this.LastNameTextbox);
            this.Controls.Add(this.FirstNameTextbox);
            this.Controls.Add(this.EmailTextbox);
            this.Controls.Add(this.PreferredLanguageLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.GemderLabel);
            this.Controls.Add(this.EmailLabel);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModifyForm";
            this.Text = "Modify";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label GemderLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label PreferredLanguageLabel;
        private System.Windows.Forms.TextBox EmailTextbox;
        private System.Windows.Forms.TextBox FirstNameTextbox;
        private System.Windows.Forms.TextBox LastNameTextbox;
        private System.Windows.Forms.ComboBox GenderCombobox;
        private System.Windows.Forms.ComboBox PreferredLanguageCombobox;
        private System.Windows.Forms.Button ReviseBtn;
    }
}