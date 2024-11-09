using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL.Models;
using System.Windows.Forms;


namespace QL.DAO
{
    public class ReceiptDAO
    {
        DBConnection dbCon = new DBConnection();
        public ReceiptDAO() { }

        public DataTable LoadReceipts()
        {
            try
            {
                dbCon.openConnection();

                SqlCommand cmd = new SqlCommand("SELECT * FROM V_DsHoaDon", dbCon.getConnection);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable stockReceipt_table = new DataTable();
                adapter.Fill(stockReceipt_table);

                return stockReceipt_table;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                dbCon.closeConnection();
            }
        }
        
        public void AddReceipt(Receipt receipt)
        {
            try
            {
                dbCon.openConnection();

                SqlCommand cmd = new SqlCommand("sp_ThemHoaDon", dbCon.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TinhTrang", receipt.TinhTrang);

                cmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbCon.closeConnection();
            }
        }

        public void AddReceiptInfo(ReceiptInfo receiptInfo)
        {
            try
            {
                dbCon.openConnection();

                SqlCommand cmd = new SqlCommand("sp_ThemSanPhamVaoChiTietHoaDon", dbCon.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaSP", receiptInfo.MaSanPham);
                cmd.Parameters.AddWithValue("@SoLuong", receiptInfo.SoLuong);

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbCon.closeConnection();
            }
        }

        public void EditReceiptInfo(ReceiptInfo receiptInfo)
        {
            try
            {
                dbCon.openConnection();

                SqlCommand cmd = new SqlCommand("sp_ThemSanPhamVaoChiTietHoaDon", dbCon.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaSP", receiptInfo.MaSanPham);
                cmd.Parameters.AddWithValue("@SoLuong", receiptInfo.SoLuong);

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbCon.closeConnection();
            }
        }


    }
}
