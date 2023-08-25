namespace System
{
    partial class CreateAccountForm
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
            this.InformationGroupBox = new System.Windows.Forms.GroupBox();
            this.UELALinkLabel = new System.Windows.Forms.LinkLabel();
            this.AgreeUELACheckBox = new System.Windows.Forms.CheckBox();
            this.FamilyNumberNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.FemaleRadioButton = new System.Windows.Forms.RadioButton();
            this.MaleRadioButton = new System.Windows.Forms.RadioButton();
            this.RetypePasswordTextbox = new System.Windows.Forms.TextBox();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.FullNameTextbox = new System.Windows.Forms.TextBox();
            this.UsernameTextbox = new System.Windows.Forms.TextBox();
            this.RetypePasswordLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.BirthdayLabel = new System.Windows.Forms.Label();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.BaclLoginBtn = new System.Windows.Forms.Button();
            this.InformationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FamilyNumberNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // InformationGroupBox
            // 
            this.InformationGroupBox.Controls.Add(this.UELALinkLabel);
            this.InformationGroupBox.Controls.Add(this.AgreeUELACheckBox);
            this.InformationGroupBox.Controls.Add(this.FamilyNumberNumericUpDown);
            this.InformationGroupBox.Controls.Add(this.label1);
            this.InformationGroupBox.Controls.Add(this.DatePicker);
            this.InformationGroupBox.Controls.Add(this.FemaleRadioButton);
            this.InformationGroupBox.Controls.Add(this.MaleRadioButton);
            this.InformationGroupBox.Controls.Add(this.RetypePasswordTextbox);
            this.InformationGroupBox.Controls.Add(this.PasswordTextbox);
            this.InformationGroupBox.Controls.Add(this.FullNameTextbox);
            this.InformationGroupBox.Controls.Add(this.UsernameTextbox);
            this.InformationGroupBox.Controls.Add(this.RetypePasswordLabel);
            this.InformationGroupBox.Controls.Add(this.PasswordLabel);
            this.InformationGroupBox.Controls.Add(this.BirthdayLabel);
            this.InformationGroupBox.Controls.Add(this.FullNameLabel);
            this.InformationGroupBox.Controls.Add(this.UsernameLabel);
            this.InformationGroupBox.Location = new System.Drawing.Point(3, 3);
            this.InformationGroupBox.Name = "InformationGroupBox";
            this.InformationGroupBox.Size = new System.Drawing.Size(790, 371);
            this.InformationGroupBox.TabIndex = 0;
            this.InformationGroupBox.TabStop = false;
            this.InformationGroupBox.Text = "Your Information";
            // 
            // UELALinkLabel
            // 
            this.UELALinkLabel.AutoSize = true;
            this.UELALinkLabel.Location = new System.Drawing.Point(560, 335);
            this.UELALinkLabel.Name = "UELALinkLabel";
            this.UELALinkLabel.Size = new System.Drawing.Size(185, 17);
            this.UELALinkLabel.TabIndex = 17;
            this.UELALinkLabel.TabStop = true;
            this.UELALinkLabel.Text = "View Terms and Conditions";
            this.UELALinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.UELALinkLabel_LinkClicked);
            // 
            // AgreeUELACheckBox
            // 
            this.AgreeUELACheckBox.AutoSize = true;
            this.AgreeUELACheckBox.Enabled = false;
            this.AgreeUELACheckBox.Location = new System.Drawing.Point(45, 331);
            this.AgreeUELACheckBox.Name = "AgreeUELACheckBox";
            this.AgreeUELACheckBox.Size = new System.Drawing.Size(260, 21);
            this.AgreeUELACheckBox.TabIndex = 16;
            this.AgreeUELACheckBox.Text = "I agree to the Terms and Conditions";
            this.AgreeUELACheckBox.UseVisualStyleBackColor = true;
            // 
            // FamilyNumberNumericUpDown
            // 
            this.FamilyNumberNumericUpDown.Location = new System.Drawing.Point(588, 184);
            this.FamilyNumberNumericUpDown.Name = "FamilyNumberNumericUpDown";
            this.FamilyNumberNumericUpDown.Size = new System.Drawing.Size(85, 25);
            this.FamilyNumberNumericUpDown.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(390, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Number of Family Members:";
            // 
            // DatePicker
            // 
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePicker.Location = new System.Drawing.Point(229, 207);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(152, 25);
            this.DatePicker.TabIndex = 12;
            this.DatePicker.Value = new System.DateTime(2023, 8, 25, 15, 5, 43, 0);
            // 
            // FemaleRadioButton
            // 
            this.FemaleRadioButton.AutoSize = true;
            this.FemaleRadioButton.Location = new System.Drawing.Point(521, 146);
            this.FemaleRadioButton.Name = "FemaleRadioButton";
            this.FemaleRadioButton.Size = new System.Drawing.Size(78, 21);
            this.FemaleRadioButton.TabIndex = 11;
            this.FemaleRadioButton.TabStop = true;
            this.FemaleRadioButton.Text = "Female";
            this.FemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // MaleRadioButton
            // 
            this.MaleRadioButton.AutoSize = true;
            this.MaleRadioButton.Location = new System.Drawing.Point(459, 148);
            this.MaleRadioButton.Name = "MaleRadioButton";
            this.MaleRadioButton.Size = new System.Drawing.Size(59, 21);
            this.MaleRadioButton.TabIndex = 10;
            this.MaleRadioButton.TabStop = true;
            this.MaleRadioButton.Text = "Male";
            this.MaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // RetypePasswordTextbox
            // 
            this.RetypePasswordTextbox.Location = new System.Drawing.Point(521, 241);
            this.RetypePasswordTextbox.Name = "RetypePasswordTextbox";
            this.RetypePasswordTextbox.Size = new System.Drawing.Size(152, 25);
            this.RetypePasswordTextbox.TabIndex = 9;
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Location = new System.Drawing.Point(229, 238);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(152, 25);
            this.PasswordTextbox.TabIndex = 8;
            // 
            // FullNameTextbox
            // 
            this.FullNameTextbox.Location = new System.Drawing.Point(229, 177);
            this.FullNameTextbox.Name = "FullNameTextbox";
            this.FullNameTextbox.Size = new System.Drawing.Size(152, 25);
            this.FullNameTextbox.TabIndex = 6;
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.Location = new System.Drawing.Point(229, 150);
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.Size = new System.Drawing.Size(152, 25);
            this.UsernameTextbox.TabIndex = 5;
            // 
            // RetypePasswordLabel
            // 
            this.RetypePasswordLabel.AutoSize = true;
            this.RetypePasswordLabel.Location = new System.Drawing.Point(387, 241);
            this.RetypePasswordLabel.Name = "RetypePasswordLabel";
            this.RetypePasswordLabel.Size = new System.Drawing.Size(128, 17);
            this.RetypePasswordLabel.TabIndex = 4;
            this.RetypePasswordLabel.Text = "Retype Password:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(113, 236);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(78, 17);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Password:";
            // 
            // BirthdayLabel
            // 
            this.BirthdayLabel.AutoSize = true;
            this.BirthdayLabel.Location = new System.Drawing.Point(113, 210);
            this.BirthdayLabel.Name = "BirthdayLabel";
            this.BirthdayLabel.Size = new System.Drawing.Size(65, 17);
            this.BirthdayLabel.TabIndex = 2;
            this.BirthdayLabel.Text = "Birthday:";
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(113, 177);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(78, 17);
            this.FullNameLabel.TabIndex = 1;
            this.FullNameLabel.Text = "Full Name:";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(113, 150);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(80, 17);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "Username:";
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Font = new System.Drawing.Font("Arial", 9F);
            this.RegisterBtn.Location = new System.Drawing.Point(427, 380);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(133, 38);
            this.RegisterBtn.TabIndex = 1;
            this.RegisterBtn.Text = "Register && login";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            // 
            // BaclLoginBtn
            // 
            this.BaclLoginBtn.Font = new System.Drawing.Font("Arial", 9F);
            this.BaclLoginBtn.Location = new System.Drawing.Point(566, 380);
            this.BaclLoginBtn.Name = "BaclLoginBtn";
            this.BaclLoginBtn.Size = new System.Drawing.Size(133, 38);
            this.BaclLoginBtn.TabIndex = 2;
            this.BaclLoginBtn.Text = "Return login form";
            this.BaclLoginBtn.UseVisualStyleBackColor = true;
            this.BaclLoginBtn.Click += new System.EventHandler(this.BaclLoginBtn_Click);
            // 
            // CreateAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BaclLoginBtn);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.InformationGroupBox);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.Name = "CreateAccountForm";
            this.Size = new System.Drawing.Size(800, 500);
            this.InformationGroupBox.ResumeLayout(false);
            this.InformationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FamilyNumberNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Windows.Forms.GroupBox InformationGroupBox;
        private Windows.Forms.Label RetypePasswordLabel;
        private Windows.Forms.Label PasswordLabel;
        private Windows.Forms.Label BirthdayLabel;
        private Windows.Forms.Label FullNameLabel;
        private Windows.Forms.Label UsernameLabel;
        private Windows.Forms.DateTimePicker DatePicker;
        private Windows.Forms.RadioButton FemaleRadioButton;
        private Windows.Forms.RadioButton MaleRadioButton;
        private Windows.Forms.TextBox RetypePasswordTextbox;
        private Windows.Forms.TextBox PasswordTextbox;
        private Windows.Forms.TextBox FullNameTextbox;
        private Windows.Forms.TextBox UsernameTextbox;
        private Windows.Forms.Label label1;
        private Windows.Forms.NumericUpDown FamilyNumberNumericUpDown;
        private Windows.Forms.LinkLabel UELALinkLabel;
        private Windows.Forms.CheckBox AgreeUELACheckBox;
        private Windows.Forms.Button RegisterBtn;
        private Windows.Forms.Button BaclLoginBtn;
    }
}
