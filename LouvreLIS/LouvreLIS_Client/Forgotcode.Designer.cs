namespace LouvreLIS_Client
{
    partial class ForgotcodeForm
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
            this.components = new System.ComponentModel.Container();
            this.TopLabel = new System.Windows.Forms.Label();
            this.CodeLabel = new System.Windows.Forms.Label();
            this.CodeTextbox = new System.Windows.Forms.TextBox();
            this.GetCodeLinkLabel = new System.Windows.Forms.LinkLabel();
            this.BackBtn = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            this.Timer1S = new System.Windows.Forms.Timer(this.components);
            this.VerifyPanel = new System.Windows.Forms.Panel();
            this.VerificationSuccessfulPanel = new System.Windows.Forms.Panel();
            this.SignInBtn = new System.Windows.Forms.Button();
            this.FinishBtn = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.InformationLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Timer1S2 = new System.Windows.Forms.Timer(this.components);
            this.VerifyPanel.SuspendLayout();
            this.VerificationSuccessfulPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopLabel
            // 
            this.TopLabel.AutoSize = true;
            this.TopLabel.Location = new System.Drawing.Point(2, 6);
            this.TopLabel.Name = "TopLabel";
            this.TopLabel.Size = new System.Drawing.Size(409, 34);
            this.TopLabel.TabIndex = 0;
            this.TopLabel.Text = "Please check your mailbox(Do*****@gmail.com) for one time \r\npasscode, type the ve" +
    "rification code below in 2 minutes.";
            // 
            // CodeLabel
            // 
            this.CodeLabel.AutoSize = true;
            this.CodeLabel.Location = new System.Drawing.Point(3, 37);
            this.CodeLabel.Name = "CodeLabel";
            this.CodeLabel.Size = new System.Drawing.Size(47, 17);
            this.CodeLabel.TabIndex = 1;
            this.CodeLabel.Text = "Code:";
            // 
            // CodeTextbox
            // 
            this.CodeTextbox.Location = new System.Drawing.Point(56, 37);
            this.CodeTextbox.Name = "CodeTextbox";
            this.CodeTextbox.Size = new System.Drawing.Size(200, 25);
            this.CodeTextbox.TabIndex = 2;
            // 
            // GetCodeLinkLabel
            // 
            this.GetCodeLinkLabel.AutoSize = true;
            this.GetCodeLinkLabel.Location = new System.Drawing.Point(262, 40);
            this.GetCodeLinkLabel.Name = "GetCodeLinkLabel";
            this.GetCodeLinkLabel.Size = new System.Drawing.Size(168, 17);
            this.GetCodeLinkLabel.TabIndex = 3;
            this.GetCodeLinkLabel.TabStop = true;
            this.GetCodeLinkLabel.Text = "Resend verification code";
            this.GetCodeLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GetCodeLinkLabel_LinkClicked);
            // 
            // BackBtn
            // 
            this.BackBtn.Font = new System.Drawing.Font("Arial", 15F);
            this.BackBtn.Location = new System.Drawing.Point(35, 68);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(150, 73);
            this.BackBtn.TabIndex = 4;
            this.BackBtn.Text = "< Previous";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.Font = new System.Drawing.Font("Arial", 15F);
            this.NextBtn.Location = new System.Drawing.Point(213, 68);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(150, 73);
            this.NextBtn.TabIndex = 5;
            this.NextBtn.Text = "Verify >";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // Timer1S
            // 
            this.Timer1S.Interval = 1000;
            this.Timer1S.Tick += new System.EventHandler(this.Timer1S_Tick);
            // 
            // VerifyPanel
            // 
            this.VerifyPanel.Controls.Add(this.CodeLabel);
            this.VerifyPanel.Controls.Add(this.NextBtn);
            this.VerifyPanel.Controls.Add(this.TopLabel);
            this.VerifyPanel.Controls.Add(this.BackBtn);
            this.VerifyPanel.Controls.Add(this.CodeTextbox);
            this.VerifyPanel.Controls.Add(this.GetCodeLinkLabel);
            this.VerifyPanel.Location = new System.Drawing.Point(3, 3);
            this.VerifyPanel.Name = "VerifyPanel";
            this.VerifyPanel.Size = new System.Drawing.Size(503, 144);
            this.VerifyPanel.TabIndex = 6;
            // 
            // VerificationSuccessfulPanel
            // 
            this.VerificationSuccessfulPanel.Controls.Add(this.SignInBtn);
            this.VerificationSuccessfulPanel.Controls.Add(this.FinishBtn);
            this.VerificationSuccessfulPanel.Controls.Add(this.PasswordLabel);
            this.VerificationSuccessfulPanel.Controls.Add(this.UsernameLabel);
            this.VerificationSuccessfulPanel.Controls.Add(this.InformationLabel);
            this.VerificationSuccessfulPanel.Location = new System.Drawing.Point(3, 153);
            this.VerificationSuccessfulPanel.Name = "VerificationSuccessfulPanel";
            this.VerificationSuccessfulPanel.Size = new System.Drawing.Size(503, 185);
            this.VerificationSuccessfulPanel.TabIndex = 7;
            // 
            // SignInBtn
            // 
            this.SignInBtn.Location = new System.Drawing.Point(203, 103);
            this.SignInBtn.Name = "SignInBtn";
            this.SignInBtn.Size = new System.Drawing.Size(137, 69);
            this.SignInBtn.TabIndex = 4;
            this.SignInBtn.Text = "Sign In>";
            this.SignInBtn.UseVisualStyleBackColor = true;
            this.SignInBtn.Click += new System.EventHandler(this.SignInBtn_Click);
            // 
            // FinishBtn
            // 
            this.FinishBtn.Location = new System.Drawing.Point(48, 103);
            this.FinishBtn.Name = "FinishBtn";
            this.FinishBtn.Size = new System.Drawing.Size(137, 69);
            this.FinishBtn.TabIndex = 3;
            this.FinishBtn.Text = "< Finish";
            this.FinishBtn.UseVisualStyleBackColor = true;
            this.FinishBtn.Click += new System.EventHandler(this.FinishBtn_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(127, 64);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(78, 17);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password:";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(127, 47);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(80, 17);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "Username:";
            // 
            // InformationLabel
            // 
            this.InformationLabel.AutoSize = true;
            this.InformationLabel.Location = new System.Drawing.Point(32, 30);
            this.InformationLabel.Name = "InformationLabel";
            this.InformationLabel.Size = new System.Drawing.Size(184, 17);
            this.InformationLabel.TabIndex = 0;
            this.InformationLabel.Text = "InYour account information:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.VerifyPanel);
            this.flowLayoutPanel1.Controls.Add(this.VerificationSuccessfulPanel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(171, 24);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(506, 354);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // Timer1S2
            // 
            this.Timer1S2.Interval = 1000;
            this.Timer1S2.Tick += new System.EventHandler(this.Timer1S2_Tick);
            // 
            // ForgotcodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgotcodeForm";
            this.Text = "Forgotcode";
            this.VerifyPanel.ResumeLayout(false);
            this.VerifyPanel.PerformLayout();
            this.VerificationSuccessfulPanel.ResumeLayout(false);
            this.VerificationSuccessfulPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TopLabel;
        private System.Windows.Forms.Label CodeLabel;
        private System.Windows.Forms.TextBox CodeTextbox;
        private System.Windows.Forms.LinkLabel GetCodeLinkLabel;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Timer Timer1S;
        private System.Windows.Forms.Panel VerifyPanel;
        private System.Windows.Forms.Panel VerificationSuccessfulPanel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label InformationLabel;
        private System.Windows.Forms.Button SignInBtn;
        private System.Windows.Forms.Button FinishBtn;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Timer Timer1S2;
    }
}