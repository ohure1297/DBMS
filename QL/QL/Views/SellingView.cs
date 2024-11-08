using GiaoDien;
using QL.DAO;
using QL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL.Views
{
    public partial class SellingView : Form
    {

        private ProductDAO productDAO = new ProductDAO();

        private CustomerDAO customerDAO = new CustomerDAO();

        private DataTable product = new DataTable();

        private DataTable customer = new DataTable();
        public SellingView()
        {
            InitializeComponent();
        }


        private void LoadProductUC(DataTable productTable)
        {
            flowPanelSanPham.Controls.Clear();

            foreach (DataRow row in productTable.Rows)
            {
                //MessageBox.Show(row["MaSPham"].ToString());
                if (row["MaSPham"] != null)
                {
                    UCProduct uCProduct = new UCProduct();

                    if (String.IsNullOrWhiteSpace(row["HinhAnh"].ToString()))
                    {
                        uCProduct.ProductImage = null;
                    }

                    else
                    {
                        byte[] img = (byte[])(row["HinhAnh"]);
                        MemoryStream ms = new MemoryStream(img);
                        uCProduct.ProductImage = Image.FromStream(ms);
                    }
                    

                    
                    uCProduct.ProductId = row["MaSPham"].ToString();
                    uCProduct.ProductName = row["TenSPham"].ToString();
                    uCProduct.CurrentPrice = row["GiaSauKhuyenMai"].ToString() + "đ";


                    if (int.Parse(row["SoTienDuocKhuyenMai"].ToString()) != 0)
                    {
                        uCProduct.Price = row["GiaBan"].ToString() + "đ";
                        uCProduct.Discount = "-" + row["MucKhuyenMai"].ToString() + "%";

                    }
                    else
                    {
                        uCProduct.Price = "";
                        uCProduct.Discount = "";
                    }

                    uCProduct.onSelect += (obj, ee) =>
                    {
                        UCProduct prodUC = (UCProduct)obj;
                        foreach (DataGridViewRow receiptRow in dgvHoaDon.Rows)
                        {
                            if (receiptRow.Cells["Id"].Value != null && receiptRow.Cells["Id"].Value.ToString().Equals(prodUC.ProductId))
                            {
                                MessageBox.Show("Đã có sản phẩm trong hóa đơn", "Đã tồn tại sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }

                        dgvHoaDon.Rows.Add(prodUC.ProductId, prodUC.ProductName, 1, prodUC.CurrentPrice);
                    };

                    flowPanelSanPham.Controls.Add(uCProduct);
                }

               

            }         
        }
        private void SellingView_Load(object sender, EventArgs e)
        {
            product = productDAO.DataTable_ProductOnSaleScreen();
            LoadProductUC(product);   
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchVal = tbx_Search.Text;
            string filter = cbFilter.Text;
            MessageBox.Show(searchVal + " " + filter);
            if (filter.Equals("Tên SP"))
            {
                product = productDAO.DataTable_ProductOnScreenSearchByName(searchVal);
            }    
            else if (filter.Equals("Mã SP"))
            {
                product = productDAO.DataTable_ProductOnScreenSearchById(searchVal);
            }
            LoadProductUC(product);
        }

        private void PtbProductImg_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void lblPoint_Click(object sender, EventArgs e)
        {

        }

        private void tbxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckButton_SellingView_Click(object sender, EventArgs e)
        {
            string phoneNum = tbxPhoneNum.Text;
            //if(String.IsNullOrWhiteSpace(phoneNum))
                //lblThongBao.Text = "Chưa nhập thông tin khách hàng"
            customer = customerDAO.DataTable_SearchBySDT(phoneNum);
            if (customer.Rows.Count == 0) 
            {
                lblThongBao.Text = "Chưa có thông tin khách hàng này";
            }
            else
            {

            }    
            
            
        }
    }
}
