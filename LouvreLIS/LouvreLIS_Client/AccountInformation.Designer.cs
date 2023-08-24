namespace LouvreLIS_Client
{
    partial class AccountInformationForm
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
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.CodeLabel = new System.Windows.Forms.Label();
            this.GengerLabel = new System.Windows.Forms.Label();
            this.PreferredLanguageLabel = new System.Windows.Forms.Label();
            this.SortPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.UserNamePanel = new System.Windows.Forms.Panel();
            this.ShowBtn = new System.Windows.Forms.Button();
            this.EmailPanel = new System.Windows.Forms.Panel();
            this.VerifyLabel = new System.Windows.Forms.Label();
            this.VerifyLinkLabel = new System.Windows.Forms.LinkLabel();
            this.CodePanel = new System.Windows.Forms.Panel();
            this.VerifyBtn = new System.Windows.Forms.Button();
            this.CodeTextbox = new System.Windows.Forms.TextBox();
            this.GengePanel = new System.Windows.Forms.Panel();
            this.PreferredLanguagePanel = new System.Windows.Forms.Panel();
            this.ModifyBtn = new System.Windows.Forms.Button();
            this.Timer1S = new System.Windows.Forms.Timer(this.components);
            this.SortPanel.SuspendLayout();
            this.UserNamePanel.SuspendLayout();
            this.EmailPanel.SuspendLayout();
            this.CodePanel.SuspendLayout();
            this.GengePanel.SuspendLayout();
            this.PreferredLanguagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.UserNameLabel.Font = new System.Drawing.Font("Arial", 15F);
            this.UserNameLabel.Location = new System.Drawing.Point(0, 0);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(140, 28);
            this.UserNameLabel.TabIndex = 0;
            this.UserNameLabel.Text = "UserName:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.EmailLabel.Font = new System.Drawing.Font("Arial", 15F);
            this.EmailLabel.Location = new System.Drawing.Point(0, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(84, 28);
            this.EmailLabel.TabIndex = 1;
            this.EmailLabel.Text = "Email:";
            // 
            // CodeLabel
            // 
            this.CodeLabel.AutoSize = true;
            this.CodeLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.CodeLabel.Font = new System.Drawing.Font("Arial", 15F);
            this.CodeLabel.Location = new System.Drawing.Point(0, 0);
            this.CodeLabel.Name = "CodeLabel";
            this.CodeLabel.Size = new System.Drawing.Size(79, 28);
            this.CodeLabel.TabIndex = 2;
            this.CodeLabel.Text = "Code:";
            // 
            // GengerLabel
            // 
            this.GengerLabel.AutoSize = true;
            this.GengerLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.GengerLabel.Font = new System.Drawing.Font("Arial", 15F);
            this.GengerLabel.Location = new System.Drawing.Point(0, 0);
            this.GengerLabel.Name = "GengerLabel";
            this.GengerLabel.Size = new System.Drawing.Size(102, 28);
            this.GengerLabel.TabIndex = 3;
            this.GengerLabel.Text = "Genger:";
            // 
            // PreferredLanguageLabel
            // 
            this.PreferredLanguageLabel.AutoSize = true;
            this.PreferredLanguageLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.PreferredLanguageLabel.Font = new System.Drawing.Font("Arial", 15F);
            this.PreferredLanguageLabel.Location = new System.Drawing.Point(0, 0);
            this.PreferredLanguageLabel.Name = "PreferredLanguageLabel";
            this.PreferredLanguageLabel.Size = new System.Drawing.Size(242, 28);
            this.PreferredLanguageLabel.TabIndex = 4;
            this.PreferredLanguageLabel.Text = "Preferred Language:";
            // 
            // SortPanel
            // 
            this.SortPanel.Controls.Add(this.UserNamePanel);
            this.SortPanel.Controls.Add(this.EmailPanel);
            this.SortPanel.Controls.Add(this.CodePanel);
            this.SortPanel.Controls.Add(this.GengePanel);
            this.SortPanel.Controls.Add(this.PreferredLanguagePanel);
            this.SortPanel.Controls.Add(this.ModifyBtn);
            this.SortPanel.Location = new System.Drawing.Point(95, 12);
            this.SortPanel.Name = "SortPanel";
            this.SortPanel.Size = new System.Drawing.Size(613, 376);
            this.SortPanel.TabIndex = 5;
            // 
            // UserNamePanel
            // 
            this.UserNamePanel.Controls.Add(this.ShowBtn);
            this.UserNamePanel.Controls.Add(this.UserNameLabel);
            this.UserNamePanel.Location = new System.Drawing.Point(3, 3);
            this.UserNamePanel.Name = "UserNamePanel";
            this.UserNamePanel.Size = new System.Drawing.Size(610, 33);
            this.UserNamePanel.TabIndex = 6;
            // 
            // ShowBtn
            // 
            this.ShowBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.ShowBtn.Location = new System.Drawing.Point(140, 0);
            this.ShowBtn.Name = "ShowBtn";
            this.ShowBtn.Size = new System.Drawing.Size(75, 33);
            this.ShowBtn.TabIndex = 1;
            this.ShowBtn.Text = "show";
            this.ShowBtn.UseVisualStyleBackColor = true;
            this.ShowBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShowBtn_MouseDown);
            this.ShowBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ShowBtn_MouseUp);
            // 
            // EmailPanel
            // 
            this.EmailPanel.Controls.Add(this.VerifyLabel);
            this.EmailPanel.Controls.Add(this.VerifyLinkLabel);
            this.EmailPanel.Controls.Add(this.EmailLabel);
            this.EmailPanel.Location = new System.Drawing.Point(3, 42);
            this.EmailPanel.Name = "EmailPanel";
            this.EmailPanel.Size = new System.Drawing.Size(610, 33);
            this.EmailPanel.TabIndex = 7;
            // 
            // VerifyLabel
            // 
            this.VerifyLabel.AutoSize = true;
            this.VerifyLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.VerifyLabel.Font = new System.Drawing.Font("Arial", 11F);
            this.VerifyLabel.Location = new System.Drawing.Point(189, 0);
            this.VerifyLabel.Name = "VerifyLabel";
            this.VerifyLabel.Size = new System.Drawing.Size(87, 22);
            this.VerifyLabel.TabIndex = 3;
            this.VerifyLabel.Text = "(Verified)";
            // 
            // VerifyLinkLabel
            // 
            this.VerifyLinkLabel.AutoSize = true;
            this.VerifyLinkLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.VerifyLinkLabel.Location = new System.Drawing.Point(84, 0);
            this.VerifyLinkLabel.Name = "VerifyLinkLabel";
            this.VerifyLinkLabel.Size = new System.Drawing.Size(105, 17);
            this.VerifyLinkLabel.TabIndex = 2;
            this.VerifyLinkLabel.TabStop = true;
            this.VerifyLinkLabel.Text = "(Click to Verify)";
            this.VerifyLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.VerifyLinkLabel_LinkClicked);
            // 
            // CodePanel
            // 
            this.CodePanel.Controls.Add(this.VerifyBtn);
            this.CodePanel.Controls.Add(this.CodeTextbox);
            this.CodePanel.Controls.Add(this.CodeLabel);
            this.CodePanel.Location = new System.Drawing.Point(3, 81);
            this.CodePanel.Name = "CodePanel";
            this.CodePanel.Size = new System.Drawing.Size(610, 57);
            this.CodePanel.TabIndex = 8;
            // 
            // VerifyBtn
            // 
            this.VerifyBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.VerifyBtn.Location = new System.Drawing.Point(463, 0);
            this.VerifyBtn.Name = "VerifyBtn";
            this.VerifyBtn.Size = new System.Drawing.Size(144, 57);
            this.VerifyBtn.TabIndex = 4;
            this.VerifyBtn.Text = "Verify";
            this.VerifyBtn.UseVisualStyleBackColor = true;
            this.VerifyBtn.Click += new System.EventHandler(this.VerifyBtn_Click);
            // 
            // CodeTextbox
            // 
            this.CodeTextbox.Dock = System.Windows.Forms.DockStyle.Left;
            this.CodeTextbox.Location = new System.Drawing.Point(79, 0);
            this.CodeTextbox.MaxLength = 6;
            this.CodeTextbox.Multiline = true;
            this.CodeTextbox.Name = "CodeTextbox";
            this.CodeTextbox.Size = new System.Drawing.Size(384, 57);
            this.CodeTextbox.TabIndex = 3;
            // 
            // GengePanel
            // 
            this.GengePanel.Controls.Add(this.GengerLabel);
            this.GengePanel.Location = new System.Drawing.Point(3, 144);
            this.GengePanel.Name = "GengePanel";
            this.GengePanel.Size = new System.Drawing.Size(607, 33);
            this.GengePanel.TabIndex = 9;
            // 
            // PreferredLanguagePanel
            // 
            this.PreferredLanguagePanel.Controls.Add(this.PreferredLanguageLabel);
            this.PreferredLanguagePanel.Location = new System.Drawing.Point(3, 183);
            this.PreferredLanguagePanel.Name = "PreferredLanguagePanel";
            this.PreferredLanguagePanel.Size = new System.Drawing.Size(607, 36);
            this.PreferredLanguagePanel.TabIndex = 10;
            // 
            // ModifyBtn
            // 
            this.ModifyBtn.Font = new System.Drawing.Font("Arial", 15F);
            this.ModifyBtn.Location = new System.Drawing.Point(3, 225);
            this.ModifyBtn.Name = "ModifyBtn";
            this.ModifyBtn.Size = new System.Drawing.Size(607, 125);
            this.ModifyBtn.TabIndex = 11;
            this.ModifyBtn.Text = "Modify";
            this.ModifyBtn.UseVisualStyleBackColor = true;
            this.ModifyBtn.Click += new System.EventHandler(this.ModifyBtn_Click);
            // 
            // Timer1S
            // 
            this.Timer1S.Interval = 1000;
            this.Timer1S.Tick += new System.EventHandler(this.Timer1S_Tick);
            // 
            // AccountInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.SortPanel);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountInformationForm";
            this.Text = "AccountInformation";
            this.SortPanel.ResumeLayout(false);
            this.UserNamePanel.ResumeLayout(false);
            this.UserNamePanel.PerformLayout();
            this.EmailPanel.ResumeLayout(false);
            this.EmailPanel.PerformLayout();
            this.CodePanel.ResumeLayout(false);
            this.CodePanel.PerformLayout();
            this.GengePanel.ResumeLayout(false);
            this.GengePanel.PerformLayout();
            this.PreferredLanguagePanel.ResumeLayout(false);
            this.PreferredLanguagePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label CodeLabel;
        private System.Windows.Forms.Label GengerLabel;
        private System.Windows.Forms.Label PreferredLanguageLabel;
        private System.Windows.Forms.FlowLayoutPanel SortPanel;
        private System.Windows.Forms.Panel UserNamePanel;
        private System.Windows.Forms.Panel EmailPanel;
        private System.Windows.Forms.Panel CodePanel;
        private System.Windows.Forms.Button VerifyBtn;
        private System.Windows.Forms.TextBox CodeTextbox;
        private System.Windows.Forms.Panel GengePanel;
        private System.Windows.Forms.Panel PreferredLanguagePanel;
        private System.Windows.Forms.Button ModifyBtn;
        private System.Windows.Forms.LinkLabel VerifyLinkLabel;
        private System.Windows.Forms.Button ShowBtn;
        private System.Windows.Forms.Label VerifyLabel;
        private System.Windows.Forms.Timer Timer1S;
    }
}