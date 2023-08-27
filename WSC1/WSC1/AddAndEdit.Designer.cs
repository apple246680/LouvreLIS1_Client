namespace WSC1
{
    partial class AddAndEditForm
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
            this.NextBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.ShowPanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listingDetallsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.amenitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diistanceToAttractionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NextBtn
            // 
            this.NextBtn.Location = new System.Drawing.Point(527, 469);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(106, 28);
            this.NextBtn.TabIndex = 0;
            this.NextBtn.Text = "Next";
            this.NextBtn.UseVisualStyleBackColor = true;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(639, 469);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(106, 28);
            this.CloseBtn.TabIndex = 1;
            this.CloseBtn.Text = "Close/Finish";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // ShowPanel
            // 
            this.ShowPanel.Location = new System.Drawing.Point(4, 35);
            this.ShowPanel.Name = "ShowPanel";
            this.ShowPanel.Size = new System.Drawing.Size(790, 430);
            this.ShowPanel.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listingDetallsToolStripMenuItem,
            this.amenitiesToolStripMenuItem,
            this.diistanceToAttractionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listingDetallsToolStripMenuItem
            // 
            this.listingDetallsToolStripMenuItem.Name = "listingDetallsToolStripMenuItem";
            this.listingDetallsToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.listingDetallsToolStripMenuItem.Text = "Listing Detalls";
            this.listingDetallsToolStripMenuItem.Click += new System.EventHandler(this.listingDetallsToolStripMenuItem_Click);
            // 
            // amenitiesToolStripMenuItem
            // 
            this.amenitiesToolStripMenuItem.Name = "amenitiesToolStripMenuItem";
            this.amenitiesToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.amenitiesToolStripMenuItem.Text = "Amenities";
            this.amenitiesToolStripMenuItem.Click += new System.EventHandler(this.amenitiesToolStripMenuItem_Click);
            // 
            // diistanceToAttractionToolStripMenuItem
            // 
            this.diistanceToAttractionToolStripMenuItem.Name = "diistanceToAttractionToolStripMenuItem";
            this.diistanceToAttractionToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.diistanceToAttractionToolStripMenuItem.Text = "Diistance to Attraction";
            this.diistanceToAttractionToolStripMenuItem.Click += new System.EventHandler(this.diistanceToAttractionToolStripMenuItem_Click);
            // 
            // AddAndEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ShowPanel);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.Name = "AddAndEditForm";
            this.Size = new System.Drawing.Size(800, 500);
            this.Load += new System.EventHandler(this.AddAndEditForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Panel ShowPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listingDetallsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem amenitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diistanceToAttractionToolStripMenuItem;
    }
}
