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
   
            //Nhan vien
            dtgvNhanVien.DataSource = GetTable.getEmployees();
            //San pham
            dtgvSanPham.DataSource = GetTable.loadProducts();
            //Phan ca
            dtgvPhanCa.DataSource = GetTable.shiftDivision();

            
        }

        private void XoaNhomSanPham()
        {
            DBConn.ConnOpen();
            SqlCommand cmd = new SqlCommand("ThemNhomSanPham", DBConn.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaNhom", SqlDbType.NVarChar, 10)).Value = nhomSp.MaNhomVal;
            try
            {
                
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) 
            { 
                DBConn.ConnClose();
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThemNhomSanPham();
        }
    }
}
