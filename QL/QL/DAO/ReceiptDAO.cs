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


        public DataTable GetAllReceipts()
        {
            try
            {
                dbCon.openConnection();
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.HOADON", dbCon.getConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable receiptTable = new DataTable();
                adapter.Fill(receiptTable);
                return receiptTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message + "\n" + ex.StackTrace,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                dbCon.closeConnection();
            }
        }

        public DataTable TimKiemHoaDon(string keyword)
        {
            try
            {
                dbCon.openConnection();
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.TimKiemHoaDon(@keyword)", dbCon.getConnection);
                cmd.Parameters.AddWithValue("@keyword", keyword);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable resultTable = new DataTable();
                adapter.Fill(resultTable);
                return resultTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message + "\n" + ex.StackTrace,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                dbCon.closeConnection();
            }
        }
        public DataTable LayDanhSachChiTietHoaDon(string maHoaDon)
        {
            try
            {
                dbCon.openConnection();
                SqlCommand cmd = new SqlCommand("sp_LayChiTietHoaDon", dbCon.getConnection);
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
                dbCon.closeConnection();
            }
        }
        //public DataTable LoadReceipts()
        //{
        //    try
        //    {
        //        dbCon.openConnection();

        //        SqlCommand cmd = new SqlCommand("SELECT * FROM V_DsHoaDon", dbCon.getConnection);

        //        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //        DataTable stockReceipt_table = new DataTable();
        //        adapter.Fill(stockReceipt_table);

        //        return stockReceipt_table;
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //    finally
        //    {
        //        dbCon.closeConnection();
        //    }
        //}
        
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

        public bool EndReceiptProcess()
        {
            try
            {
                dbCon.openConnection();

                SqlCommand cmd = new SqlCommand("sp_HoanTatThanhToan", dbCon.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                

                
            }
            catch (SqlException ex)
            {
                if (ex.Errors[0].Class == 16)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            finally
            {
                dbCon.closeConnection();
            }
            return true;

        }

        public void AccumulatePoints(string SDT)
        {
            try
            {
                dbCon.openConnection();

                SqlCommand cmd = new SqlCommand("sp_ThemTichDiem", dbCon.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SDT", SDT);
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "AccumulatePoints");
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
            int tienThoi = -1;
            try
            {
                dbCon.openConnection();
                SqlCommand cmd = new SqlCommand("SELECT TienThoi FROM v_LayTongTienVaTienThoiCuaHoaDonHienTai", dbCon.getConnection);
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                    tienThoi = Convert.ToInt32(result); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " ReturnChangedMoney");
            }
            finally
            {
                dbCon.closeConnection();
            }
            return tienThoi;
        }




        public void UpdateProductQuantity(ReceiptInfo receiptInfo)
        {
            try
            {
                dbCon.openConnection();

                SqlCommand cmd = new SqlCommand("sp_CapNhatSoLuongSanPham", dbCon.getConnection);
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

        public void DeleteProduct(ReceiptInfo receiptInfo) 
        {
            try
            {
                dbCon.openConnection();

                SqlCommand cmd = new SqlCommand("sp_XoaSanPhamTrongHoaDon", dbCon.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaSPham", receiptInfo.MaSanPham);

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

        public int CheckMoneyIfUsePoint(Customer customer)
        {
            int tongTienSauKhiSuDungDiem = -1;
            try
            {
                dbCon.openConnection();

                SqlCommand cmd = new SqlCommand("SELECT dbo.fn_KiemTraTongTienNeuSuDungDiem(@SDT)", dbCon.getConnection);
                cmd.Parameters.AddWithValue("@SDT", customer.PhoneNum);
                cmd.ExecuteNonQuery();
                object result = cmd.ExecuteScalar();
                //MessageBox.Show(result.ToString());
                if (result != DBNull.Value)
                    tongTienSauKhiSuDungDiem = Convert.ToInt32(result);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "AccumulatePoints");
            }
            finally
            {
                dbCon.closeConnection();
            }
            return tongTienSauKhiSuDungDiem;
        }

        


    }
}
