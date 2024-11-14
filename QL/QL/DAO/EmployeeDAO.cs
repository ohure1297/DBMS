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
        public void NhanVienConnect()
        {
            db.changeStrConnectToNhanVien();
        }

        public void QuanLyConnect()
        {
            db.changeStrConnectToQuanLy();
        }
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
                using (SqlConnection connection = db.getConnection)
                {
                    string query = "EXEC [dbo].[sp_AddNhanVien] " +
               "@MaNV, " +
               "@HoTen, " +
               "@GioiTinh, " +
               "@NgaySinh, " +
               "@SDT, " +
               "@AnhDaiDien, " +
               "@NgTuyenDung, " +
               "@MaNguoiQuanLy, " +
               "@TinhTrang";

                    

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaNV", maNV);
                        command.Parameters.AddWithValue("@HoTen", hoTen);
                        command.Parameters.AddWithValue("@GioiTinh", gioiTinh);

                        command.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                        command.Parameters.AddWithValue("@SDT", sdt);
                        command.Parameters.AddWithValue("@AnhDaiDien", anhDaiDien);
                        command.Parameters.AddWithValue("@NgTuyenDung", ngTuyenDung);
                        command.Parameters.AddWithValue("@MaNguoiQuanLy", maNguoiQuanLy);
                        command.Parameters.AddWithValue("@TinhTrang", "Active");
                        
                        connection.Open();
                        command.ExecuteNonQuery();

                        // Display success message
                        MessageBox.Show("Thêm nhân viên thành công.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the error (in a real-world scenario, you'd log to a file or monitoring system)
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        public void ThemTaiKhoan(string maNV, string taiKhoan, string matKhau, string vaiTro)
        {
            try
            {
                using (SqlConnection connection = db.getConnection)
                {
                    string query = "EXEC [dbo].[sp_ThemtaiKhoan] " +
               "@TenTaiKhoan, " +
               "@MatKhau, " +
               "@VaiTro, " +
               "@MaNV";



                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaNV", maNV);
                        command.Parameters.AddWithValue("@TenTaiKhoan", taiKhoan);
                        command.Parameters.AddWithValue("@VaiTro", vaiTro);
                        command.Parameters.AddWithValue("@MatKhau", matKhau);
                        

                        connection.Open();
                        command.ExecuteNonQuery();

                        // Display success message
                        MessageBox.Show("Thêm tài khoản thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the error (in a real-world scenario, you'd log to a file or monitoring system)
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        
    }
}



