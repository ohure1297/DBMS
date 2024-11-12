namespace QL.Views
{
    partial class CustomerDetailView
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
            this.lblEmployeeDatails = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.tbxName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.tbxSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.tbxPoint = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.panelTop.Controls.Add(this.lblEmployeeDatails);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 136);
            this.panelTop.TabIndex = 91;
            // 
            // lblEmployeeDatails
            // 
            this.lblEmployeeDatails.AutoSize = true;
            this.lblEmployeeDatails.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeDatails.ForeColor = System.Drawing.Color.White;
            this.lblEmployeeDatails.Location = new System.Drawing.Point(21, 49);
            this.lblEmployeeDatails.Name = "lblEmployeeDatails";
            this.lblEmployeeDatails.Size = new System.Drawing.Size(136, 38);
            this.lblEmployeeDatails.TabIndex = 0;
            this.lblEmployeeDatails.Text = "Customer";
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
            this.btnClose.Location = new System.Drawing.Point(574, 435);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(143, 58);
            this.btnClose.TabIndex = 109;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.tbxName.Enabled = false;
            this.tbxName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxName.Location = new System.Drawing.Point(488, 217);
            this.tbxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxName.Name = "tbxName";
            this.tbxName.PasswordChar = '\0';
            this.tbxName.PlaceholderText = "";
            this.tbxName.SelectedText = "";
            this.tbxName.Size = new System.Drawing.Size(229, 48);
            this.tbxName.TabIndex = 108;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(483, 171);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 28);
            this.lblName.TabIndex = 107;
            this.lblName.Text = "Name";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.Location = new System.Drawing.Point(90, 171);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(46, 28);
            this.lblSDT.TabIndex = 105;
            this.lblSDT.Text = "SDT";
            // 
            // tbxSDT
            // 
            this.tbxSDT.AutoRoundedCorners = true;
            this.tbxSDT.BorderRadius = 23;
            this.tbxSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxSDT.DefaultText = "";
            this.tbxSDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxSDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxSDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxSDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxSDT.Enabled = false;
            this.tbxSDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxSDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxSDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxSDT.Location = new System.Drawing.Point(95, 217);
            this.tbxSDT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxSDT.Name = "tbxSDT";
            this.tbxSDT.PasswordChar = '\0';
            this.tbxSDT.PlaceholderText = "";
            this.tbxSDT.SelectedText = "";
            this.tbxSDT.Size = new System.Drawing.Size(229, 48);
            this.tbxSDT.TabIndex = 106;
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
            this.btnEdit.Location = new System.Drawing.Point(130, 435);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(143, 58);
            this.btnEdit.TabIndex = 110;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tbxPoint
            // 
            this.tbxPoint.AutoRoundedCorners = true;
            this.tbxPoint.BorderRadius = 23;
            this.tbxPoint.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxPoint.DefaultText = "";
            this.tbxPoint.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxPoint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxPoint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxPoint.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxPoint.Enabled = false;
            this.tbxPoint.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxPoint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxPoint.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxPoint.Location = new System.Drawing.Point(95, 354);
            this.tbxPoint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxPoint.Name = "tbxPoint";
            this.tbxPoint.PasswordChar = '\0';
            this.tbxPoint.PlaceholderText = "";
            this.tbxPoint.SelectedText = "";
            this.tbxPoint.Size = new System.Drawing.Size(229, 48);
            this.tbxPoint.TabIndex = 112;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 28);
            this.label1.TabIndex = 111;
            this.label1.Text = "Point";
            // 
            // CustomerDetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 537);
            this.Controls.Add(this.tbxPoint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.tbxSDT);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerDetailView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerDetailView";
            this.Load += new System.EventHandler(this.CustomerDetailView_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelTop;
        private System.Windows.Forms.Label lblEmployeeDatails;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2TextBox tbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSDT;
        private Guna.UI2.WinForms.Guna2TextBox tbxSDT;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2TextBox tbxPoint;
        private System.Windows.Forms.Label label1;
    }
}