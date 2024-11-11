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

        public DataTable DataTable_CheckIfExists(string searchStr)
        {
            DataTable dt = new DataTable();

            try
            {

                db.openConnection();

                string query = "sp_KiemtraKhachHangDaTonTai";

                using (SqlCommand command = new SqlCommand(query, db.getConnection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@SDT", searchStr);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }

            }
            catch (SqlException ex)
            {
                if (ex.Errors[0].Class == 16)
                {
                    MessageBox.Show(ex.Message, "Đã tồn tại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }    
            }

            return dt;
        }

        public DataTable DataTable_SearchByName(string searchStr)
        {
            DataTable dt = new DataTable();

            try
            {

                db.openConnection();

                string query = "SELECT * FROM F_CustomerSearchByName(@Name)";

                using (SqlCommand command = new SqlCommand(query, db.getConnection))
                {
                    command.Parameters.AddWithValue("@Name", searchStr);

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

                db.openConnection();

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

        public Customer GetCustomer(string SDT)
        {
            Customer customer = null;
            string query = "Select * From F_getCustomerbySDT(@SDT)";


            try
            {
                using (SqlCommand command = new SqlCommand(query, db.getConnection))
                {
                    command.Parameters.AddWithValue("@SDT", SDT);

                    db.openConnection();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            customer = new Customer()
                            {
                                PhoneNum = (string)reader["SDT"],
                                Name = (string)reader["TenKhachHang"],
                                Point  = (int)reader["DiemTichLuy"]
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return customer;
        }

        public void AddCustomer(Customer customer)
        {
            try
            {
                db.openConnection();

                string query = "EXEC [dbo].[proc_AddNewCustomer] @SDT, @TenKhachHang";

                using (SqlCommand cmd = new SqlCommand(query, db.getConnection))
                {
                    cmd.Parameters.AddWithValue("@SDT", customer.PhoneNum);
                    cmd.Parameters.AddWithValue("@TenKhachHang", customer.Name);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Handle or log the exception
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                db.closeConnection();
            }
        }

        public void EditCustomer(Customer customer)
        {
            try
            {
                db.openConnection();

                string query = "EXEC [dbo].[proc_EditCustomer] @SDT, @TenKhachHang, @DiemTichLuy";

                using (SqlCommand cmd = new SqlCommand(query, db.getConnection))
                {
                    cmd.Parameters.AddWithValue("@SDT", customer.PhoneNum);
                    cmd.Parameters.AddWithValue("@TenKhachHang", customer.Name);
                    cmd.Parameters.AddWithValue("@DiemTichLuy", customer.Point);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Handle or log the exception
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                db.closeConnection();
            }
        }

        public void DeleteCustomer(string SDT)
        {
            try
            {
                db.openConnection();

                string query = "EXEC [dbo].[proc_DeleteCustomer] @SDT";

                using (SqlCommand cmd = new SqlCommand(query, db.getConnection))
                {
                    cmd.Parameters.AddWithValue("@SDT", SDT);


                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                db.closeConnection();
            }
        }

        public void UsePoint(Customer customer)
        {
            
            try
            {
                db.openConnection();

                SqlCommand cmd = new SqlCommand("sp_SuDungDiemKhachHang", db.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SDT", customer.PhoneNum);

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Use Point");
            }
            finally
            {
                db.closeConnection();
            }
            
        }

    }
}
