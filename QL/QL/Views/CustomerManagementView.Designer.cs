namespace QL.Views
{
    partial class CustomerManagementView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Searchbutton_CustomerManagement = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAdd_CustomerManagement = new Guna.UI2.WinForms.Guna2Button();
            this.CustomerManagementLabel = new System.Windows.Forms.Label();
            this.CustomerList_CusManagement = new Guna.UI2.WinForms.Guna2DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerPhoneNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteButton_CustomerManagement = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EditButton_CustomerManagement = new System.Windows.Forms.DataGridViewButtonColumn();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerList_CusManagement)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.Searchbutton_CustomerManagement);
            this.guna2Panel1.Controls.Add(this.guna2TextBox1);
            this.guna2Panel1.Controls.Add(this.btnAdd_CustomerManagement);
            this.guna2Panel1.Controls.Add(this.CustomerManagementLabel);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1647, 128);
            this.guna2Panel1.TabIndex = 5;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // Searchbutton_CustomerManagement
            // 
            this.Searchbutton_CustomerManagement.Animated = true;
            this.Searchbutton_CustomerManagement.AutoRoundedCorners = true;
            this.Searchbutton_CustomerManagement.BorderRadius = 21;
            this.Searchbutton_CustomerManagement.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Searchbutton_CustomerManagement.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Searchbutton_CustomerManagement.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Searchbutton_CustomerManagement.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Searchbutton_CustomerManagement.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.Searchbutton_CustomerManagement.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Searchbutton_CustomerManagement.ForeColor = System.Drawing.Color.White;
            this.Searchbutton_CustomerManagement.Location = new System.Drawing.Point(1021, 64);
            this.Searchbutton_CustomerManagement.Name = "Searchbutton_CustomerManagement";
            this.Searchbutton_CustomerManagement.Size = new System.Drawing.Size(89, 45);
            this.Searchbutton_CustomerManagement.TabIndex = 3;
            this.Searchbutton_CustomerManagement.Text = "Search";
            this.Searchbutton_CustomerManagement.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.AutoRoundedCorners = true;
            this.guna2TextBox1.BorderRadius = 23;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(730, 61);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "Search here";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(275, 48);
            this.guna2TextBox1.TabIndex = 2;
            // 
            // btnAdd_CustomerManagement
            // 
            this.btnAdd_CustomerManagement.Animated = true;
            this.btnAdd_CustomerManagement.AutoRoundedCorners = true;
            this.btnAdd_CustomerManagement.BorderRadius = 21;
            this.btnAdd_CustomerManagement.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd_CustomerManagement.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd_CustomerManagement.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd_CustomerManagement.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd_CustomerManagement.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.btnAdd_CustomerManagement.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd_CustomerManagement.ForeColor = System.Drawing.Color.White;
            this.btnAdd_CustomerManagement.Location = new System.Drawing.Point(42, 61);
            this.btnAdd_CustomerManagement.Name = "btnAdd_CustomerManagement";
            this.btnAdd_CustomerManagement.Size = new System.Drawing.Size(126, 45);
            this.btnAdd_CustomerManagement.TabIndex = 1;
            this.btnAdd_CustomerManagement.Text = "Add New";
            this.btnAdd_CustomerManagement.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // CustomerManagementLabel
            // 
            this.CustomerManagementLabel.AutoSize = true;
            this.CustomerManagementLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerManagementLabel.Location = new System.Drawing.Point(45, 9);
            this.CustomerManagementLabel.Name = "CustomerManagementLabel";
            this.CustomerManagementLabel.Size = new System.Drawing.Size(308, 38);
            this.CustomerManagementLabel.TabIndex = 0;
            this.CustomerManagementLabel.Text = "Customer Management";
            // 
            // CustomerList_CusManagement
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.CustomerList_CusManagement.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerList_CusManagement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CustomerList_CusManagement.ColumnHeadersHeight = 18;
            this.CustomerList_CusManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CustomerList_CusManagement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.CustomerName,
            this.CustomerPhoneNum,
            this.DeleteButton_CustomerManagement,
            this.EditButton_CustomerManagement});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CustomerList_CusManagement.DefaultCellStyle = dataGridViewCellStyle3;
            this.CustomerList_CusManagement.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustomerList_CusManagement.Location = new System.Drawing.Point(92, 148);
            this.CustomerList_CusManagement.Name = "CustomerList_CusManagement";
            this.CustomerList_CusManagement.RowHeadersVisible = false;
            this.CustomerList_CusManagement.RowHeadersWidth = 51;
            this.CustomerList_CusManagement.RowTemplate.Height = 24;
            this.CustomerList_CusManagement.Size = new System.Drawing.Size(1543, 740);
            this.CustomerList_CusManagement.TabIndex = 6;
            this.CustomerList_CusManagement.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CustomerList_CusManagement.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CustomerList_CusManagement.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CustomerList_CusManagement.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CustomerList_CusManagement.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CustomerList_CusManagement.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CustomerList_CusManagement.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustomerList_CusManagement.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CustomerList_CusManagement.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CustomerList_CusManagement.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerList_CusManagement.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CustomerList_CusManagement.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CustomerList_CusManagement.ThemeStyle.HeaderStyle.Height = 18;
            this.CustomerList_CusManagement.ThemeStyle.ReadOnly = false;
            this.CustomerList_CusManagement.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CustomerList_CusManagement.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CustomerList_CusManagement.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerList_CusManagement.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CustomerList_CusManagement.ThemeStyle.RowsStyle.Height = 24;
            this.CustomerList_CusManagement.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustomerList_CusManagement.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CustomerList_CusManagement.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // CustomerID
            // 
            this.CustomerID.HeaderText = "Mã khách hàng";
            this.CustomerID.MinimumWidth = 6;
            this.CustomerID.Name = "CustomerID";
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Tên Khách Hàng";
            this.CustomerName.MinimumWidth = 6;
            this.CustomerName.Name = "CustomerName";
            // 
            // CustomerPhoneNum
            // 
            this.CustomerPhoneNum.HeaderText = "Số điện thoại";
            this.CustomerPhoneNum.MinimumWidth = 6;
            this.CustomerPhoneNum.Name = "CustomerPhoneNum";
            // 
            // DeleteButton_CustomerManagement
            // 
            this.DeleteButton_CustomerManagement.HeaderText = "";
            this.DeleteButton_CustomerManagement.MinimumWidth = 6;
            this.DeleteButton_CustomerManagement.Name = "DeleteButton_CustomerManagement";
            this.DeleteButton_CustomerManagement.Text = "Delete";
            this.DeleteButton_CustomerManagement.UseColumnTextForButtonValue = true;
            // 
            // EditButton_CustomerManagement
            // 
            this.EditButton_CustomerManagement.HeaderText = "";
            this.EditButton_CustomerManagement.MinimumWidth = 6;
            this.EditButton_CustomerManagement.Name = "EditButton_CustomerManagement";
            this.EditButton_CustomerManagement.Text = "Edit";
            // 
            // CustomerManagementView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1647, 900);
            this.Controls.Add(this.CustomerList_CusManagement);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerManagementView";
            this.Text = "EmployeesView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EmployeesView_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerList_CusManagement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Button btnAdd_CustomerManagement;
        private System.Windows.Forms.Label CustomerManagementLabel;
        private Guna.UI2.WinForms.Guna2Button Searchbutton_CustomerManagement;
        private Guna.UI2.WinForms.Guna2DataGridView CustomerList_CusManagement;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerPhoneNum;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteButton_CustomerManagement;
        private System.Windows.Forms.DataGridViewButtonColumn EditButton_CustomerManagement;
    }
}