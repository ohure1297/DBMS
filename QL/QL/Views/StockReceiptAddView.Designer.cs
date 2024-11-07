namespace QL.Views
{
    partial class StockReceiptAddView
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
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.lblImportDetails = new System.Windows.Forms.Label();
            this.dtpImportDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblImportDate = new System.Windows.Forms.Label();
            this.tbxId = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.tbxProductId = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblProductId = new System.Windows.Forms.Label();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.panelTop.Controls.Add(this.lblImportDetails);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(364, 100);
            this.panelTop.TabIndex = 16;
            // 
            // lblImportDetails
            // 
            this.lblImportDetails.AutoSize = true;
            this.lblImportDetails.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImportDetails.ForeColor = System.Drawing.Color.White;
            this.lblImportDetails.Location = new System.Drawing.Point(31, 27);
            this.lblImportDetails.Name = "lblImportDetails";
            this.lblImportDetails.Size = new System.Drawing.Size(183, 38);
            this.lblImportDetails.TabIndex = 1;
            this.lblImportDetails.Text = "ImportDetails";
            // 
            // dtpImportDate
            // 
            this.dtpImportDate.AutoRoundedCorners = true;
            this.dtpImportDate.BorderRadius = 17;
            this.dtpImportDate.Checked = true;
            this.dtpImportDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(207)))), ((int)(((byte)(211)))));
            this.dtpImportDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpImportDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpImportDate.Location = new System.Drawing.Point(56, 392);
            this.dtpImportDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpImportDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpImportDate.Name = "dtpImportDate";
            this.dtpImportDate.Size = new System.Drawing.Size(261, 36);
            this.dtpImportDate.TabIndex = 28;
            this.dtpImportDate.Value = new System.DateTime(2024, 10, 26, 11, 4, 6, 290);
            // 
            // lblImportDate
            // 
            this.lblImportDate.AutoSize = true;
            this.lblImportDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImportDate.Location = new System.Drawing.Point(54, 341);
            this.lblImportDate.Name = "lblImportDate";
            this.lblImportDate.Size = new System.Drawing.Size(111, 28);
            this.lblImportDate.TabIndex = 27;
            this.lblImportDate.Text = "Importdate";
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
            this.tbxId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxId.Location = new System.Drawing.Point(48, 154);
            this.tbxId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxId.Name = "tbxId";
            this.tbxId.PasswordChar = '\0';
            this.tbxId.PlaceholderText = "";
            this.tbxId.SelectedText = "";
            this.tbxId.Size = new System.Drawing.Size(229, 48);
            this.tbxId.TabIndex = 26;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(54, 112);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(29, 28);
            this.lblId.TabIndex = 25;
            this.lblId.Text = "Id";
            // 
            // tbxProductId
            // 
            this.tbxProductId.AutoRoundedCorners = true;
            this.tbxProductId.BorderRadius = 23;
            this.tbxProductId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxProductId.DefaultText = "";
            this.tbxProductId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxProductId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxProductId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxProductId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxProductId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxProductId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxProductId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxProductId.Location = new System.Drawing.Point(48, 268);
            this.tbxProductId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxProductId.Name = "tbxProductId";
            this.tbxProductId.PasswordChar = '\0';
            this.tbxProductId.PlaceholderText = "";
            this.tbxProductId.SelectedText = "";
            this.tbxProductId.Size = new System.Drawing.Size(229, 48);
            this.tbxProductId.TabIndex = 24;
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductId.Location = new System.Drawing.Point(54, 227);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(100, 28);
            this.lblProductId.TabIndex = 23;
            this.lblProductId.Text = "ProductID";
            // 
            // btnAdd
            // 
            this.btnAdd.AutoRoundedCorners = true;
            this.btnAdd.BorderRadius = 28;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(254)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(11, 457);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(143, 58);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add new";
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
            this.btnClose.Location = new System.Drawing.Point(200, 457);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(143, 58);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // StockReceiptAddView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(364, 541);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dtpImportDate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblImportDate);
            this.Controls.Add(this.tbxId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.tbxProductId);
            this.Controls.Add(this.lblProductId);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StockReceiptAddView";
            this.Text = "ImportAddForm";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelTop;
        private System.Windows.Forms.Label lblImportDetails;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpImportDate;
        private System.Windows.Forms.Label lblImportDate;
        private Guna.UI2.WinForms.Guna2TextBox tbxId;
        private System.Windows.Forms.Label lblId;
        private Guna.UI2.WinForms.Guna2TextBox tbxProductId;
        private System.Windows.Forms.Label lblProductId;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}