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
        private static string connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=CuaHangTienLoi;Integrated Security=True";

        public DataTable DataTable_Product()
        {
            DataTable dt = new DataTable();

            string query = "SELECT * FROM V_DsSanPham";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
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
            }

            return dt;
        }

        public DataTable DataTable_ProductOnSaleScreen()
        {
            DataTable dt = new DataTable();

            string query = "SELECT * FROM V_DsSanPhamBanHang";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
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
            }

            return dt;
        }

        public Product DataTable_DetailProduct(string p)
        {
            Product product = null;
            string query = "Select * From F_GetDetailProduct(@MaSPham)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaSPham", p);

                    connection.Open();

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

            return product;
        }

        public DataTable DataTable_ProductSearchByName(string searchStr)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM F_ProductSearchByName(@Name)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", searchStr);

                        connection.Open();

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dt);
                        }
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