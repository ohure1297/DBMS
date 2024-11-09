using GiaoDien;
using QL.DAO;
using QL.Models;
using QL.Views;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QL.DAO
{
    public class ReceiptDAO
    {
        DBConnection db = new DBConnection();

        public DataTable GetAllReceipts()
        {
            try
            {
                db.openConnection();
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.HOADON", db.getConnection);
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
                db.closeConnection();
            }
        }
        public DataTable TimKiemHoaDon(string keyword)
        {
            try
            {
                db.openConnection();
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.TimKiemHoaDon(@keyword)", db.getConnection);
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
        public DataTable LayDanhSachChiTietHoaDon(string maHoaDon)
        {
            try
            {
                db.openConnection();
                SqlCommand cmd = new SqlCommand("sp_LayChiTietHoaDon", db.getConnection);
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
                db.closeConnection();
            }
        }

    }
}











