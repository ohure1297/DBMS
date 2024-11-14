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
        String connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=CuaHangTienLoi;Integrated Security=True;";
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

        public DataTable TimKiemNhanVien(string maNV, string hoTen, string sdt, string tinhTrang)
        {
            DBConnection db = new DBConnection();
            DataTable dt = new DataTable();
            {
                SqlCommand cmd = new SqlCommand("sp_TimKiemNhanVien", db.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaNV", string.IsNullOrEmpty(maNV) ? (object)DBNull.Value : maNV);
                cmd.Parameters.AddWithValue("@HoTen", string.IsNullOrEmpty(hoTen) ? (object)DBNull.Value : hoTen);
                cmd.Parameters.AddWithValue("@SDT", string.IsNullOrEmpty(sdt) ? (object)DBNull.Value : sdt);
                cmd.Parameters.AddWithValue("@TinhTrang", string.IsNullOrEmpty(tinhTrang) ? (object)DBNull.Value : tinhTrang);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        public void ThemNhanVien(Employee employee)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "EXEC [dbo].[sp_ThemNhanVien] " +
                                   "@MaNV = @maNv, " +
                                   "@HoTen = @hoTen, " +
                                   "@GioiTinh = @gioiTinh, " +
                                   "@NgaySinh = @ngaySinh, " +
                                   "@SDT = @sdt, " +
                                   "@AnhDaiDien = @anhDaiDien, " +
                                   "@TenTK = @tenTK, " +
                                   "@MKhau = @mKhau, " +
                                   "@NgTuyenDung = @ngTuyenDung, " +
                                   "@MaNguoiQuanLy = @maNguoiQuanly ";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        

                        cmd.Parameters.AddWithValue("@maNV", employee.MaNV);
                        cmd.Parameters.AddWithValue("@hoTen", employee.HoTen);
                        cmd.Parameters.AddWithValue("@gioiTinh", employee.GioiTinh);
                        cmd.Parameters.AddWithValue("@ngaySinh", employee.NgaySinh);
                        cmd.Parameters.AddWithValue("@sdt", employee.Sdt);
                        cmd.Parameters.AddWithValue("@anhDaiDien", employee.AnhDaiDien ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@tenTK", employee.TenTK);
                        cmd.Parameters.AddWithValue("@mKhau", employee.MKhau);
                        cmd.Parameters.AddWithValue("@ngTuyenDung", employee.NgayTuyenDung);
                        cmd.Parameters.AddWithValue("@maNguoiQuanLy", employee.MaNguoiQuanLy ?? (object)DBNull.Value);
                        // Open connection and execute the command
                        connection.Open();
                        cmd.ExecuteNonQuery();

                        // Display success message
                        MessageBox.Show("Thêm nhân viên thành công!.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the error (in a real-world scenario, you'd log to a file or monitoring system)
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //try
            //{
            //    db.openConnection();
            //    SqlCommand cmd = new SqlCommand("sp_ThemNhanVien", db.getConnection);
            //    cmd.CommandType = CommandType.StoredProcedure;

            //    cmd.Parameters.AddWithValue("@MaNV", maNV);
            //    cmd.Parameters.AddWithValue("@HoTen", hoTen);
            //    cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
            //    cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
            //    cmd.Parameters.AddWithValue("@SDT", sdt);
            //    cmd.Parameters.AddWithValue("@AnhDaiDien", anhDaiDien ?? (object)DBNull.Value);
            //    cmd.Parameters.AddWithValue("@TenTK", tenTK);
            //    cmd.Parameters.AddWithValue("@MKhau", matKhau);
            //    cmd.Parameters.AddWithValue("@NgTuyenDung", ngTuyenDung);
            //    cmd.Parameters.AddWithValue("@MaNguoiQuanLy", maNguoiQuanLy ?? (object)DBNull.Value);
                
            //    Console.WriteLine(cmd.ExecuteNonQuery());
                
            //    int result = cmd.ExecuteNonQuery();
            //    return result > 0;
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Hãy nhập đầy đủ thông tin");
            //    return false;
            //}
            //finally
            //{
            //    db.closeConnection();
            //}
        }
        public DataTable TimKiemNhanVien(string keyword)
        {
            try
            {
                db.openConnection();
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.F_TimKiemHoaDon(@keyword)", db.getConnection);
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
                db.closeConnection();
            }
        }

    }


}



