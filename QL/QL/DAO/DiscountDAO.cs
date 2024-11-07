﻿using System;
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
            try
            {
                dbCon.openConnection();

                SqlCommand cmd = new SqlCommand("SELECT * FROM V_DsKhuyenMai", dbCon.getConnection);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable discountTable = new DataTable();
                adapter.Fill(discountTable);

                return discountTable;
            }
            catch (Exception ex)
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
            dbCon.openConnection();

            SqlCommand cmd = new SqlCommand("sp_TimKiemKhuyenMaiTheoMa", dbCon.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaKhuyenMai", SqlDbType.Text).Value = makhuyenmai;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable discountTable = new DataTable();
            adapter.Fill(discountTable);

            return discountTable;
        }

        public DataTable FindDiscountByName(string tenkhuyenmai)
        {
            dbCon.openConnection();

            SqlCommand cmd = new SqlCommand("SELECT * FROM fn_TimKiemKhuyenMaiTheoTen (@TenKhuyenMai)", dbCon.getConnection);

            cmd.Parameters.AddWithValue("@TenKhuyenMai", SqlDbType.Text).Value = tenkhuyenmai;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable discountTable = new DataTable();
            adapter.Fill(discountTable);

            return discountTable;
        }

        public void AddDiscount (Discount discount)
        {
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
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm dịch vụ thành công");
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

        }
    }
}
