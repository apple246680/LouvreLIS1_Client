namespace LouvreLIS_Client
{
    partial class PreviewTicketForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreviewTicketForm));
            this.SavePDFBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SavePDFBtn
            // 
            this.SavePDFBtn.Location = new System.Drawing.Point(12, 3);
            this.SavePDFBtn.Name = "SavePDFBtn";
            this.SavePDFBtn.Size = new System.Drawing.Size(477, 46);
            this.SavePDFBtn.TabIndex = 0;
            this.SavePDFBtn.Text = "Save as PDF";
            this.SavePDFBtn.UseVisualStyleBackColor = true;
            this.SavePDFBtn.Click += new System.EventHandler(this.SavePDFBtn_Click);
            // 
            // PreviewTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 683);
            this.Controls.Add(this.SavePDFBtn);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PreviewTicketForm";
            this.Text = "Preview Ticket";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SavePDFBtn;
    }
}