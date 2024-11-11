using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL.Models;

namespace QL.DAO
{
    public class DiscountDAO
    {
        DBConnection dbCon = new DBConnection();
        public DiscountDAO() { }

        public DataTable LoadDiscountTable()
        {
            DataTable discountTable = new DataTable();
            try
            {
                dbCon.openConnection();

                SqlCommand cmd = new SqlCommand("SELECT * FROM V_DsKhuyenMai", dbCon.getConnection);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                
                adapter.Fill(discountTable);

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
            finally
            {
                dbCon.closeConnection();
            }
            return discountTable;
        }

        public DataTable LoadValidDiscount()
        {
            try
            {
                dbCon.openConnection();

                SqlCommand cmd = new SqlCommand("SELECT * FROM V_DsKhuyenMaiConHieuLuc", dbCon.getConnection);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable discountTable = new DataTable();
                adapter.Fill(discountTable);

                return discountTable;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                dbCon.closeConnection();
            }
        }
        public DataTable FindDiscountByID(string makhuyenmai) 
        {
            try
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

        public DataTable FindDiscountByName(string tenkhuyenmai)
        {
            try
            {
                dbCon.openConnection();

                SqlCommand cmd = new SqlCommand("SELECT * FROM fn_TimKiemKhuyenMaiTheoTen (@TenKhuyenMai)", dbCon.getConnection);

                cmd.Parameters.AddWithValue("@TenKhuyenMai", SqlDbType.Text).Value = tenkhuyenmai;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable discountTable = new DataTable();
                adapter.Fill(discountTable);

                return discountTable;
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

        public int AddDiscount (Discount discount)
        {
            int result = 0;
            try
            {
                dbCon.openConnection();
                SqlCommand cmd = new SqlCommand("sp_ThemKhuyenMai", dbCon.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaKhuyenMai", discount.Makhuyenmai);
                cmd.Parameters.AddWithValue("@TenKhuyenMai", discount.Tenkhuyenmai);
                cmd.Parameters.AddWithValue("@NgBatDau", discount.Ngbatdau);
                cmd.Parameters.AddWithValue("@NgHetHan", discount.Nghethan);
                cmd.Parameters.AddWithValue("@MucKhuyenMai", discount.Muckhuyenmai);

                result = cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                if (ex.Errors[0].Class == 16)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            finally
            {
                dbCon.closeConnection();
            }
            return result;
        }

        public void AddDiscountedProduct(string maKM, string maSP)
        {
            try
            {
                dbCon.openConnection();

                SqlCommand cmd = new SqlCommand("sp_ThemSanPhamDuocApDungKhuyenMai", dbCon.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaSPham", maSP);
                cmd.Parameters.AddWithValue("@MaKhuyenMai", maKM);
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

        public Discount LoadDisCountInfo(string makhuyenmai)
        {
            Discount discount = null;
            try
            {
                dbCon.openConnection();

                SqlCommand cmd = new SqlCommand($"SELECT * FROM V_DsKhuyenMai WHERE MaKhuyenMai = '{makhuyenmai}'", dbCon.getConnection);


                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        discount = new Discount()
                        {
                            Makhuyenmai = reader["MaKhuyenMai"].ToString(),
                            Tenkhuyenmai = reader["TenKhuyenMai"].ToString(),
                            Ngbatdau = Convert.ToDateTime(reader["NgBatDau"].ToString()),
                            Nghethan = Convert.ToDateTime(reader["NgHetHan"].ToString()),
                            Muckhuyenmai = (float)Convert.ToDecimal(reader["MucKhuyenMai"])
                        };
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return discount;
        }

        public void DeleteDisCount(string makhuyenmai)
        {
            try
            {
                dbCon.openConnection();

                SqlCommand cmd = new SqlCommand("sp_XoaKhuyenMai", dbCon.getConnection);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaKhuyenMai", makhuyenmai);
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

        public void UpdateDiscount(Discount discount)
        {
            try
            {
                dbCon.openConnection();

                SqlCommand cmd = new SqlCommand("sp_SuaKhuyenMai", dbCon.getConnection);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaKhuyenMai", discount.Makhuyenmai);
                cmd.Parameters.AddWithValue("@TenKhuyenMai", discount.Tenkhuyenmai);
                cmd.Parameters.AddWithValue("@NgBatDau", discount.Ngbatdau);
                cmd.Parameters.AddWithValue("@NgHetHan", discount.Nghethan);
                cmd.Parameters.AddWithValue("@MucKhuyenMai", discount.Muckhuyenmai);

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
