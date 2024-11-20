using QL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL.DAO
{
    public class LoginDAO
    {   
        DBConnection db = null;
        public LoginDAO() 
        {
            db = new DBConnection();
        }

        public DataTable LoginCheck(string username, string password)
        {
            DataTable dt = new DataTable();

            string query = "SELECT * FROM dbo.fn_KiemTraDangNhap(@userName, @password)";
            try
            {
                db.openConnection();

                using (SqlCommand cmd = new SqlCommand(query, db.getConnection))
                {
                    cmd.Parameters.AddWithValue("@userName", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }


            return dt;
        }
    }
}
