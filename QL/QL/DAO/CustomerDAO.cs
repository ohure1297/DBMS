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
    public class CustomerDAO
    {
        DBConnection db = new DBConnection();
        public DataTable DataTable_Customer()
        {
            DataTable dt = new DataTable();

            string query = "SELECT * FROM V_DSKhachHang";

            
            try
            {
                db.openConnection();

                using (SqlCommand cmd = new SqlCommand(query, db.getConnection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            

            return dt;
        }

        public DataTable DataTable_SearchByName(string searchStr)
        {
            DataTable dt = new DataTable();

            try
            {
                
                string query = "SELECT * FROM F_CustomerSearchByName(@Name)";

                using (SqlCommand command = new SqlCommand(query, db.getConnection))
                {
                    command.Parameters.AddWithValue("@Name", searchStr);

                    db.openConnection();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return dt;
        }

        public DataTable DataTable_SearchBySDT(string searchStr)
        {
            DataTable dt = new DataTable();

            try
            {
                
                string query = "SELECT * FROM F_CustomerSearchBySDT(@SDT)";

                using (SqlCommand command = new SqlCommand(query, db.getConnection))
                {
                    command.Parameters.AddWithValue("@SDT", searchStr);
                    db.openConnection();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return dt;
        }
    }
}
