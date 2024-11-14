using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace QL.Models
{
    public class DBConnection
    {

        SqlConnection conn = new SqlConnection("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=CuaHangTuChon;Integrated Security=True;");
        //Set conn null để sau này sau khi đăng nhập mới sử dụng hàm để set conn lại sau theo chức vụ, tạm thời để như cũ nhằm để test
        public SqlConnection getConnection
        {
            get
            {
                return conn;
            }
        }

        public void changeStrConnectToNhanVien()
        {
            conn = new SqlConnection("Data Source = (localdb)\\mssqllocaldb; Initial Catalog = CuaHangTienLoi; Persist Security Info = True; User ID = nhanvien; Password = nhanvien");
        }

        public void changeStrConnectToQuanLy()
        {
            conn = new SqlConnection("Data Source = (localdb)\\mssqllocaldb; Initial Catalog = CuaHangTienLoi; Persist Security Info = True; User ID = quanly; Password = quanly");
        }

        public void openConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void closeConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
