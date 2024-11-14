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

        public void NhanVienConnect()
        {
            db.changeStrConnectToNhanVien();
        }

        public void QuanLyConnect()
        {
            db.changeStrConnectToQuanLy();
        }


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
            catch (SqlException ex)
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
            catch (SqlException ex)
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
                                HinhAnh = reader["HinhAnh"] != DBNull.Value ? (byte[])reader["HinhAnh"] : null,
                                NhaSanXuat = (string)reader["NhaSanXuat"],
                                GiaBan = (int)reader["GiaBan"],
                                TonKho = (int)reader["TonKho"],
                                NhomSanPham = (string)reader["NhomSPham"]
                            };
                        }

                    }
                }
            }
            
            catch (SqlException ex)
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
            catch (SqlException ex)
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
            catch (SqlException ex)
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
            catch (SqlException ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return dt;
        }

        public DataTable DataTable_ProductOnScreenSearchByProvider(string searchStr)
        {
            DataTable dt = new DataTable();

            try
            {
                string query = "SELECT * FROM fn_ProductOnScreenSearchByProvider(@ProviderName)";

                db.openConnection();


                using (SqlCommand command = new SqlCommand(query, db.getConnection))
                {
                    command.Parameters.AddWithValue("@ProviderName", searchStr);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return dt;
        }

        public DataTable DataTable_ProductOnScreenSearchByProductType(string searchStr)
        {
            DataTable dt = new DataTable();

            try
            {
                string query = "SELECT * FROM fn_ProductOnScreenSearchByProductType(@ProductType)";

                db.openConnection();


                using (SqlCommand command = new SqlCommand(query, db.getConnection))
                {
                    command.Parameters.AddWithValue("@ProductType", searchStr);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return dt;
        }

        public DataTable DataTable_ProductOnScreenSortFromLowToHigh()
        {
            DataTable dt = new DataTable();

            try
            {
                string query = "SELECT * FROM V_DsSanPhamBanHang order by GiaSauKhuyenMai ASC";

                db.openConnection();


                using (SqlCommand command = new SqlCommand(query, db.getConnection))
                {

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return dt;
        }

        public DataTable DataTable_ProductOnScreenSortFromHighToLow()
        {
            DataTable dt = new DataTable();

            try
            {
                string query = "SELECT * FROM V_DsSanPhamBanHang order by GiaSauKhuyenMai DESC";

                db.openConnection();


                using (SqlCommand command = new SqlCommand(query, db.getConnection))
                {

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }

            }
            catch (SqlException ex)
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
                using (SqlConnection connection = db.getConnection)
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
            catch (SqlException ex)
            {
                // Log the error (in a real-world scenario, you'd log to a file or monitoring system)
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteProduct(Product product)
        {
            try
            {
                using (SqlConnection connection = db.getConnection)
                {
                    string query = "EXEC [dbo].[Proc_DeteleProduct] @Ma = @MaSPham;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                     
                        command.Parameters.AddWithValue("@MaSPham", product.MaSP);
                        

                      
                        connection.Open();
                        command.ExecuteNonQuery();

                   
                        MessageBox.Show("Delete added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (SqlException ex)
            {
               
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateProduct(Product product)
        {
            MessageBox.Show(product.MaSP);
            try
            {
                using (SqlConnection connection = db.getConnection)
                {
                    string query = "EXEC [dbo].[Proc_UpdateProduct] " +
               "@MaSPham, " +
               "@TenSPham, " +
               "@HinhAnh, " +
               "@NhaSanXuat, " +
               "@GiaBan, " +
               "@TonKho, " +
               "@NhomSPham;";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to the command
                        command.Parameters.AddWithValue("@MaSPham", product.MaSP);
                        command.Parameters.AddWithValue("@TenSPham", product.TenSP);

                        // Assuming the product.HinhAnh is a byte[] representing the image
                        command.Parameters.AddWithValue("@HinhAnh", product.HinhAnh);

                        command.Parameters.AddWithValue("@NhaSanXuat", product.NhaSanXuat);
                        command.Parameters.AddWithValue("@GiaBan", product.GiaBan);
                        command.Parameters.AddWithValue("@TonKho", product.TonKho);
                        command.Parameters.AddWithValue("@NhomSPham", product.NhomSanPham);

                        // Open connection and execute the command
                        connection.Open();
                        command.ExecuteNonQuery();

                        // Display success message
                        MessageBox.Show("Sửa sản phẩm thành công.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (SqlException ex)
            {
                // Log the error (in a real-world scenario, you'd log to a file or monitoring system)
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable GiaCaoDenThap()
        {
            DataTable dt = new DataTable();

            string query = "SELECT * FROM V_DsSanPham ORDer by GiaBan DesC";

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
            catch (SqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }


            return dt;
        }

        public DataTable GiaThapDenCao()
        {
            DataTable dt = new DataTable();

            string query = "SELECT * FROM V_DsSanPham ORDer by GiaBan ASC";
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
            catch (SqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }


            return dt;
        }

        public DataTable CoKhuyenMai()
        {
            DataTable dt = new DataTable();

            string query = "SELECT * FROM V_DsSanPham where TinhTrangKhuyenMai = N'Hoạt động'";
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
            catch (SqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }


            return dt;
        }
    }
}