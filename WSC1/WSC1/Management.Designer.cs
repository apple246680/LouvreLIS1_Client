namespace WSC1
{
    partial class ManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagementForm));
            this.LogoPict = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.imTravelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imOwnerManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.ShowPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPict)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogoPict
            // 
            this.LogoPict.Image = ((System.Drawing.Image)(resources.GetObject("LogoPict.Image")));
            this.LogoPict.Location = new System.Drawing.Point(218, 13);
            this.LogoPict.Name = "LogoPict";
            this.LogoPict.Size = new System.Drawing.Size(297, 50);
            this.LogoPict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPict.TabIndex = 0;
            this.LogoPict.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imTravelerToolStripMenuItem,
            this.imOwnerManagerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(10, 76);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(264, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // imTravelerToolStripMenuItem
            // 
            this.imTravelerToolStripMenuItem.Name = "imTravelerToolStripMenuItem";
            this.imTravelerToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.imTravelerToolStripMenuItem.Text = "I\'m Traveler";
            this.imTravelerToolStripMenuItem.Click += new System.EventHandler(this.imTravelerToolStripMenuItem_Click);
            // 
            // imOwnerManagerToolStripMenuItem
            // 
            this.imOwnerManagerToolStripMenuItem.Name = "imOwnerManagerToolStripMenuItem";
            this.imOwnerManagerToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.imOwnerManagerToolStripMenuItem.Text = "I\'m Owner/Manager";
            this.imOwnerManagerToolStripMenuItem.Click += new System.EventHandler(this.imOwnerManagerToolStripMenuItem_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Location = new System.Drawing.Point(562, 76);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(75, 23);
            this.LogoutBtn.TabIndex = 2;
            this.LogoutBtn.Text = "Log out";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(643, 76);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // ShowPanel
            // 
            this.ShowPanel.Location = new System.Drawing.Point(10, 108);
            this.ShowPanel.Name = "ShowPanel";
            this.ShowPanel.Size = new System.Drawing.Size(750, 300);
            this.ShowPanel.TabIndex = 4;
            // 
            // ManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ShowPanel);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.LogoPict);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.Name = "ManagementForm";
            this.Size = new System.Drawing.Size(800, 500);
            this.Load += new System.EventHandler(this.ManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPict)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoPict;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem imTravelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imOwnerManagerToolStripMenuItem;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Panel ShowPanel;
    }
}
