using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Controls;
using QL.Models;

namespace QL.DAO
{
    public class StockReceiptDAO
    {
        DBConnection dbCon = new DBConnection();
        public StockReceiptDAO() { }

        public DataTable LoadStockReceipts()
        {
            DataTable stockReceipt_table = new DataTable();
            try
            {
                dbCon.openConnection();

                SqlCommand cmd = new SqlCommand("SELECT * FROM V_DsPhieuNhap", dbCon.getConnection);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                stockReceipt_table = new DataTable();
                adapter.Fill(stockReceipt_table);

                return stockReceipt_table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbCon.closeConnection();
            }
            return stockReceipt_table;
        }
        public DataTable FindStockReceipt(string maPhieuNhap)
        {
            dbCon.openConnection();

            SqlCommand cmd = new SqlCommand("sp_TimKiemPhieuNhap", dbCon.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaPhieuNhap", SqlDbType.Text).Value = maPhieuNhap;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable stockReceipt_table = new DataTable();
            adapter.Fill(stockReceipt_table);

            return stockReceipt_table;
        }

        public DataTable GetStockReceiptProduct(string maPhieuNhap)
        {
            dbCon.openConnection();

            SqlCommand cmd = new SqlCommand("sp_ChiTietPhieuNhap", dbCon.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaPhieuNhap", SqlDbType.Text).Value = maPhieuNhap;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable stockReceipt_table = new DataTable();
            adapter.Fill(stockReceipt_table);

            return stockReceipt_table;
        }

        public DataTable AddStockReceipt(StockReceipt stockReceipt)
        {
            dbCon.openConnection();
        }
    }
}
