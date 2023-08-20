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
            this.SuspendLayout();
            // 
            // TopLabel
            // 
            this.TopLabel.AutoSize = true;
            this.TopLabel.Location = new System.Drawing.Point(159, 40);
            this.TopLabel.Name = "TopLabel";
            this.TopLabel.Size = new System.Drawing.Size(409, 34);
            this.TopLabel.TabIndex = 0;
            this.TopLabel.Text = "Please check your mailbox(Do*****@gmail.com) for one time \r\npasscode, type the ve" +
    "rification code below in 2 minutes.";
            // 
            // CodeLabel
            // 
            this.CodeLabel.AutoSize = true;
            this.CodeLabel.Location = new System.Drawing.Point(162, 136);
            this.CodeLabel.Name = "CodeLabel";
            this.CodeLabel.Size = new System.Drawing.Size(47, 17);
            this.CodeLabel.TabIndex = 1;
            this.CodeLabel.Text = "Code:";
            // 
            // CodeTextbox
            // 
            this.CodeTextbox.Location = new System.Drawing.Point(215, 136);
            this.CodeTextbox.Name = "CodeTextbox";
            this.CodeTextbox.Size = new System.Drawing.Size(200, 25);
            this.CodeTextbox.TabIndex = 2;
            // 
            // GetCodeLinkLabel
            // 
            this.GetCodeLinkLabel.AutoSize = true;
            this.GetCodeLinkLabel.Location = new System.Drawing.Point(421, 139);
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
            this.BackBtn.Location = new System.Drawing.Point(162, 200);
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
            this.NextBtn.Location = new System.Drawing.Point(340, 200);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(150, 73);
            this.NextBtn.TabIndex = 5;
            this.NextBtn.Text = "Verify >";
            this.NextBtn.UseVisualStyleBackColor = true;
            // 
            // Timer1S
            // 
            this.Timer1S.Interval = 1000;
            this.Timer1S.Tick += new System.EventHandler(this.Timer1S_Tick);
            // 
            // ForgotcodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.GetCodeLinkLabel);
            this.Controls.Add(this.CodeTextbox);
            this.Controls.Add(this.CodeLabel);
            this.Controls.Add(this.TopLabel);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgotcodeForm";
            this.Text = "Forgotcode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TopLabel;
        private System.Windows.Forms.Label CodeLabel;
        private System.Windows.Forms.TextBox CodeTextbox;
        private System.Windows.Forms.LinkLabel GetCodeLinkLabel;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Timer Timer1S;
    }
}