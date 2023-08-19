namespace LouvreLIS_Client
{
    partial class LoginForm
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
            this.AccountLabel = new System.Windows.Forms.Label();
            this.AccountTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.PasswordPanel = new System.Windows.Forms.Label();
            this.SignInBtn = new System.Windows.Forms.Button();
            this.ForgotLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // AccountLabel
            // 
            this.AccountLabel.AutoSize = true;
            this.AccountLabel.Font = new System.Drawing.Font("Arial", 9F);
            this.AccountLabel.Location = new System.Drawing.Point(131, 84);
            this.AccountLabel.Name = "AccountLabel";
            this.AccountLabel.Size = new System.Drawing.Size(118, 17);
            this.AccountLabel.TabIndex = 0;
            this.AccountLabel.Text = "Email/UseName:";
            // 
            // AccountTextBox
            // 
            this.AccountTextBox.Location = new System.Drawing.Point(251, 73);
            this.AccountTextBox.Name = "AccountTextBox";
            this.AccountTextBox.Size = new System.Drawing.Size(295, 25);
            this.AccountTextBox.TabIndex = 1;
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Location = new System.Drawing.Point(251, 104);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(295, 25);
            this.PasswordTextbox.TabIndex = 3;
            // 
            // PasswordPanel
            // 
            this.PasswordPanel.AutoSize = true;
            this.PasswordPanel.Font = new System.Drawing.Font("Arial", 9F);
            this.PasswordPanel.Location = new System.Drawing.Point(162, 112);
            this.PasswordPanel.Name = "PasswordPanel";
            this.PasswordPanel.Size = new System.Drawing.Size(74, 17);
            this.PasswordPanel.TabIndex = 2;
            this.PasswordPanel.Text = "Password";
            // 
            // SignInBtn
            // 
            this.SignInBtn.Font = new System.Drawing.Font("Arial", 15F);
            this.SignInBtn.Location = new System.Drawing.Point(134, 177);
            this.SignInBtn.Name = "SignInBtn";
            this.SignInBtn.Size = new System.Drawing.Size(412, 87);
            this.SignInBtn.TabIndex = 4;
            this.SignInBtn.Text = "Sign In";
            this.SignInBtn.UseVisualStyleBackColor = true;
            this.SignInBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ForgotLinkLabel
            // 
            this.ForgotLinkLabel.AutoSize = true;
            this.ForgotLinkLabel.Location = new System.Drawing.Point(259, 144);
            this.ForgotLinkLabel.Name = "ForgotLinkLabel";
            this.ForgotLinkLabel.Size = new System.Drawing.Size(188, 17);
            this.ForgotLinkLabel.TabIndex = 5;
            this.ForgotLinkLabel.TabStop = true;
            this.ForgotLinkLabel.Text = "Forgot username/password";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.ForgotLinkLabel);
            this.Controls.Add(this.SignInBtn);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.PasswordPanel);
            this.Controls.Add(this.AccountTextBox);
            this.Controls.Add(this.AccountLabel);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AccountLabel;
        private System.Windows.Forms.TextBox AccountTextBox;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.Label PasswordPanel;
        private System.Windows.Forms.Button SignInBtn;
        private System.Windows.Forms.LinkLabel ForgotLinkLabel;
    }
}