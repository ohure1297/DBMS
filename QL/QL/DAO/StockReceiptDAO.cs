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

        public void NhanVienConnect()
        {
            dbCon.changeStrConnectToNhanVien();
        }

        public void QuanLyConnect()
        {
            dbCon.changeStrConnectToQuanLy();
        }

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

        public void AddStockReceipt(List<StockReceiptProducts> selectedProducts)
        {
            try
            {
                dbCon.openConnection();

                SqlCommand cmd = new SqlCommand("sp_ThemPhieuNhap", dbCon.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                DataTable productList = new DataTable();
                productList.Columns.Add("MaSPham", typeof(string));
                productList.Columns.Add("SoLuongNhap", typeof(int));

                foreach (var product in selectedProducts)
                {
                    if (product.MaSPham == null)
                    {
                        productList.Rows.Add(DBNull.Value, product.SoLuongNhap);
                    }
                    else
                    {
                        productList.Rows.Add(product.MaSPham, product.SoLuongNhap);
                    }
                }

                SqlParameter tvpParam = cmd.Parameters.AddWithValue("@DanhSachSanPham", productList);
                tvpParam.SqlDbType = SqlDbType.Structured;
                tvpParam.TypeName = "DanhSachSanPhamNhap";

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm Phiếu Nhập Thành Công");

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

                if (maphieunhap == null || maNV == null)
                {
                    cmd.Parameters.AddWithValue("@MaPhieuNhap", DBNull.Value);
                    cmd.Parameters.AddWithValue("@MaNV", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@MaPhieuNhap", maphieunhap);
                    cmd.Parameters.AddWithValue("@MaNV", maNV);
                }
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
