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
    public class ProductDAO
    {
        DBConnection db = new DBConnection();


        public DataTable DataTable_Product()
        {
            DataTable dt = new DataTable();

            string query = "SELECT * FROM V_DsSanPham";

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

        public DataTable DataTable_ProductOnSaleScreen()
        {
            DataTable dt = new DataTable();

            string query = "SELECT * FROM V_DsSanPhamBanHang";

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

        public Product DataTable_DetailProduct(string p)
        {
            Product product = null;
            string query = "Select * From F_GetDetailProduct(@MaSPham)";
            

            try
            {
                using (SqlCommand command = new SqlCommand(query, db.getConnection))
                {
                    command.Parameters.AddWithValue("@MaSPham", p);

                    db.openConnection();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            product = new Product
                            {

                                MaSP = (string)reader["MaSPham"],
                                TenSP = (string)reader["TenSPham"],
                                HinhAnh = (string)reader["HinhAnh"],
                                NhaSanXuat = (string)reader["NhaSanXuat"],
                                GiaBan = (int)reader["GiaBan"],
                                TonKho = (int)reader["TonKho"],
                                NhomSanPham = (string)reader["NhomSPham"]
                            };
                        }

                    }
                }
            }
            
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
         

            return product;
        }

        public DataTable DataTable_ProductSearchByName(string searchStr)
        {
            DataTable dt = new DataTable();

            try
            {

                db.openConnection();

                
                string query = "SELECT * FROM F_ProductSearchByName(@Name)";

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


        public DataTable DataTable_ProductOnScreenSearchByName(string searchStr)
        {
            DataTable dt = new DataTable();

            try
            {

                db.openConnection();

                string query = "SELECT * FROM fn_ProductOnScreenSearchByName(@Name)";

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

        public DataTable DataTable_ProductOnScreenSearchById(string searchStr)
        {
            DataTable dt = new DataTable();

            try
            {
                string query = "SELECT * FROM fn_ProductOnScreenSearchById(@Id)";

                db.openConnection();


                using (SqlCommand command = new SqlCommand(query, db.getConnection))
                {
                    command.Parameters.AddWithValue("@Id", searchStr);

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





        //public DataTable Data_Filter(string filter)
        //{
        //    DataTable dt = new DataTable();

        //    try
        //    {
        //        using (SqlConnection connection = new SqlConnection(connectionString))
        //        {
        //            string query = "SELECT * FROM F_SearchByName(@Name)";

        //            using (SqlCommand command = new SqlCommand(query, connection))
        //            {
        //                command.Parameters.AddWithValue("@Name", searchStr);

        //                connection.Open();

        //                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
        //                {
        //                    adapter.Fill(dt);
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"An error occurred: {ex.Message}");
        //    }

        //    return dt;
        //}

    }
}