namespace LouvreLIS_Management
{
    partial class AccountInfoForm
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
            this.EmployeeIDLabel = new System.Windows.Forms.Label();
            this.EmployeeTypeLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EmployeeIDLabel
            // 
            this.EmployeeIDLabel.AutoSize = true;
            this.EmployeeIDLabel.Font = new System.Drawing.Font("Arial", 15F);
            this.EmployeeIDLabel.Location = new System.Drawing.Point(117, 51);
            this.EmployeeIDLabel.Name = "EmployeeIDLabel";
            this.EmployeeIDLabel.Size = new System.Drawing.Size(156, 28);
            this.EmployeeIDLabel.TabIndex = 0;
            this.EmployeeIDLabel.Text = "EmployeeID:";
            // 
            // EmployeeTypeLabel
            // 
            this.EmployeeTypeLabel.AutoSize = true;
            this.EmployeeTypeLabel.Font = new System.Drawing.Font("Arial", 15F);
            this.EmployeeTypeLabel.Location = new System.Drawing.Point(117, 94);
            this.EmployeeTypeLabel.Name = "EmployeeTypeLabel";
            this.EmployeeTypeLabel.Size = new System.Drawing.Size(185, 28);
            this.EmployeeTypeLabel.TabIndex = 1;
            this.EmployeeTypeLabel.Text = "EmployeeType:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Arial", 15F);
            this.EmailLabel.Location = new System.Drawing.Point(117, 137);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(84, 28);
            this.EmailLabel.TabIndex = 2;
            this.EmailLabel.Text = "Email:";
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Font = new System.Drawing.Font("Arial", 15F);
            this.GenderLabel.Location = new System.Drawing.Point(117, 180);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(102, 28);
            this.GenderLabel.TabIndex = 3;
            this.GenderLabel.Text = "Gender:";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Arial", 15F);
            this.LastNameLabel.Location = new System.Drawing.Point(117, 223);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(142, 28);
            this.LastNameLabel.TabIndex = 4;
            this.LastNameLabel.Text = "Last Name:";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Arial", 15F);
            this.FirstNameLabel.Location = new System.Drawing.Point(117, 266);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(143, 28);
            this.FirstNameLabel.TabIndex = 5;
            this.FirstNameLabel.Text = "First Name:";
            // 
            // AccountInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 393);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.EmployeeTypeLabel);
            this.Controls.Add(this.EmployeeIDLabel);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AccountInfoForm";
            this.Text = "AccountInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmployeeIDLabel;
        private System.Windows.Forms.Label EmployeeTypeLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label FirstNameLabel;
    }
}