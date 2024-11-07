using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL.Models;

namespace QL.DAO
{
    internal class DetailReceiptDAO
    {
        DBConnection db = new DBConnection();
        public DataTable LayDanhSachChiTietHoaDon(string maHoaDon)
        {
            try
            {
                db.openConnection();
                SqlCommand cmd = new SqlCommand("sp_LayChiTietHoaDon", db.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return null;
            }
            finally
            {
                db.closeConnection();
            }
        }

    }
}
