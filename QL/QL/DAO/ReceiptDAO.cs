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
                MessageBox.Show(ex.Message + "AddReceipt");
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
                MessageBox.Show(ex.Message + "AddReceiptInfo");
            }
            finally
            {
                dbCon.closeConnection();
            }
           
        }

        public void EndReceiptProcess()
        {
            try
            {
                dbCon.openConnection();

                SqlCommand cmd = new SqlCommand("sp_HoanTatThanhToan", dbCon.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "EndReceiptProcess");
            }
            finally
            {
                dbCon.closeConnection();
            }

        }

        public int ReturnReceiptTotalMoney()
        {
            int tongTien = 0;
            try
            {
                dbCon.openConnection();
                SqlCommand cmd = new SqlCommand("SELECT TongTien FROM v_LayTongTienVaTienThoiCuaHoaDonHienTai", dbCon.getConnection);
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                    tongTien = Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "ReturnReceiptTotalMoney");

            }
            finally
            {
                dbCon.closeConnection();
            }
            return tongTien;
        }

        public int ReturnChangedMoney()
        {
            int tienThoi = 0;
            try
            {
                dbCon.openConnection();
                SqlCommand cmd = new SqlCommand("SELECT TienThoi FROM v_LayTongTienVaTienThoiCuaHoaDonHienTai", dbCon.getConnection);
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                    tienThoi = Convert.ToInt32(result);
                else
                {
                    MessageBox.Show("Chưa có sản phẩm nào để thanh toán", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "ReturnChangedMoney");
            }
            finally
            {
                dbCon.closeConnection();
            }
            return tienThoi;
        }




        public void UpdateReceiptInfo(ReceiptInfo receiptInfo)
        {
            try
            {
                dbCon.openConnection();

                SqlCommand cmd = new SqlCommand("sp_SuaChiTietHoaDon", dbCon.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaSPham", receiptInfo.MaSanPham);
                cmd.Parameters.AddWithValue("@SoLuong", receiptInfo.SoLuong);

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "UpdateReceiptInfo");
            }
            finally
            {
                dbCon.closeConnection();
            }
        }

        public void UpdateReceipt(Receipt receipt)
        {
            try
            {
                dbCon.openConnection();

                SqlCommand cmd = new SqlCommand("sp_CapNhatHoaDon", dbCon.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TienKhachDua", receipt.TienKhachDua);
                cmd.Parameters.AddWithValue("@TinhTrang", receipt.TinhTrang);

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "UpdateReceipt");
            }
            finally
            {
                dbCon.closeConnection();
            }
        }


    }
}
