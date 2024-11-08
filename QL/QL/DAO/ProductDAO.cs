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
        String connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=CuaHangTienLoi;Integrated Security=True;Encrypt=True";

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
                                HinhAnh = (byte[])reader["HinhAnh"],
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

        public void Add_Product(Product product)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "EXEC [dbo].[Proc_AddNewProduct] " +
                                   "@MaSPham = @Ma, " +
                                   "@TenSPham = @Ten, " +
                                   "@HinhAnh = @Anh, " +
                                   "@NhaSanXuat = @NSX, " +
                                   "@GiaBan = @Gia, " +
                                   "@TonKho = @SL, " +
                                   "@TinhTrang = @TrangThai, " +
                                   "@NhomSPham = @NhomSP;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to the command
                        command.Parameters.AddWithValue("@Ma", product.MaSP);
                        command.Parameters.AddWithValue("@Ten", product.TenSP);

                        // Assuming the product.HinhAnh is a byte[] representing the image
                        command.Parameters.AddWithValue("@Anh", product.HinhAnh);

                        command.Parameters.AddWithValue("@NSX", product.NhaSanXuat);
                        command.Parameters.AddWithValue("@Gia", product.GiaBan);
                        command.Parameters.AddWithValue("@SL", product.TonKho);
                        command.Parameters.AddWithValue("@TrangThai", product.TinhTrang);
                        command.Parameters.AddWithValue("@NhomSP", product.NhomSanPham);

                        // Open connection and execute the command
                        connection.Open();
                        command.ExecuteNonQuery();

                        // Display success message
                        MessageBox.Show("Product added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the error (in a real-world scenario, you'd log to a file or monitoring system)
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteProduct(Product product)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "EXEC [dbo].[Proc_DeleteProduct] @Ma = @MaSPham;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to the command
                        command.Parameters.AddWithValue("@MaSPham", product.MaSP);
                        

                        // Open connection and execute the command
                        connection.Open();
                        command.ExecuteNonQuery();

                        // Display success message
                        MessageBox.Show("Product added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the error (in a real-world scenario, you'd log to a file or monitoring system)
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}