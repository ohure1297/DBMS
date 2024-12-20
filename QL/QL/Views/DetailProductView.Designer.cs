﻿namespace QL.Views
{
    partial class DetailProductView
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
            this.lblProductDetails = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.ptbProductImg = new Guna.UI2.WinForms.Guna2PictureBox();
            this.tbxSellPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSellPrice = new System.Windows.Forms.Label();
            this.tbxProvider = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblProvider = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.tbxName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxId = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btn_edit = new Guna.UI2.WinForms.Guna2Button();
            this.tbxQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProductImg)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.panelTop.Controls.Add(this.lblProductDetails);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1345, 136);
            this.panelTop.TabIndex = 86;
            // 
            // lblProductDetails
            // 
            this.lblProductDetails.AutoSize = true;
            this.lblProductDetails.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductDetails.ForeColor = System.Drawing.Color.White;
            this.lblProductDetails.Location = new System.Drawing.Point(17, 34);
            this.lblProductDetails.Name = "lblProductDetails";
            this.lblProductDetails.Size = new System.Drawing.Size(205, 38);
            this.lblProductDetails.TabIndex = 0;
            this.lblProductDetails.Text = "Product Details";
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
            this.btnClose.Location = new System.Drawing.Point(1086, 506);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(143, 58);
            this.btnClose.TabIndex = 98;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // ptbProductImg
            // 
            this.ptbProductImg.Enabled = false;
            this.ptbProductImg.ImageRotate = 0F;
            this.ptbProductImg.Location = new System.Drawing.Point(1069, 213);
            this.ptbProductImg.Name = "ptbProductImg";
            this.ptbProductImg.Size = new System.Drawing.Size(191, 168);
            this.ptbProductImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbProductImg.TabIndex = 97;
            this.ptbProductImg.TabStop = false;
            this.ptbProductImg.Click += new System.EventHandler(this.ptbProductImg_Click);
            // 
            // tbxSellPrice
            // 
            this.tbxSellPrice.AutoRoundedCorners = true;
            this.tbxSellPrice.BorderRadius = 23;
            this.tbxSellPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxSellPrice.DefaultText = "";
            this.tbxSellPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxSellPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxSellPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxSellPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxSellPrice.Enabled = false;
            this.tbxSellPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxSellPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxSellPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxSellPrice.Location = new System.Drawing.Point(741, 220);
            this.tbxSellPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxSellPrice.Name = "tbxSellPrice";
            this.tbxSellPrice.PasswordChar = '\0';
            this.tbxSellPrice.PlaceholderText = "";
            this.tbxSellPrice.SelectedText = "";
            this.tbxSellPrice.Size = new System.Drawing.Size(229, 48);
            this.tbxSellPrice.TabIndex = 96;
            // 
            // lblSellPrice
            // 
            this.lblSellPrice.AutoSize = true;
            this.lblSellPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellPrice.Location = new System.Drawing.Point(748, 173);
            this.lblSellPrice.Name = "lblSellPrice";
            this.lblSellPrice.Size = new System.Drawing.Size(91, 28);
            this.lblSellPrice.TabIndex = 95;
            this.lblSellPrice.Text = "Sell price";
            // 
            // tbxProvider
            // 
            this.tbxProvider.AutoRoundedCorners = true;
            this.tbxProvider.BorderRadius = 23;
            this.tbxProvider.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxProvider.DefaultText = "";
            this.tbxProvider.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxProvider.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxProvider.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxProvider.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxProvider.Enabled = false;
            this.tbxProvider.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxProvider.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxProvider.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxProvider.Location = new System.Drawing.Point(420, 354);
            this.tbxProvider.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxProvider.Name = "tbxProvider";
            this.tbxProvider.PasswordChar = '\0';
            this.tbxProvider.PlaceholderText = "";
            this.tbxProvider.SelectedText = "";
            this.tbxProvider.Size = new System.Drawing.Size(229, 48);
            this.tbxProvider.TabIndex = 94;
            // 
            // lblProvider
            // 
            this.lblProvider.AutoSize = true;
            this.lblProvider.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvider.Location = new System.Drawing.Point(427, 307);
            this.lblProvider.Name = "lblProvider";
            this.lblProvider.Size = new System.Drawing.Size(86, 28);
            this.lblProvider.TabIndex = 93;
            this.lblProvider.Text = "Provider";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(415, 175);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(92, 28);
            this.lblCategory.TabIndex = 91;
            this.lblCategory.Text = "Category";
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
            this.tbxName.Location = new System.Drawing.Point(53, 366);
            this.tbxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxName.Name = "tbxName";
            this.tbxName.PasswordChar = '\0';
            this.tbxName.PlaceholderText = "";
            this.tbxName.SelectedText = "";
            this.tbxName.Size = new System.Drawing.Size(229, 48);
            this.tbxName.TabIndex = 90;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(60, 307);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 28);
            this.lblName.TabIndex = 89;
            this.lblName.Text = "Name";
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
            this.tbxId.Location = new System.Drawing.Point(53, 213);
            this.tbxId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxId.Name = "tbxId";
            this.tbxId.PasswordChar = '\0';
            this.tbxId.PlaceholderText = "";
            this.tbxId.SelectedText = "";
            this.tbxId.Size = new System.Drawing.Size(229, 48);
            this.tbxId.TabIndex = 88;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(60, 166);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(29, 28);
            this.lblId.TabIndex = 87;
            this.lblId.Text = "Id";
            // 
            // btn_edit
            // 
            this.btn_edit.AutoRoundedCorners = true;
            this.btn_edit.BorderRadius = 28;
            this.btn_edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_edit.FillColor = System.Drawing.Color.SteelBlue;
            this.btn_edit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(892, 506);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(143, 58);
            this.btn_edit.TabIndex = 100;
            this.btn_edit.Text = "Edit";
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // tbxQuantity
            // 
            this.tbxQuantity.AutoRoundedCorners = true;
            this.tbxQuantity.BorderRadius = 23;
            this.tbxQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxQuantity.DefaultText = "";
            this.tbxQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxQuantity.Enabled = false;
            this.tbxQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxQuantity.Location = new System.Drawing.Point(741, 354);
            this.tbxQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.PasswordChar = '\0';
            this.tbxQuantity.PlaceholderText = "";
            this.tbxQuantity.SelectedText = "";
            this.tbxQuantity.Size = new System.Drawing.Size(229, 48);
            this.tbxQuantity.TabIndex = 102;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(748, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 28);
            this.label1.TabIndex = 101;
            this.label1.Text = "Quantity";
            // 
            // cbCategory
            // 
            this.cbCategory.AutoRoundedCorners = true;
            this.cbCategory.BackColor = System.Drawing.Color.Transparent;
            this.cbCategory.BorderRadius = 17;
            this.cbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCategory.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.cbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbCategory.ItemHeight = 30;
            this.cbCategory.Items.AddRange(new object[] {
            "Thực phẩm"});
            this.cbCategory.Location = new System.Drawing.Point(420, 220);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(198, 36);
            this.cbCategory.StartIndex = 0;
            this.cbCategory.TabIndex = 103;
            // 
            // DetailProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1345, 600);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.tbxQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ptbProductImg);
            this.Controls.Add(this.tbxSellPrice);
            this.Controls.Add(this.lblSellPrice);
            this.Controls.Add(this.tbxProvider);
            this.Controls.Add(this.lblProvider);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbxId);
            this.Controls.Add(this.lblId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetailProductView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductDetail";
            this.Load += new System.EventHandler(this.DetailProductView_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProductImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelTop;
        private System.Windows.Forms.Label lblProductDetails;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2PictureBox ptbProductImg;
        private Guna.UI2.WinForms.Guna2TextBox tbxSellPrice;
        private System.Windows.Forms.Label lblSellPrice;
        private Guna.UI2.WinForms.Guna2TextBox tbxProvider;
        private System.Windows.Forms.Label lblProvider;
        private System.Windows.Forms.Label lblCategory;
        private Guna.UI2.WinForms.Guna2TextBox tbxName;
        private System.Windows.Forms.Label lblName;
        private Guna.UI2.WinForms.Guna2TextBox tbxId;
        private System.Windows.Forms.Label lblId;
        private Guna.UI2.WinForms.Guna2Button btn_edit;
        private Guna.UI2.WinForms.Guna2TextBox tbxQuantity;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbCategory;
    }
}