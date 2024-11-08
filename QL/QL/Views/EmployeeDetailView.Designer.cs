namespace QL.Views
{
    partial class EmployeeDetailView
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
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.lblGender = new System.Windows.Forms.Label();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.radiobtnFemale = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radiobtnMale = new Guna.UI2.WinForms.Guna2RadioButton();
            this.dtpHireDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblHireDate = new System.Windows.Forms.Label();
            this.dtpBirthDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.tbxAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.tbxName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.lblEmployeeDatails = new System.Windows.Forms.Label();
            this.ptbAvatar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.tbxId = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.AutoRoundedCorners = true;
            this.btnClose.BorderRadius = 28;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Crimson;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(796, 536);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(143, 58);
            this.btnClose.TabIndex = 88;
            this.btnClose.Text = "Close";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(429, 299);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(76, 28);
            this.lblGender.TabIndex = 108;
            this.lblGender.Text = "Gender";
            // 
            // btnEdit
            // 
            this.btnEdit.AutoRoundedCorners = true;
            this.btnEdit.BorderRadius = 28;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(254)))));
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(48, 536);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(143, 58);
            this.btnEdit.TabIndex = 87;
            this.btnEdit.Text = "Edit";
            // 
            // radiobtnFemale
            // 
            this.radiobtnFemale.AutoSize = true;
            this.radiobtnFemale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radiobtnFemale.CheckedState.BorderThickness = 0;
            this.radiobtnFemale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radiobtnFemale.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radiobtnFemale.CheckedState.InnerOffset = -4;
            this.radiobtnFemale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnFemale.Location = new System.Drawing.Point(563, 354);
            this.radiobtnFemale.Name = "radiobtnFemale";
            this.radiobtnFemale.Size = new System.Drawing.Size(100, 32);
            this.radiobtnFemale.TabIndex = 107;
            this.radiobtnFemale.Text = "Female";
            this.radiobtnFemale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radiobtnFemale.UncheckedState.BorderThickness = 2;
            this.radiobtnFemale.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radiobtnFemale.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // radiobtnMale
            // 
            this.radiobtnMale.AutoSize = true;
            this.radiobtnMale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radiobtnMale.CheckedState.BorderThickness = 0;
            this.radiobtnMale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radiobtnMale.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radiobtnMale.CheckedState.InnerOffset = -4;
            this.radiobtnMale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnMale.Location = new System.Drawing.Point(434, 354);
            this.radiobtnMale.Name = "radiobtnMale";
            this.radiobtnMale.Size = new System.Drawing.Size(80, 32);
            this.radiobtnMale.TabIndex = 106;
            this.radiobtnMale.Text = "Male";
            this.radiobtnMale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radiobtnMale.UncheckedState.BorderThickness = 2;
            this.radiobtnMale.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radiobtnMale.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.AutoRoundedCorners = true;
            this.dtpHireDate.BorderRadius = 17;
            this.dtpHireDate.Checked = true;
            this.dtpHireDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(207)))), ((int)(((byte)(211)))));
            this.dtpHireDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpHireDate.Location = new System.Drawing.Point(424, 466);
            this.dtpHireDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpHireDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(257, 36);
            this.dtpHireDate.TabIndex = 105;
            this.dtpHireDate.Value = new System.DateTime(2024, 10, 28, 0, 4, 10, 708);
            // 
            // lblHireDate
            // 
            this.lblHireDate.AutoSize = true;
            this.lblHireDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHireDate.Location = new System.Drawing.Point(429, 424);
            this.lblHireDate.Name = "lblHireDate";
            this.lblHireDate.Size = new System.Drawing.Size(87, 28);
            this.lblHireDate.TabIndex = 104;
            this.lblHireDate.Text = "Hiredate";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.AutoRoundedCorners = true;
            this.dtpBirthDate.BorderRadius = 17;
            this.dtpBirthDate.Checked = true;
            this.dtpBirthDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(207)))), ((int)(((byte)(211)))));
            this.dtpBirthDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpBirthDate.Location = new System.Drawing.Point(48, 466);
            this.dtpBirthDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpBirthDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(239, 36);
            this.dtpBirthDate.TabIndex = 103;
            this.dtpBirthDate.Value = new System.DateTime(2024, 10, 28, 0, 4, 10, 708);
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthDate.Location = new System.Drawing.Point(43, 424);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(92, 28);
            this.lblBirthDate.TabIndex = 102;
            this.lblBirthDate.Text = "Birthdate";
            // 
            // tbxAddress
            // 
            this.tbxAddress.AutoRoundedCorners = true;
            this.tbxAddress.BorderRadius = 23;
            this.tbxAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxAddress.DefaultText = "";
            this.tbxAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxAddress.Enabled = false;
            this.tbxAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxAddress.Location = new System.Drawing.Point(48, 333);
            this.tbxAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.PasswordChar = '\0';
            this.tbxAddress.PlaceholderText = "";
            this.tbxAddress.SelectedText = "";
            this.tbxAddress.Size = new System.Drawing.Size(229, 48);
            this.tbxAddress.TabIndex = 101;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(43, 283);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(82, 28);
            this.lblAddress.TabIndex = 100;
            this.lblAddress.Text = "Address";
            // 
            // tbxName
            // 
            this.tbxName.AutoRoundedCorners = true;
            this.tbxName.BorderRadius = 23;
            this.tbxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxName.DefaultText = "";
            this.tbxName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxName.Location = new System.Drawing.Point(434, 205);
            this.tbxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxName.Name = "tbxName";
            this.tbxName.PasswordChar = '\0';
            this.tbxName.PlaceholderText = "";
            this.tbxName.SelectedText = "";
            this.tbxName.Size = new System.Drawing.Size(229, 48);
            this.tbxName.TabIndex = 99;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(429, 159);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 28);
            this.lblName.TabIndex = 98;
            this.lblName.Text = "Name";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(43, 159);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(29, 28);
            this.lblId.TabIndex = 93;
            this.lblId.Text = "Id";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.panelTop.Controls.Add(this.lblEmployeeDatails);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1034, 136);
            this.panelTop.TabIndex = 89;
            // 
            // lblEmployeeDatails
            // 
            this.lblEmployeeDatails.AutoSize = true;
            this.lblEmployeeDatails.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeDatails.ForeColor = System.Drawing.Color.White;
            this.lblEmployeeDatails.Location = new System.Drawing.Point(21, 49);
            this.lblEmployeeDatails.Name = "lblEmployeeDatails";
            this.lblEmployeeDatails.Size = new System.Drawing.Size(230, 38);
            this.lblEmployeeDatails.TabIndex = 0;
            this.lblEmployeeDatails.Text = "Employee Details";
            // 
            // ptbAvatar
            // 
            this.ptbAvatar.ImageRotate = 0F;
            this.ptbAvatar.Location = new System.Drawing.Point(754, 205);
            this.ptbAvatar.Name = "ptbAvatar";
            this.ptbAvatar.Size = new System.Drawing.Size(235, 247);
            this.ptbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAvatar.TabIndex = 95;
            this.ptbAvatar.TabStop = false;
            // 
            // tbxId
            // 
            this.tbxId.AutoRoundedCorners = true;
            this.tbxId.BorderRadius = 23;
            this.tbxId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxId.DefaultText = "";
            this.tbxId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxId.Enabled = false;
            this.tbxId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxId.Location = new System.Drawing.Point(48, 205);
            this.tbxId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxId.Name = "tbxId";
            this.tbxId.PasswordChar = '\0';
            this.tbxId.PlaceholderText = "";
            this.tbxId.SelectedText = "";
            this.tbxId.Size = new System.Drawing.Size(229, 48);
            this.tbxId.TabIndex = 94;
            // 
            // EmployeeDetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1034, 621);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.radiobtnFemale);
            this.Controls.Add(this.radiobtnMale);
            this.Controls.Add(this.dtpHireDate);
            this.Controls.Add(this.lblHireDate);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.tbxAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.ptbAvatar);
            this.Controls.Add(this.tbxId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeDetailView";
            this.Text = "EmployeeDetailView";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Label lblGender;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2RadioButton radiobtnFemale;
        private Guna.UI2.WinForms.Guna2RadioButton radiobtnMale;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpHireDate;
        private System.Windows.Forms.Label lblHireDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Label lblBirthDate;
        private Guna.UI2.WinForms.Guna2TextBox tbxAddress;
        private System.Windows.Forms.Label lblAddress;
        private Guna.UI2.WinForms.Guna2TextBox tbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblId;
        private Guna.UI2.WinForms.Guna2Panel panelTop;
        private System.Windows.Forms.Label lblEmployeeDatails;
        private Guna.UI2.WinForms.Guna2PictureBox ptbAvatar;
        private Guna.UI2.WinForms.Guna2TextBox tbxId;
    }
}