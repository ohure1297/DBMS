using QLCuaHangTuChon.QLCuaHangDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace QLCuaHangTuChon
{
    public static class QuanTri
    {
        public static void ThemNhanVien(NhanVien nv)
        {
            DBConn.ConnOpen();
            SqlCommand cmd = new SqlCommand("ADDNhanVien", DBConn.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@MaNV", SqlDbType.NVarChar, 10)).Value = nv.MaNV;
            cmd.Parameters.Add(new SqlParameter("@HoTen", SqlDbType.NVarChar, 20)).Value = nv.HoTen;
            cmd.Parameters.Add(new SqlParameter("@GioiTinh", SqlDbType.NVarChar, 5)).Value = nv.GioiTinh;
            cmd.Parameters.Add(new SqlParameter("@NgaySinh", SqlDbType.Date)).Value = nv.NgaySinh;
            cmd.Parameters.Add(new SqlParameter("@SDT", SqlDbType.NVarChar, 20)).Value = nv.Sdt;
            cmd.Parameters.Add(new SqlParameter("@DiaChi", SqlDbType.NVarChar, 50)).Value = nv.DChi;
            cmd.Parameters.Add(new SqlParameter("@AnhDaiDien", SqlDbType.NVarChar, 100)).Value = nv.AnhDaiDien;
            cmd.Parameters.Add(new SqlParameter("@MKhau", SqlDbType.NVarChar, 50)).Value = nv.MKhau;
            cmd.Parameters.Add(new SqlParameter("@NgayTuyenDung", SqlDbType.Date)).Value = nv.NgayTuyenDung;
            cmd.Parameters.Add(new SqlParameter("@ChucVu", SqlDbType.NVarChar, 20)).Value = nv.ChucVu;

            try
            {
                int rowsAffected = cmd.ExecuteNonQuery();

                Console.WriteLine($"{rowsAffected} row(s) inserted. Thêm nhân viên thành công.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            DBConn.ConnClose();
        }

        public static void XoaNhanVien (NhanVien nv)
        {
            DBConn.ConnOpen();
            SqlCommand cmd = new SqlCommand("Xoa_NV", DBConn.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@MaNV", SqlDbType.NVarChar, 10)).Value = nv.MaNV;

            try
            {
                int rowsAffected = cmd.ExecuteNonQuery();

                Console.WriteLine($"{rowsAffected} row(s) inserted. Xóa nhân viên thành công.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            DBConn.ConnClose();
        }

        public static void SuaNhanVien (NhanVien nv)
        {
            DBConn.ConnOpen();
            SqlCommand cmd = new SqlCommand("SuaNhanVien", DBConn.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@MaNV", SqlDbType.NVarChar, 10)).Value = nv.MaNV;
            cmd.Parameters.Add(new SqlParameter("@HoTen", SqlDbType.NVarChar, 20)).Value = nv.HoTen;
            cmd.Parameters.Add(new SqlParameter("@GioiTinh", SqlDbType.NVarChar, 5)).Value = nv.GioiTinh;
            cmd.Parameters.Add(new SqlParameter("@NgaySinh", SqlDbType.Date)).Value = nv.NgaySinh;
            cmd.Parameters.Add(new SqlParameter("@SDT", SqlDbType.NVarChar, 20)).Value = nv.Sdt;
            cmd.Parameters.Add(new SqlParameter("@DiaChi", SqlDbType.NVarChar, 50)).Value = nv.DChi;
            cmd.Parameters.Add(new SqlParameter("@AnhDaiDien", SqlDbType.NVarChar, 100)).Value = nv.AnhDaiDien;
            cmd.Parameters.Add(new SqlParameter("@MKhau", SqlDbType.NVarChar, 50)).Value = nv.MKhau;
            cmd.Parameters.Add(new SqlParameter("@NgayTuyenDung", SqlDbType.Date)).Value = nv.NgayTuyenDung;
            cmd.Parameters.Add(new SqlParameter("@ChucVu", SqlDbType.NVarChar, 20)).Value = nv.ChucVu;

            try
            {
                int rowsAffected = cmd.ExecuteNonQuery();

                Console.WriteLine($"{rowsAffected} row(s) inserted. Sửa thông tin nhân viên thành công.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            DBConn.ConnClose();
        }

        public static DataTable TimTenNhanVien(NhanVien nv)
        {
            DataTable dt = new DataTable();

            DBConn.ConnOpen();
            SqlCommand cmd = new SqlCommand("SearchTenNV", DBConn.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@str", SqlDbType.NVarChar, 10)).Value = nv.HoTen;

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return dt;

        }
    }
}
