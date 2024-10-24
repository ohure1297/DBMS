using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangTuChon
{
    public static class GetTable
    {
        public static DataTable LoadTable(string sqlquery)
        {
            DBConn.ConnOpen();
            SqlCommand cmd = new SqlCommand(sqlquery, DBConn.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            DBConn.ConnClose();
            return dataTable;
        }

        public static DataTable getEmployees()
        {
            string sqlquery = "SELECT * FROM v_ThongTinNhanVien";
            return LoadTable(sqlquery);
        }

        public static DataTable loadProducts()
        {
            string sqlquery = "SELECT * FROM v_DanhSachSanPham";
            return LoadTable(sqlquery);
        }

        public static DataTable shiftDivision()
        {
            string sqlquery = "SELECT * FROM v_BangPhanCa";
            return LoadTable(sqlquery);
        }
    }
}
