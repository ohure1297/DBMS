using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangTuChon
{
    public partial class testform : Form
    {
        public testform()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DBConn.ConnOpen();
            DBConn db = new DBConn();

            SanPham sp = new SanPham()
            {
                MaSP = txtMaSP.Text,
                TenSP = txtTenSP.Text,
                Hinhanh = txtHinhAnh.Text,
                NhaSX = txtNhaSanXuat.Text,
                Giaban = Int32.Parse(txtGiaBan.Text),
                Tonkho = Int32.Parse(txtTonKho.Text),
                Daban = Int32.Parse(txtDaBan.Text),
            };

            DAO_NhanVien.InsertProducts(db, sp);
        }

        private void testform_Load(object sender, EventArgs e)
        {
            DBConn.ConnOpen();
            DBConn db = new DBConn();
            dtgvSanPham.DataSource = GetTable.loadProducts(db);
        }
    }


}
