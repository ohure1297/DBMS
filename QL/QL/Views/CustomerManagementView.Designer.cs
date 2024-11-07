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
            this.cbSearchOptions = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Searchbutton_CustomerManagement = new Guna.UI2.WinForms.Guna2Button();
            this.tbxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAdd_CustomerManagement = new Guna.UI2.WinForms.Guna2Button();
            this.CustomerManagementLabel = new System.Windows.Forms.Label();
            this.dgv_Customer = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.cbSearchOptions);
            this.guna2Panel1.Controls.Add(this.Searchbutton_CustomerManagement);
            this.guna2Panel1.Controls.Add(this.tbxSearch);
            this.guna2Panel1.Controls.Add(this.btnAdd_CustomerManagement);
            this.guna2Panel1.Controls.Add(this.CustomerManagementLabel);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1647, 128);
            this.guna2Panel1.TabIndex = 5;
            // 
            // cbSearchOptions
            // 
            this.cbSearchOptions.AutoRoundedCorners = true;
            this.cbSearchOptions.BackColor = System.Drawing.Color.Transparent;
            this.cbSearchOptions.BorderRadius = 17;
            this.cbSearchOptions.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSearchOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchOptions.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSearchOptions.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSearchOptions.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbSearchOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSearchOptions.ItemHeight = 30;
            this.cbSearchOptions.Items.AddRange(new object[] {
            "Tên",
            "SĐT"});
            this.cbSearchOptions.Location = new System.Drawing.Point(544, 70);
            this.cbSearchOptions.Name = "cbSearchOptions";
            this.cbSearchOptions.Size = new System.Drawing.Size(142, 36);
            this.cbSearchOptions.StartIndex = 0;
            this.cbSearchOptions.TabIndex = 4;
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
            this.Searchbutton_CustomerManagement.Click += new System.EventHandler(this.Searchbutton_CustomerManagement_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.AutoRoundedCorners = true;
            this.tbxSearch.BorderRadius = 23;
            this.tbxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxSearch.DefaultText = "";
            this.tbxSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxSearch.Location = new System.Drawing.Point(730, 61);
            this.tbxSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.PasswordChar = '\0';
            this.tbxSearch.PlaceholderText = "Search here";
            this.tbxSearch.SelectedText = "";
            this.tbxSearch.Size = new System.Drawing.Size(275, 48);
            this.tbxSearch.TabIndex = 2;
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
            // dgv_Customer
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_Customer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Customer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Customer.ColumnHeadersHeight = 18;
            this.dgv_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Customer.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Customer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Customer.Location = new System.Drawing.Point(92, 148);
            this.dgv_Customer.Name = "dgv_Customer";
            this.dgv_Customer.RowHeadersVisible = false;
            this.dgv_Customer.RowHeadersWidth = 51;
            this.dgv_Customer.RowTemplate.Height = 24;
            this.dgv_Customer.Size = new System.Drawing.Size(1543, 740);
            this.dgv_Customer.TabIndex = 6;
            this.dgv_Customer.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Customer.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Customer.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Customer.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Customer.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Customer.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Customer.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Customer.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_Customer.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Customer.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Customer.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Customer.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Customer.ThemeStyle.HeaderStyle.Height = 18;
            this.dgv_Customer.ThemeStyle.ReadOnly = false;
            this.dgv_Customer.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Customer.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Customer.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Customer.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Customer.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_Customer.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Customer.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // CustomerManagementView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1647, 900);
            this.Controls.Add(this.dgv_Customer);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerManagementView";
            this.Text = "EmployeesView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CustomerManagementView_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox tbxSearch;
        private Guna.UI2.WinForms.Guna2Button btnAdd_CustomerManagement;
        private System.Windows.Forms.Label CustomerManagementLabel;
        private Guna.UI2.WinForms.Guna2Button Searchbutton_CustomerManagement;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Customer;
        private Guna.UI2.WinForms.Guna2ComboBox cbSearchOptions;
    }
}