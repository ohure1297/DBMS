using QL.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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

    }
}

