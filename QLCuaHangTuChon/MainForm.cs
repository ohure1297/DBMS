using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangTuChon
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DBConn.ConnOpen();
            DBConn db = new DBConn();
            //Nhan vien
            SqlCommand cmd = new SqlCommand("SELECT * FROM ThongTinNhanVien", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable nhanVienTable = new DataTable();
            adapter.Fill(nhanVienTable);
            dtgvNhanVien.DataSource = nhanVienTable;

            //San pham
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM DanhSachSanPham", db.getConnection);
            SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
            DataTable sanphamTable = new DataTable();
            adapter1.Fill(sanphamTable);
            dtgvSanPham.DataSource = sanphamTable;


            DBConn.ConnClose();
            
        }
    }
}
