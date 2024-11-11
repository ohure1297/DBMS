using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Controls;
using QL.Models;

namespace QL.DAO
{
    public class StockReceiptDAO
    {
        DBConnection dbCon = new DBConnection();
        public StockReceiptDAO() { }

        public DataTable LoadStockReceipts()
        {
            DataTable stockReceipt_table = new DataTable();
            try
            {
                dbCon.openConnection();

                SqlCommand cmd = new SqlCommand("SELECT * FROM V_DsPhieuNhap", dbCon.getConnection);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                stockReceipt_table = new DataTable();
                adapter.Fill(stockReceipt_table);

                return stockReceipt_table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                dbCon.closeConnection();
            }
            return stockReceipt_table;
        }
        public DataTable FindStockReceipt(string maPhieuNhap)
        {
            try
            {
                dbCon.openConnection();

                SqlCommand cmd = new SqlCommand("sp_TimKiemPhieuNhap", dbCon.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@MaPhieuNhap", SqlDbType.Text).Value = maPhieuNhap;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable stockReceipt_table = new DataTable();
                adapter.Fill(stockReceipt_table);

                return stockReceipt_table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return null;
            }
            finally
            {
                dbCon.closeConnection();
            }
        }

        public DataTable GetStockReceiptProduct(string maPhieuNhap)
        {
            try
            {
                dbCon.openConnection();

                SqlCommand cmd = new SqlCommand("sp_ChiTietPhieuNhap", dbCon.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@MaPhieuNhap", SqlDbType.Text).Value = maPhieuNhap;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable stockReceipt_table = new DataTable();
                adapter.Fill(stockReceipt_table);

                return stockReceipt_table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return null;
            }
            finally
            {
                dbCon.closeConnection();
            }
        }

        public DataTable LoadStockProductList()
        {
            try
            {
                dbCon.openConnection();

                SqlCommand cmd = new SqlCommand("SELECT * FROM V_DsSanPhamNhap", dbCon.getConnection);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable stockReceipt_table = new DataTable();
                adapter.Fill(stockReceipt_table);

                return stockReceipt_table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return null;
            }
            finally
            {
                dbCon.closeConnection();
            }
        }

        public void AddStockReceipt(string maSP, int soluongnhap)
        {
            try
            {
                dbCon.openConnection();

                SqlCommand cmd = new SqlCommand("sp_ThemPhieuNhap", dbCon.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaSPham", maSP);
                cmd.Parameters.AddWithValue("@SoLuongNhap", soluongnhap);

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                dbCon.closeConnection();
            }
        }

        public void ConfirmStockReceipt(string maphieunhap, string maNV)
        {
            try
            {
                dbCon.openConnection();

                SqlCommand cmd = new SqlCommand("sp_XacNhanPhieuNhap", dbCon.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaPhieuNhap", maphieunhap);
                cmd.Parameters.AddWithValue("@MaNV", maNV);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                dbCon.closeConnection();
            }
        }

        public void DeleteStocReceipt(string maphieunhap)
        {
            try
            {
                dbCon.openConnection();

                SqlCommand cmd = new SqlCommand("sp_XoaPhieuNhap", dbCon.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaPhieuNhap", maphieunhap);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                dbCon.closeConnection();
            }
        }
    }
}
