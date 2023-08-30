namespace System
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LoginGroupBox = new System.Windows.Forms.GroupBox();
            this.ShowPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.KeepSigninCheckBox = new System.Windows.Forms.CheckBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UserTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.EmployeeLabel = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.CreateAccountLabel = new System.Windows.Forms.Label();
            this.CreateAccountLinkLabel = new System.Windows.Forms.LinkLabel();
            this.LogoPict = new System.Windows.Forms.PictureBox();
            this.LoginGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPict)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginGroupBox
            // 
            this.LoginGroupBox.Controls.Add(this.ShowPasswordCheckBox);
            this.LoginGroupBox.Controls.Add(this.KeepSigninCheckBox);
            this.LoginGroupBox.Controls.Add(this.PasswordTextBox);
            this.LoginGroupBox.Controls.Add(this.UserTextBox);
            this.LoginGroupBox.Controls.Add(this.EmployeeTextBox);
            this.LoginGroupBox.Controls.Add(this.PasswordLabel);
            this.LoginGroupBox.Controls.Add(this.UserLabel);
            this.LoginGroupBox.Controls.Add(this.EmployeeLabel);
            this.LoginGroupBox.Location = new System.Drawing.Point(106, 59);
            this.LoginGroupBox.Name = "LoginGroupBox";
            this.LoginGroupBox.Size = new System.Drawing.Size(584, 208);
            this.LoginGroupBox.TabIndex = 1;
            this.LoginGroupBox.TabStop = false;
            this.LoginGroupBox.Text = "Login";
            // 
            // ShowPasswordCheckBox
            // 
            this.ShowPasswordCheckBox.AutoSize = true;
            this.ShowPasswordCheckBox.Location = new System.Drawing.Point(378, 125);
            this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            this.ShowPasswordCheckBox.Size = new System.Drawing.Size(118, 19);
            this.ShowPasswordCheckBox.TabIndex = 7;
            this.ShowPasswordCheckBox.Text = "Show Password";
            this.ShowPasswordCheckBox.UseVisualStyleBackColor = true;
            this.ShowPasswordCheckBox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckBox_CheckedChanged);
            // 
            // KeepSigninCheckBox
            // 
            this.KeepSigninCheckBox.AutoSize = true;
            this.KeepSigninCheckBox.Location = new System.Drawing.Point(378, 91);
            this.KeepSigninCheckBox.Name = "KeepSigninCheckBox";
            this.KeepSigninCheckBox.Size = new System.Drawing.Size(134, 19);
            this.KeepSigninCheckBox.TabIndex = 6;
            this.KeepSigninCheckBox.Text = "Keep me signed in";
            this.KeepSigninCheckBox.UseVisualStyleBackColor = true;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(187, 125);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(169, 25);
            this.PasswordTextBox.TabIndex = 5;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // UserTextBox
            // 
            this.UserTextBox.Location = new System.Drawing.Point(187, 89);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.Size = new System.Drawing.Size(169, 25);
            this.UserTextBox.TabIndex = 4;
            // 
            // EmployeeTextBox
            // 
            this.EmployeeTextBox.Location = new System.Drawing.Point(187, 57);
            this.EmployeeTextBox.Name = "EmployeeTextBox";
            this.EmployeeTextBox.Size = new System.Drawing.Size(169, 25);
            this.EmployeeTextBox.TabIndex = 3;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(94, 125);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(64, 15);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password:";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(94, 89);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(37, 15);
            this.UserLabel.TabIndex = 1;
            this.UserLabel.Text = "User:";
            // 
            // EmployeeLabel
            // 
            this.EmployeeLabel.AutoSize = true;
            this.EmployeeLabel.Location = new System.Drawing.Point(94, 57);
            this.EmployeeLabel.Name = "EmployeeLabel";
            this.EmployeeLabel.Size = new System.Drawing.Size(68, 15);
            this.EmployeeLabel.TabIndex = 0;
            this.EmployeeLabel.Text = "Employee:";
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(274, 273);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(94, 47);
            this.LoginBtn.TabIndex = 2;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(384, 273);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(94, 47);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // CreateAccountLabel
            // 
            this.CreateAccountLabel.AutoSize = true;
            this.CreateAccountLabel.Location = new System.Drawing.Point(226, 338);
            this.CreateAccountLabel.Name = "CreateAccountLabel";
            this.CreateAccountLabel.Size = new System.Drawing.Size(142, 15);
            this.CreateAccountLabel.TabIndex = 4;
            this.CreateAccountLabel.Text = "Dont\'t have an account?";
            // 
            // CreateAccountLinkLabel
            // 
            this.CreateAccountLinkLabel.AutoSize = true;
            this.CreateAccountLinkLabel.Location = new System.Drawing.Point(407, 337);
            this.CreateAccountLinkLabel.Name = "CreateAccountLinkLabel";
            this.CreateAccountLinkLabel.Size = new System.Drawing.Size(67, 15);
            this.CreateAccountLinkLabel.TabIndex = 5;
            this.CreateAccountLinkLabel.TabStop = true;
            this.CreateAccountLinkLabel.Text = "Create one";
            this.CreateAccountLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreateAccountLinkLabel_LinkClicked);
            // 
            // LogoPict
            // 
            this.LogoPict.Image = ((System.Drawing.Image)(resources.GetObject("LogoPict.Image")));
            this.LogoPict.Location = new System.Drawing.Point(250, 3);
            this.LogoPict.Name = "LogoPict";
            this.LogoPict.Size = new System.Drawing.Size(285, 50);
            this.LogoPict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPict.TabIndex = 6;
            this.LogoPict.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LogoPict);
            this.Controls.Add(this.CreateAccountLinkLabel);
            this.Controls.Add(this.CreateAccountLabel);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.LoginGroupBox);
            this.Name = "LoginForm";
            this.Size = new System.Drawing.Size(800, 500);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.LoginGroupBox.ResumeLayout(false);
            this.LoginGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPict)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Windows.Forms.GroupBox LoginGroupBox;
        private Windows.Forms.Label UserLabel;
        private Windows.Forms.Label EmployeeLabel;
        private Windows.Forms.CheckBox ShowPasswordCheckBox;
        private Windows.Forms.CheckBox KeepSigninCheckBox;
        private Windows.Forms.TextBox PasswordTextBox;
        private Windows.Forms.TextBox UserTextBox;
        private Windows.Forms.TextBox EmployeeTextBox;
        private Windows.Forms.Label PasswordLabel;
        private Windows.Forms.Button LoginBtn;
        private Windows.Forms.Button ExitBtn;
        private Windows.Forms.Label CreateAccountLabel;
        private Windows.Forms.LinkLabel CreateAccountLinkLabel;
        private Windows.Forms.PictureBox LogoPict;
    }
}
