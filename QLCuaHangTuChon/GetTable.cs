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
        public static DataTable LoadTable(DBConn db, string sqlquery)
        {
            SqlCommand cmd = new SqlCommand(sqlquery, db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public static DataTable getEmployees(DBConn db)
        {
            string sqlquery = "SELECT * FROM v_ThongTinNhanVien";
            return LoadTable(db, sqlquery);
        }

        public static DataTable loadProducts(DBConn db)
        {
            string sqlquery = "SELECT * FROM v_DanhSachSanPham";
            return LoadTable(db, sqlquery);
        }

        public static DataTable shiftDivision(DBConn db)
        {
            string sqlquery = "SELECT * FROM v_BangPhanCa";
            return LoadTable(db, sqlquery);
        }

        public static DataTable stockReceipts(DBConn db)
        {
            string sqlquery = "SELECT * FROM v_ChiTietDonNhap";
            return LoadTable(db, sqlquery);
        }

        public static DataTable salesReceipts(DBConn db)
        {
            string sqlquery = "SELECT * FROM v_DanhMucHoaDon";
            return LoadTable(db, sqlquery);
        }

        public static DataTable shiftSchedule(DBConn db)
        {
            string sqlquery = "SELECT * FROM CALAMVIEC";
            return LoadTable(db, sqlquery);
        }
    }
}
