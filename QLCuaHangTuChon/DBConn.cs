using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangTuChon
{
    public class DBConn
    {
        private static string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\QLCuaHang.mdf;Integrated Security=True";
        private static SqlConnection connection;

        public static SqlConnection getConnection
        {
            get { return connection; }         
        }
        public static void ConnOpen()
        {
            try
            {
                connection = new SqlConnection(connStr);

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void ConnClose()
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }

        }
    }
}
