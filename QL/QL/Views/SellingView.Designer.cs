namespace QL.Views
{
    partial class SellingView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelKhachHang = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lbFilter = new System.Windows.Forms.Label();
            this.cbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.tbx_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbxPoint = new Guna.UI2.WinForms.Guna2TextBox();
            this.AddNewButton_SellingView = new Guna.UI2.WinForms.Guna2Button();
            this.CheckButton_SellingView = new Guna.UI2.WinForms.Guna2Button();
            this.cbx_DungDiem = new Guna.UI2.WinForms.Guna2CheckBox();
            this.tbxCustomerName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPoint = new System.Windows.Forms.Label();
            this.tbxPhoneNum = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panelHoaDon = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvHoaDon = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPay = new Guna.UI2.WinForms.Guna2Button();
            this.flowPanelSanPham = new System.Windows.Forms.FlowLayoutPanel();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.panelKhachHang.SuspendLayout();
            this.panelHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelKhachHang
            // 
            this.panelKhachHang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.panelKhachHang.BorderRadius = 5;
            this.panelKhachHang.BorderThickness = 2;
            this.panelKhachHang.Controls.Add(this.lblThongBao);
            this.panelKhachHang.Controls.Add(this.lblSearch);
            this.panelKhachHang.Controls.Add(this.lbFilter);
            this.panelKhachHang.Controls.Add(this.cbFilter);
            this.panelKhachHang.Controls.Add(this.btnSearch);
            this.panelKhachHang.Controls.Add(this.tbx_Search);
            this.panelKhachHang.Controls.Add(this.tbxPoint);
            this.panelKhachHang.Controls.Add(this.AddNewButton_SellingView);
            this.panelKhachHang.Controls.Add(this.CheckButton_SellingView);
            this.panelKhachHang.Controls.Add(this.cbx_DungDiem);
            this.panelKhachHang.Controls.Add(this.tbxCustomerName);
            this.panelKhachHang.Controls.Add(this.lblPoint);
            this.panelKhachHang.Controls.Add(this.tbxPhoneNum);
            this.panelKhachHang.Controls.Add(this.lblPhoneNum);
            this.panelKhachHang.Controls.Add(this.lblName);
            this.panelKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelKhachHang.Location = new System.Drawing.Point(0, 0);
            this.panelKhachHang.Name = "panelKhachHang";
            this.panelKhachHang.Size = new System.Drawing.Size(1439, 160);
            this.panelKhachHang.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(17, 24);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(75, 28);
            this.lblSearch.TabIndex = 67;
            this.lblSearch.Text = "Search";
            // 
            // lbFilter
            // 
            this.lbFilter.AutoSize = true;
            this.lbFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilter.Location = new System.Drawing.Point(17, 113);
            this.lbFilter.Name = "lbFilter";
            this.lbFilter.Size = new System.Drawing.Size(90, 28);
            this.lbFilter.TabIndex = 66;
            this.lbFilter.Text = "Filter by";
            // 
            // cbFilter
            // 
            this.cbFilter.BackColor = System.Drawing.Color.Transparent;
            this.cbFilter.BorderRadius = 15;
            this.cbFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFilter.ItemHeight = 30;
            this.cbFilter.Items.AddRange(new object[] {
            "Mã SP",
            "Tên SP",
            "Cao đến thấp",
            "Thấp đến cao",
            "Nhà sản xuất"});
            this.cbFilter.Location = new System.Drawing.Point(147, 108);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(187, 36);
            this.cbFilter.StartIndex = 1;
            this.cbFilter.TabIndex = 65;
            // 
            // btnSearch
            // 
            this.btnSearch.BorderRadius = 20;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(464, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(131, 40);
            this.btnSearch.TabIndex = 64;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbx_Search
            // 
            this.tbx_Search.AutoRoundedCorners = true;
            this.tbx_Search.BorderRadius = 24;
            this.tbx_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbx_Search.DefaultText = "";
            this.tbx_Search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbx_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbx_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbx_Search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbx_Search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbx_Search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbx_Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbx_Search.Location = new System.Drawing.Point(136, 19);
            this.tbx_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_Search.Name = "tbx_Search";
            this.tbx_Search.PasswordChar = '\0';
            this.tbx_Search.PlaceholderText = "";
            this.tbx_Search.SelectedText = "";
            this.tbx_Search.Size = new System.Drawing.Size(307, 51);
            this.tbx_Search.TabIndex = 63;
            // 
            // tbxPoint
            // 
            this.tbxPoint.AutoRoundedCorners = true;
            this.tbxPoint.BorderRadius = 16;
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
            this.tbxPoint.Location = new System.Drawing.Point(696, 113);
            this.tbxPoint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxPoint.Name = "tbxPoint";
            this.tbxPoint.PasswordChar = '\0';
            this.tbxPoint.PlaceholderText = "";
            this.tbxPoint.SelectedText = "";
            this.tbxPoint.Size = new System.Drawing.Size(229, 35);
            this.tbxPoint.TabIndex = 62;
            // 
            // AddNewButton_SellingView
            // 
            this.AddNewButton_SellingView.BorderRadius = 20;
            this.AddNewButton_SellingView.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddNewButton_SellingView.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddNewButton_SellingView.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddNewButton_SellingView.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddNewButton_SellingView.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewButton_SellingView.ForeColor = System.Drawing.Color.White;
            this.AddNewButton_SellingView.Location = new System.Drawing.Point(1274, 108);
            this.AddNewButton_SellingView.Name = "AddNewButton_SellingView";
            this.AddNewButton_SellingView.Size = new System.Drawing.Size(131, 40);
            this.AddNewButton_SellingView.TabIndex = 61;
            this.AddNewButton_SellingView.Text = "Add New";
            // 
            // CheckButton_SellingView
            // 
            this.CheckButton_SellingView.BorderRadius = 20;
            this.CheckButton_SellingView.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CheckButton_SellingView.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CheckButton_SellingView.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CheckButton_SellingView.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CheckButton_SellingView.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckButton_SellingView.ForeColor = System.Drawing.Color.White;
            this.CheckButton_SellingView.Location = new System.Drawing.Point(1274, 40);
            this.CheckButton_SellingView.Name = "CheckButton_SellingView";
            this.CheckButton_SellingView.Size = new System.Drawing.Size(131, 40);
            this.CheckButton_SellingView.TabIndex = 60;
            this.CheckButton_SellingView.Text = "Check";
            this.CheckButton_SellingView.Click += new System.EventHandler(this.CheckButton_SellingView_Click);
            // 
            // cbx_DungDiem
            // 
            this.cbx_DungDiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.cbx_DungDiem.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbx_DungDiem.CheckedState.BorderRadius = 0;
            this.cbx_DungDiem.CheckedState.BorderThickness = 0;
            this.cbx_DungDiem.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbx_DungDiem.CheckMarkColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbx_DungDiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_DungDiem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbx_DungDiem.Location = new System.Drawing.Point(1025, 109);
            this.cbx_DungDiem.Name = "cbx_DungDiem";
            this.cbx_DungDiem.Size = new System.Drawing.Size(144, 35);
            this.cbx_DungDiem.TabIndex = 59;
            this.cbx_DungDiem.Text = "Use points";
            this.cbx_DungDiem.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbx_DungDiem.UncheckedState.BorderRadius = 0;
            this.cbx_DungDiem.UncheckedState.BorderThickness = 0;
            this.cbx_DungDiem.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbx_DungDiem.UseVisualStyleBackColor = false;
            // 
            // tbxCustomerName
            // 
            this.tbxCustomerName.AutoRoundedCorners = true;
            this.tbxCustomerName.BorderRadius = 16;
            this.tbxCustomerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxCustomerName.DefaultText = "";
            this.tbxCustomerName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxCustomerName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxCustomerName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxCustomerName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxCustomerName.Enabled = false;
            this.tbxCustomerName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxCustomerName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxCustomerName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxCustomerName.Location = new System.Drawing.Point(696, 40);
            this.tbxCustomerName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxCustomerName.Name = "tbxCustomerName";
            this.tbxCustomerName.PasswordChar = '\0';
            this.tbxCustomerName.PlaceholderText = "";
            this.tbxCustomerName.SelectedText = "";
            this.tbxCustomerName.Size = new System.Drawing.Size(229, 35);
            this.tbxCustomerName.TabIndex = 58;
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoint.Location = new System.Drawing.Point(700, 78);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(159, 28);
            this.lblPoint.TabIndex = 57;
            this.lblPoint.Text = "Remaining Point ";
            // 
            // tbxPhoneNum
            // 
            this.tbxPhoneNum.AutoRoundedCorners = true;
            this.tbxPhoneNum.BorderRadius = 16;
            this.tbxPhoneNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxPhoneNum.DefaultText = "";
            this.tbxPhoneNum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxPhoneNum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxPhoneNum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxPhoneNum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxPhoneNum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxPhoneNum.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxPhoneNum.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxPhoneNum.Location = new System.Drawing.Point(1012, 40);
            this.tbxPhoneNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxPhoneNum.Name = "tbxPhoneNum";
            this.tbxPhoneNum.PasswordChar = '\0';
            this.tbxPhoneNum.PlaceholderText = "";
            this.tbxPhoneNum.SelectedText = "";
            this.tbxPhoneNum.Size = new System.Drawing.Size(229, 35);
            this.tbxPhoneNum.TabIndex = 56;
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNum.Location = new System.Drawing.Point(1007, 8);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(140, 28);
            this.lblPhoneNum.TabIndex = 55;
            this.lblPhoneNum.Text = "Phone number";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(691, 8);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(153, 28);
            this.lblName.TabIndex = 53;
            this.lblName.Text = "Customer Name";
            // 
            // panelHoaDon
            // 
            this.panelHoaDon.Controls.Add(this.dgvHoaDon);
            this.panelHoaDon.Controls.Add(this.btnPay);
            this.panelHoaDon.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelHoaDon.Location = new System.Drawing.Point(819, 160);
            this.panelHoaDon.Name = "panelHoaDon";
            this.panelHoaDon.Size = new System.Drawing.Size(620, 530);
            this.panelHoaDon.TabIndex = 2;
            // 
            // dgvHoaDon
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvHoaDon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvHoaDon.ColumnHeadersHeight = 50;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ProductName,
            this.Qty,
            this.Price,
            this.Total});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHoaDon.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHoaDon.Location = new System.Drawing.Point(0, 0);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersVisible = false;
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.Size = new System.Drawing.Size(620, 479);
            this.dgvHoaDon.TabIndex = 64;
            this.dgvHoaDon.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHoaDon.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvHoaDon.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvHoaDon.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvHoaDon.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvHoaDon.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvHoaDon.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHoaDon.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvHoaDon.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHoaDon.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHoaDon.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvHoaDon.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvHoaDon.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvHoaDon.ThemeStyle.ReadOnly = false;
            this.dgvHoaDon.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHoaDon.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHoaDon.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHoaDon.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvHoaDon.ThemeStyle.RowsStyle.Height = 24;
            this.dgvHoaDon.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHoaDon.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Name";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.MinimumWidth = 6;
            this.Qty.Name = "Qty";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            // 
            // btnPay
            // 
            this.btnPay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPay.FillColor = System.Drawing.Color.YellowGreen;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(0, 479);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(620, 51);
            this.btnPay.TabIndex = 63;
            this.btnPay.Text = "Pay";
            // 
            // flowPanelSanPham
            // 
            this.flowPanelSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanelSanPham.Location = new System.Drawing.Point(0, 160);
            this.flowPanelSanPham.Name = "flowPanelSanPham";
            this.flowPanelSanPham.Size = new System.Drawing.Size(819, 530);
            this.flowPanelSanPham.TabIndex = 3;
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongBao.Location = new System.Drawing.Point(1022, 79);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(15, 17);
            this.lblThongBao.TabIndex = 68;
            this.lblThongBao.Text = "a";
            // 
            // SellingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1449, 690);
            this.Controls.Add(this.flowPanelSanPham);
            this.Controls.Add(this.panelHoaDon);
            this.Controls.Add(this.panelKhachHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellingView";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.Text = "SellingForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SellingView_Load);
            this.panelKhachHang.ResumeLayout(false);
            this.panelKhachHang.PerformLayout();
            this.panelHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel panelKhachHang;
        private Guna.UI2.WinForms.Guna2TextBox tbxPoint;
        private Guna.UI2.WinForms.Guna2Button AddNewButton_SellingView;
        private Guna.UI2.WinForms.Guna2Button CheckButton_SellingView;
        private Guna.UI2.WinForms.Guna2CheckBox cbx_DungDiem;
        private Guna.UI2.WinForms.Guna2TextBox tbxCustomerName;
        private System.Windows.Forms.Label lblPoint;
        private Guna.UI2.WinForms.Guna2TextBox tbxPhoneNum;
        private System.Windows.Forms.Label lblPhoneNum;
        private System.Windows.Forms.Label lblName;
        private Guna.UI2.WinForms.Guna2Panel panelHoaDon;
        private Guna.UI2.WinForms.Guna2DataGridView dgvHoaDon;
        private Guna.UI2.WinForms.Guna2Button btnPay;
        private System.Windows.Forms.FlowLayoutPanel flowPanelSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox tbx_Search;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilter;
        private System.Windows.Forms.Label lbFilter;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblThongBao;
    }
}