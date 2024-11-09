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

        private ReceiptDAO receiptDAO = new ReceiptDAO();

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

                    string productId = row["MaSPham"].ToString();
                    string productName = row["TenSPham"].ToString();
                    string currPrice = row["GiaSauKhuyenMai"].ToString() + "đ";
                    string price = row["GiaBan"].ToString() + "đ";
                    string discount = "-" + row["MucKhuyenMai"].ToString() + "%";

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
                    

                    
                    uCProduct.ProductId = productId;
                    uCProduct.ProductName = productName;
                    uCProduct.CurrentPrice = currPrice;


                    if (int.Parse(row["SoTienDuocKhuyenMai"].ToString()) != 0)
                    {
                        uCProduct.Price = price;
                        uCProduct.Discount = discount;

                    }
                    else
                    {
                        uCProduct.Price = string.Empty;
                        uCProduct.Discount = string.Empty;
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




                        dgvHoaDon.Rows.Add(prodUC.ProductId, prodUC.ProductName, 1, prodUC.CurrentPrice, prodUC.CurrentPrice);

                        receiptDAO.AddReceiptInfo(new ReceiptInfo(prodUC.ProductId, 1));
                        int tongTien = receiptDAO.ReturnReceiptTotalMoney();
                        lblSoTienTongCong.Text = tongTien.ToString() + "đ";


                    };

                    flowPanelSanPham.Controls.Add(uCProduct);
                }

               

            }         
        }
        private void SellingView_Load(object sender, EventArgs e)
        {
            receiptDAO.AddReceipt(new Receipt("Chưa thanh toán"));
            product = productDAO.DataTable_ProductOnSaleScreen();
            LoadProductUC(product);   
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchVal = tbx_Search.Text;
            string filter = cbFilter.Text;
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
            if(String.IsNullOrWhiteSpace(phoneNum))
            {
                lblThongBao.Text = "Chưa nhập thông tin khách hàng";
                return;
            }    
                
            customer = customerDAO.DataTable_CheckIfExists(phoneNum);

            if (customer.Rows.Count == 0) 
            {
                lblThongBao.Text = string.Empty;
                tbxCustomerName.Text = string.Empty;
                tbxPoint.Text = string.Empty;
                tbxPhoneNum.Text = string.Empty;

            }
            else
            {
                lblThongBao.Text = string.Empty;
                tbxCustomerName.Text = customer.Rows[0]["TenKhachHang"].ToString();
                tbxPoint.Text = customer.Rows[0]["DiemTichLuy"].ToString();
            }    
            

            
        }

        private void AddNewButton_SellingView_Click(object sender, EventArgs e)
        {
            //string 
            //if(String.IsNullOrWhiteSpace())
        }

        private void dgvHoaDon_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dgvHoaDon.Columns[e.ColumnIndex].Name == "Qty")
            {
                string productPriceStr = dgvHoaDon.Rows[e.RowIndex].Cells["Price"].Value.ToString();
                productPriceStr = productPriceStr.Remove(productPriceStr.Length - 1);
                int productPrice = int.Parse(productPriceStr);
                int quan = int.Parse(dgvHoaDon.Rows[e.RowIndex].Cells["Qty"].Value.ToString());
                dgvHoaDon.Rows[e.RowIndex].Cells["Total"].Value = quan * productPrice + "đ";
                receiptDAO.UpdateProductQuantity(new ReceiptInfo(dgvHoaDon.Rows[e.RowIndex].Cells["Id"].Value.ToString(), quan));
                int tongTien = receiptDAO.ReturnReceiptTotalMoney();
                lblSoTienTongCong.Text = tongTien.ToString() + "đ";
            }
        }

        private void btnMoneyConfirm_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(tbxTienKhachDua.Text))
            {
                int tienKhachDua = int.Parse(tbxTienKhachDua.Text);
                receiptDAO.UpdateReceipt(new Receipt(tienKhachDua, "Đã thanh toán"));
                receiptDAO.EndReceiptProcess();
                lblSoTienThoi.Text = receiptDAO.ReturnChangedMoney().ToString() + "đ";

            }
            else
            {
                MessageBox.Show("Chưa nhập số tiền khách hàng đưa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrWhiteSpace(tbxTienKhachDua.Text))
            {           
                MessageBox.Show("Đã thanh toán thành công");
                dgvHoaDon.Rows.Clear();
                tbxTienKhachDua.Text = string.Empty;
                lblSoTienTongCong.Text = string.Empty;
                lblSoTienThoi.Text = string.Empty;
                SellingView_Load(sender, e);

            }
            else
            {
                MessageBox.Show("Chưa nhập số tiền khách hàng đưa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
