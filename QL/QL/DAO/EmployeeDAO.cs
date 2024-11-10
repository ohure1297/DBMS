using QL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL.DAO
{
    public class EmployeeDAO
    {
        DBConnection db = new DBConnection();
        public DataTable LayDanhSachNhanVien()
        {
            DataTable dt = new DataTable();

            try
            {
                db.openConnection();
                SqlCommand cmd = new SqlCommand("SELECT MaNV, HoTen, GioiTinh, SDT, MaNguoiQuanLy, TinhTrang FROM NHANVIEN", db.getConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy danh sách nhân viên: " + ex.Message);
            }
            finally
            {
                db.closeConnection();
            }

            return dt;
        }
        public DataRow LayThongTinChiTietNhanVien(string maNV)
        {
            DataTable dt = new DataTable();

            try
            {
                db.openConnection();
                SqlCommand cmd = new SqlCommand("SELECT MaNV, HoTen, GioiTinh, NgaySinh, NgTuyenDung, SDT, AnhDaiDien, TinhTrang FROM NHANVIEN WHERE MaNV = @MaNV", db.getConnection);
                cmd.Parameters.AddWithValue("@MaNV", maNV);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy thông tin chi tiết nhân viên: " + ex.Message);
            }
            finally
            {
                db.closeConnection();
            }

            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

        public bool UpdateEmployee(string maNV, string hoTen, string gioiTinh, DateTime ngaySinh, DateTime ngayTuyenDung, string sdt, string TinhTrang)
        {
            try
            {
                db.openConnection();
                SqlCommand cmd = new SqlCommand("UPDATE NHANVIEN SET HoTen=@HoTen, SDT=@SDT, GioiTinh=@GioiTinh, NgaySinh=@NgaySinh, NgTuyenDung=@NgTuyenDung, TinhTrang=@TinhTrang WHERE MaNV=@MaNV", db.getConnection);
                cmd.Parameters.AddWithValue("@MaNV", maNV);
                cmd.Parameters.AddWithValue("@HoTen", hoTen);
                cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                cmd.Parameters.AddWithValue("@NgTuyenDung", ngayTuyenDung);
                cmd.Parameters.AddWithValue("@SDT", sdt);
                cmd.Parameters.AddWithValue("@TinhTrang", TinhTrang);

                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật thông tin nhân viên: " + ex.Message);
                return false;
            }
            finally
            {
                db.closeConnection();
            }
        }
        public bool ThemNhanVien(string maNV, string hoTen, string gioiTinh, DateTime ngaySinh, string sdt, byte[] anhDaiDien, string tenTK, string matKhau, DateTime ngTuyenDung, string maNguoiQuanLy)
        {
            try
            {
                db.openConnection();
                SqlCommand cmd = new SqlCommand("sp_ThemNhanVien", db.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaNV", maNV);
                cmd.Parameters.AddWithValue("@HoTen", hoTen);
                cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                cmd.Parameters.AddWithValue("@SDT", sdt);
                cmd.Parameters.AddWithValue("@AnhDaiDien", anhDaiDien ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@TenTK", tenTK);
                cmd.Parameters.AddWithValue("@MKhau", matKhau);
                cmd.Parameters.AddWithValue("@NgTuyenDung", ngTuyenDung);
                cmd.Parameters.AddWithValue("@MaNguoiQuanLy", maNguoiQuanLy ?? (object)DBNull.Value);

                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin ");
                return false;
            }
            finally
            {
                db.closeConnection();
            }
        }

    }


}



