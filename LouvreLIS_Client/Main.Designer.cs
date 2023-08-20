namespace LouvreLIS_Client
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.DownPanel = new System.Windows.Forms.Panel();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.Pick2 = new System.Windows.Forms.PictureBox();
            this.Pict1 = new System.Windows.Forms.PictureBox();
            this.SignInOutBtn = new System.Windows.Forms.Button();
            this.ShowPanel = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.MyTicketBtn = new System.Windows.Forms.Button();
            this.AccountInformationBtn = new System.Windows.Forms.Button();
            this.DownPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pick2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pict1)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DownPanel
            // 
            this.DownPanel.Controls.Add(this.UserNameLabel);
            this.DownPanel.Controls.Add(this.Pick2);
            this.DownPanel.Controls.Add(this.Pict1);
            this.DownPanel.Controls.Add(this.SignInOutBtn);
            this.DownPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DownPanel.Location = new System.Drawing.Point(0, 457);
            this.DownPanel.Name = "DownPanel";
            this.DownPanel.Size = new System.Drawing.Size(800, 100);
            this.DownPanel.TabIndex = 0;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(557, 28);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(96, 17);
            this.UserNameLabel.TabIndex = 3;
            this.UserNameLabel.Text = "Current User:";
            // 
            // Pick2
            // 
            this.Pick2.Image = ((System.Drawing.Image)(resources.GetObject("Pick2.Image")));
            this.Pick2.Location = new System.Drawing.Point(341, 13);
            this.Pick2.Name = "Pick2";
            this.Pick2.Size = new System.Drawing.Size(210, 75);
            this.Pick2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pick2.TabIndex = 2;
            this.Pick2.TabStop = false;
            // 
            // Pict1
            // 
            this.Pict1.Image = ((System.Drawing.Image)(resources.GetObject("Pict1.Image")));
            this.Pict1.Location = new System.Drawing.Point(260, 12);
            this.Pict1.Name = "Pict1";
            this.Pict1.Size = new System.Drawing.Size(75, 75);
            this.Pict1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pict1.TabIndex = 1;
            this.Pict1.TabStop = false;
            // 
            // SignInOutBtn
            // 
            this.SignInOutBtn.Location = new System.Drawing.Point(12, 12);
            this.SignInOutBtn.Name = "SignInOutBtn";
            this.SignInOutBtn.Size = new System.Drawing.Size(221, 85);
            this.SignInOutBtn.TabIndex = 0;
            this.SignInOutBtn.Text = "Sign In";
            this.SignInOutBtn.UseVisualStyleBackColor = true;
            this.SignInOutBtn.Click += new System.EventHandler(this.SignInBtn_Click);
            // 
            // ShowPanel
            // 
            this.ShowPanel.Location = new System.Drawing.Point(0, 51);
            this.ShowPanel.Name = "ShowPanel";
            this.ShowPanel.Size = new System.Drawing.Size(800, 400);
            this.ShowPanel.TabIndex = 1;
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.MyTicketBtn);
            this.TopPanel.Controls.Add(this.AccountInformationBtn);
            this.TopPanel.Location = new System.Drawing.Point(0, 3);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(800, 42);
            this.TopPanel.TabIndex = 2;
            // 
            // MyTicketBtn
            // 
            this.MyTicketBtn.Location = new System.Drawing.Point(148, 4);
            this.MyTicketBtn.Name = "MyTicketBtn";
            this.MyTicketBtn.Size = new System.Drawing.Size(118, 35);
            this.MyTicketBtn.TabIndex = 1;
            this.MyTicketBtn.Text = "My Ticket";
            this.MyTicketBtn.UseVisualStyleBackColor = true;
            // 
            // AccountInformationBtn
            // 
            this.AccountInformationBtn.Location = new System.Drawing.Point(3, 0);
            this.AccountInformationBtn.Name = "AccountInformationBtn";
            this.AccountInformationBtn.Size = new System.Drawing.Size(139, 42);
            this.AccountInformationBtn.TabIndex = 0;
            this.AccountInformationBtn.Text = "Account Information";
            this.AccountInformationBtn.UseVisualStyleBackColor = true;
            this.AccountInformationBtn.Click += new System.EventHandler(this.AccountInformationBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 557);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.ShowPanel);
            this.Controls.Add(this.DownPanel);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.Name = "Main";
            this.Text = "Louvre-LIS-Client Side";
            this.Load += new System.EventHandler(this.Main_Load);
            this.DownPanel.ResumeLayout(false);
            this.DownPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pick2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pict1)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DownPanel;
        private System.Windows.Forms.Button SignInOutBtn;
        private System.Windows.Forms.Panel ShowPanel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.PictureBox Pick2;
        private System.Windows.Forms.PictureBox Pict1;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button MyTicketBtn;
        private System.Windows.Forms.Button AccountInformationBtn;
    }
}

