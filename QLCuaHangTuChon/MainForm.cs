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
            dtgvNhanVien.DataSource = GetTable.getEmployees(db);
            //San pham
            dtgvSanPham.DataSource = GetTable.loadProducts(db);
            //Phan ca
            dtgvPhanCa.DataSource = GetTable.shiftDivision(db);
            DBConn.ConnClose();

        }
    }
}
