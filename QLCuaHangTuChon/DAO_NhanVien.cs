using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using System.Data;
using System.IO;

namespace QLCuaHangTuChon
{
    public class DAO_NhanVien
    {
        public static void InsertProducts(DBConn db, SanPham sp)
        {
            DBConn.ConnOpen();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_ThemSanPham", db.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@masp", SqlDbType.NVarChar).Value = sp.MaSP;
                cmd.Parameters.Add("@tensp", SqlDbType.NVarChar).Value = sp.TenSP;
                cmd.Parameters.Add("@hinhanh", SqlDbType.NVarChar).Value = sp.Hinhanh.ToArray();
                cmd.Parameters.Add("@nsx", SqlDbType.NVarChar).Value = sp.NhaSX;
                cmd.Parameters.Add("@giaban", SqlDbType.Int).Value = sp.Giaban;
                cmd.Parameters.Add("@tonkho", SqlDbType.Int).Value = sp.Tonkho;
                cmd.Parameters.Add("@daban", SqlDbType.Int).Value = sp.Daban;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    Console.WriteLine("Đã thêm thành công");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: ", ex.Message);
            }

            DBConn.ConnClose();
        }

        public static void DeleteProducts(DBConn db, SanPham sp)
        {
            DBConn.ConnOpen();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_XoaSanPhamTheoMa", db.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@masp", SqlDbType.NVarChar).Value = sp.MaSP;
                SqlParameter result = new SqlParameter("@Result", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(result);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    Console.WriteLine("Đã xóa thành công");
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error: ", ex.Message);
            }

            DBConn.ConnClose();
        }

        public static void UpdateProducts(DBConn db, SanPham sp)
        {
            try
            {
                DBConn.ConnOpen();

                SqlCommand cmd = new SqlCommand("sp_SuaSanPham", db.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@masp", SqlDbType.NVarChar).Value = sp.MaSP;
                cmd.Parameters.Add("@tensp", SqlDbType.NVarChar).Value = sp.TenSP;
                cmd.Parameters.Add("@hinhanh", SqlDbType.NVarChar).Value = sp.Hinhanh.ToArray();
                cmd.Parameters.Add("@nsx", SqlDbType.NVarChar).Value = sp.NhaSX;
                cmd.Parameters.Add("@giaban", SqlDbType.Int).Value = sp.Giaban;
                cmd.Parameters.Add("@tonkho", SqlDbType.Int).Value = sp.Tonkho;
                cmd.Parameters.Add("@daban", SqlDbType.Int).Value = sp.Daban;

                SqlParameter result = new SqlParameter("@Result", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };

                cmd.Parameters.Add(result);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    Console.WriteLine("Đã sửa thành công");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: ", ex.Message);
            }

            DBConn.ConnClose();
        }

        public SanPham GetProductById(DBConn db, string masp)
        {
            SanPham sp = new SanPham();
            try
            {
                DBConn.ConnOpen();

                SqlCommand cmd = new SqlCommand("SELECT * FROM fn_LayThongTinSanPham(@masp)", db.getConnection);

                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    sp = new SanPham
                    {
                        MaSP = reader["MaSPham"].ToString(),
                        TenSP = reader["TenSPham"].ToString(),
                        Hinhanh = reader["HinhAnh"].ToString(),
                        NhaSX = reader["NhaSanXuat"].ToString(),
                        Giaban = Convert.ToInt32(reader["GiaBan"]),
                        Tonkho = Convert.ToInt32(reader["TonKho"]),
                        Daban = Convert.ToInt32(reader["DaBan"])
                    };
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: ", ex.Message);
            }

            DBConn.ConnClose();
            return sp;
        }

        public List<SanPham> ProductList(DBConn db)
        {
            List<SanPham> danhsachsp = new List<SanPham>();
            try
            {
                DBConn.ConnOpen();

                SqlCommand cmd = new SqlCommand("SELECT * FROM fn_LayDanhSachSanPham", db.getConnection);

                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                SanPham sp;

                if (reader.Read())
                {
                    sp = new SanPham();
                    sp.MaSP = reader["MaSPham"].ToString();
                    ;
                    sp.TenSP = reader["TenSPham"].ToString();
                    sp.Hinhanh = reader["HinhAnh"].ToString();
                    sp.NhaSX = reader["NhaSanXuat"].ToString();
                    sp.Giaban = Convert.ToInt32(reader["GiaBan"]);
                    sp.Tonkho = Convert.ToInt32(reader["TonKho"]);
                    sp.Daban = Convert.ToInt32(reader["DaBan"]);

                    danhsachsp.Add(sp);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: ", ex.Message);
            }

            DBConn.ConnClose();

            return danhsachsp;
        }

        public List<SanPham> FindProduct(DBConn db, string chuoitimkiem)
        {
            List<SanPham> danhsachsp = new List<SanPham>();
            try
            {
                DBConn.ConnOpen();

                SqlCommand cmd = new SqlCommand("SELECT * FROM fn_TimKiemSanPham(@GiaTriTimKiem)", db.getConnection);

                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@GiaTriTimKiem", chuoitimkiem);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    SanPham sp = new SanPham()
                    {
                        MaSP = reader["MaSPham"].ToString(),
                        TenSP = reader["TenSPham"].ToString(),
                        Hinhanh = reader["HinhAnh"].ToString(),
                        NhaSX = reader["NhaSanXuat"].ToString(),
                        Giaban = Convert.ToInt32(reader["GiaBan"]),
                        Tonkho = Convert.ToInt32(reader["TonKho"]),
                        Daban = Convert.ToInt32(reader["DaBan"])
                    };

                    danhsachsp.Add(sp);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: ", ex.Message);
            }

            DBConn.ConnClose();
            return danhsachsp;
        }

    }
}
