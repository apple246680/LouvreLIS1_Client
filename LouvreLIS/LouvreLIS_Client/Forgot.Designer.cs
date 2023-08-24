namespace LouvreLIS_Client
{
    partial class ForgotForm
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
            this.EmailTextbox = new System.Windows.Forms.TextBox();
            this.FindmyLabel = new System.Windows.Forms.Label();
            this.UsernameCheckbox = new System.Windows.Forms.CheckBox();
            this.PasswordCheckbox = new System.Windows.Forms.CheckBox();
            this.SendBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Arial", 15F);
            this.EmailLabel.Location = new System.Drawing.Point(112, 105);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(84, 28);
            this.EmailLabel.TabIndex = 0;
            this.EmailLabel.Text = "Email:";
            // 
            // EmailTextbox
            // 
            this.EmailTextbox.Font = new System.Drawing.Font("Arial", 15F);
            this.EmailTextbox.Location = new System.Drawing.Point(202, 105);
            this.EmailTextbox.Name = "EmailTextbox";
            this.EmailTextbox.Size = new System.Drawing.Size(375, 36);
            this.EmailTextbox.TabIndex = 1;
            // 
            // FindmyLabel
            // 
            this.FindmyLabel.AutoSize = true;
            this.FindmyLabel.Font = new System.Drawing.Font("Arial", 15F);
            this.FindmyLabel.Location = new System.Drawing.Point(87, 155);
            this.FindmyLabel.Name = "FindmyLabel";
            this.FindmyLabel.Size = new System.Drawing.Size(109, 28);
            this.FindmyLabel.TabIndex = 2;
            this.FindmyLabel.Text = "Find my:";
            // 
            // UsernameCheckbox
            // 
            this.UsernameCheckbox.AutoSize = true;
            this.UsernameCheckbox.Font = new System.Drawing.Font("Arial", 15F);
            this.UsernameCheckbox.Location = new System.Drawing.Point(214, 155);
            this.UsernameCheckbox.Name = "UsernameCheckbox";
            this.UsernameCheckbox.Size = new System.Drawing.Size(151, 32);
            this.UsernameCheckbox.TabIndex = 3;
            this.UsernameCheckbox.Text = "Username";
            this.UsernameCheckbox.UseVisualStyleBackColor = true;
            this.UsernameCheckbox.CheckedChanged += new System.EventHandler(this.UsernameCheckbox_CheckedChanged);
            // 
            // PasswordCheckbox
            // 
            this.PasswordCheckbox.AutoSize = true;
            this.PasswordCheckbox.Font = new System.Drawing.Font("Arial", 15F);
            this.PasswordCheckbox.Location = new System.Drawing.Point(371, 155);
            this.PasswordCheckbox.Name = "PasswordCheckbox";
            this.PasswordCheckbox.Size = new System.Drawing.Size(146, 32);
            this.PasswordCheckbox.TabIndex = 4;
            this.PasswordCheckbox.Text = "Password";
            this.PasswordCheckbox.UseVisualStyleBackColor = true;
            this.PasswordCheckbox.CheckedChanged += new System.EventHandler(this.PasswordCheckbox_CheckedChanged);
            // 
            // SendBtn
            // 
            this.SendBtn.Font = new System.Drawing.Font("Arial", 12F);
            this.SendBtn.Location = new System.Drawing.Point(92, 207);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(485, 73);
            this.SendBtn.TabIndex = 5;
            this.SendBtn.Text = "Choose Username or Password";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // ForgotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.PasswordCheckbox);
            this.Controls.Add(this.UsernameCheckbox);
            this.Controls.Add(this.FindmyLabel);
            this.Controls.Add(this.EmailTextbox);
            this.Controls.Add(this.EmailLabel);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgotForm";
            this.Text = "Forgot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox EmailTextbox;
        private System.Windows.Forms.Label FindmyLabel;
        private System.Windows.Forms.CheckBox UsernameCheckbox;
        private System.Windows.Forms.CheckBox PasswordCheckbox;
        private System.Windows.Forms.Button SendBtn;
    }
}