namespace LouvreLIS_Management
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
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.SignBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ApiNumberLabel = new System.Windows.Forms.Label();
            this.ApiStatusLabel = new System.Windows.Forms.Label();
            this.ApiStatusBallLabel = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.AccountInfoBtn = new System.Windows.Forms.Button();
            this.ShowPanel = new System.Windows.Forms.Panel();
            this.DownPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DownPanel
            // 
            this.DownPanel.Controls.Add(this.UsernameLabel);
            this.DownPanel.Controls.Add(this.SignBtn);
            this.DownPanel.Controls.Add(this.pictureBox2);
            this.DownPanel.Controls.Add(this.pictureBox1);
            this.DownPanel.Controls.Add(this.ApiNumberLabel);
            this.DownPanel.Controls.Add(this.ApiStatusLabel);
            this.DownPanel.Controls.Add(this.ApiStatusBallLabel);
            this.DownPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DownPanel.Location = new System.Drawing.Point(0, 436);
            this.DownPanel.Name = "DownPanel";
            this.DownPanel.Size = new System.Drawing.Size(800, 74);
            this.DownPanel.TabIndex = 0;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(520, 53);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(182, 17);
            this.UsernameLabel.TabIndex = 6;
            this.UsernameLabel.Text = "Current User:Not Signed In";
            // 
            // SignBtn
            // 
            this.SignBtn.Font = new System.Drawing.Font("Arial", 15F);
            this.SignBtn.Location = new System.Drawing.Point(511, 0);
            this.SignBtn.Name = "SignBtn";
            this.SignBtn.Size = new System.Drawing.Size(277, 50);
            this.SignBtn.TabIndex = 5;
            this.SignBtn.Text = "Sign In";
            this.SignBtn.UseVisualStyleBackColor = true;
            this.SignBtn.Click += new System.EventHandler(this.SignBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(347, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(158, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(221, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // ApiNumberLabel
            // 
            this.ApiNumberLabel.AutoSize = true;
            this.ApiNumberLabel.Location = new System.Drawing.Point(81, 50);
            this.ApiNumberLabel.Name = "ApiNumberLabel";
            this.ApiNumberLabel.Size = new System.Drawing.Size(16, 17);
            this.ApiNumberLabel.TabIndex = 2;
            this.ApiNumberLabel.Text = "[]";
            // 
            // ApiStatusLabel
            // 
            this.ApiStatusLabel.AutoSize = true;
            this.ApiStatusLabel.Location = new System.Drawing.Point(81, 20);
            this.ApiStatusLabel.Name = "ApiStatusLabel";
            this.ApiStatusLabel.Size = new System.Drawing.Size(80, 17);
            this.ApiStatusLabel.TabIndex = 1;
            this.ApiStatusLabel.Text = "API Status:";
            // 
            // ApiStatusBallLabel
            // 
            this.ApiStatusBallLabel.AutoSize = true;
            this.ApiStatusBallLabel.Font = new System.Drawing.Font("Arial", 40F);
            this.ApiStatusBallLabel.ForeColor = System.Drawing.Color.Lime;
            this.ApiStatusBallLabel.Location = new System.Drawing.Point(3, 4);
            this.ApiStatusBallLabel.Name = "ApiStatusBallLabel";
            this.ApiStatusBallLabel.Size = new System.Drawing.Size(72, 75);
            this.ApiStatusBallLabel.TabIndex = 0;
            this.ApiStatusBallLabel.Text = "●";
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.AccountInfoBtn);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(800, 43);
            this.TopPanel.TabIndex = 1;
            // 
            // AccountInfoBtn
            // 
            this.AccountInfoBtn.Location = new System.Drawing.Point(3, 6);
            this.AccountInfoBtn.Name = "AccountInfoBtn";
            this.AccountInfoBtn.Size = new System.Drawing.Size(107, 34);
            this.AccountInfoBtn.TabIndex = 0;
            this.AccountInfoBtn.Text = "AccountInfo";
            this.AccountInfoBtn.UseVisualStyleBackColor = true;
            this.AccountInfoBtn.Visible = false;
            this.AccountInfoBtn.Click += new System.EventHandler(this.AccountInfoBtn_Click);
            // 
            // ShowPanel
            // 
            this.ShowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShowPanel.Location = new System.Drawing.Point(0, 43);
            this.ShowPanel.Name = "ShowPanel";
            this.ShowPanel.Size = new System.Drawing.Size(800, 393);
            this.ShowPanel.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.ShowPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.DownPanel);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Louvre-LIS-Management Side";
            this.Load += new System.EventHandler(this.Main_Load);
            this.DownPanel.ResumeLayout(false);
            this.DownPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DownPanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel ShowPanel;
        private System.Windows.Forms.Label ApiNumberLabel;
        private System.Windows.Forms.Label ApiStatusLabel;
        private System.Windows.Forms.Label ApiStatusBallLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Button SignBtn;
        private System.Windows.Forms.Button AccountInfoBtn;
    }
}

