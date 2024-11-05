using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using QL.Models;

namespace QL.DAO
{
    public class DiscountDAO
    {
        DBConnection dbCon = new DBConnection();
        public DiscountDAO() { }

        public DataTable LoadDiscountTable()
        {
            try
            {
                dbCon.openConnection();

                SqlCommand cmd = new SqlCommand("SELECT * FROM V_DsKhuyenMai", dbCon.getConnection);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable discountTable = new DataTable();
                adapter.Fill(discountTable);

                return discountTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                dbCon.closeConnection();
            }
        }
        public DataTable FindDiscountByID(string makhuyenmai) 
        {
            dbCon.openConnection();

            SqlCommand cmd = new SqlCommand("sp_TimKiemKhuyenMaiTheoMa", dbCon.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaKhuyenMai", SqlDbType.Text).Value = makhuyenmai;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable discountTable = new DataTable();
            adapter.Fill(discountTable);

            return discountTable;
        }

        public DataTable FindDiscountByName(string tenkhuyenmai)
        {
            dbCon.openConnection();

            SqlCommand cmd = new SqlCommand("SELECT * FROM fn_TimKiemKhuyenMaiTheoTen (@TenKhuyenMai)", dbCon.getConnection);

            cmd.Parameters.AddWithValue("@TenKhuyenMai", SqlDbType.Text).Value = tenkhuyenmai;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable discountTable = new DataTable();
            adapter.Fill(discountTable);

            return discountTable;
        }
    }
}
