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
    public class EmployeeDAO
    {
        DBConnection db = new DBConnection();
        public DataTable mayTinhTable()
        {
            try
            {
                db.openConnection();
                SqlCommand cmd = new SqlCommand("SELECT * FROM SV", db.getConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable employeeTable = new DataTable();
                adapter.Fill(employeeTable);
                return employeeTable;
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
