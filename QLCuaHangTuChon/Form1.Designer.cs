namespace QLCuaHangTuChon
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.thongTinNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLCuaHangDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLCuaHangDataSet = new QLCuaHangTuChon.QLCuaHangDataSet();
            this.thongTinNhanVienTableAdapter = new QLCuaHangTuChon.QLCuaHangDataSetTableAdapters.ThongTinNhanVienTableAdapter();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinNhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCuaHangDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCuaHangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // thongTinNhanVienBindingSource
            // 
            this.thongTinNhanVienBindingSource.DataMember = "ThongTinNhanVien";
            this.thongTinNhanVienBindingSource.DataSource = this.qLCuaHangDataSetBindingSource;
            // 
            // qLCuaHangDataSetBindingSource
            // 
            this.qLCuaHangDataSetBindingSource.DataSource = this.qLCuaHangDataSet;
            this.qLCuaHangDataSetBindingSource.Position = 0;
            // 
            // qLCuaHangDataSet
            // 
            this.qLCuaHangDataSet.DataSetName = "QLCuaHangDataSet";
            this.qLCuaHangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thongTinNhanVienTableAdapter
            // 
            this.thongTinNhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Location = new System.Drawing.Point(61, 59);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.Size = new System.Drawing.Size(1235, 206);
            this.dgvNhanVien.TabIndex = 2;
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Location = new System.Drawing.Point(61, 309);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.RowTemplate.Height = 24;
            this.dgvSanPham.Size = new System.Drawing.Size(593, 258);
            this.dgvSanPham.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 691);
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(this.dgvNhanVien);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.thongTinNhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCuaHangDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCuaHangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource qLCuaHangDataSetBindingSource;
        private QLCuaHangDataSet qLCuaHangDataSet;
        private System.Windows.Forms.BindingSource thongTinNhanVienBindingSource;
        private QLCuaHangDataSetTableAdapters.ThongTinNhanVienTableAdapter thongTinNhanVienTableAdapter;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.DataGridView dgvSanPham;
    }
}

