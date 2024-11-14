using GiaoDien;
using Guna.UI2.WinForms;
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


        private void ClearEverything()
        {
            flowPanelSanPham.Controls.Clear();
            dgvHoaDon.Rows.Clear();
            tbxCustomerName.Text = string.Empty;
            tbxPhoneNum.Text = string.Empty;
            tbxPoint.Text = string.Empty;
            tbxTienKhachDua.Text = string.Empty;
            tbx_Search.Text = string.Empty;
            lblSoTienTongCong.Text = string.Empty;
            lblSoTienThoi.Text = string.Empty;
            cbx_DungDiem.Checked = false; 
             
        }
        
        private void LoadProductUC(DataTable productTable)
        {
            ClearEverything();

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
                    
                    if (int.Parse(row["SoTienDuocKhuyenMai"].ToString()) != 0) //Có khuyến mãi
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


                        if(receiptDAO.AddReceiptInfo(new ReceiptInfo(prodUC.ProductId, 1)))
                            dgvHoaDon.Rows.Add(prodUC.ProductId, prodUC.ProductName, 1, prodUC.CurrentPrice, prodUC.CurrentPrice);

                        
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

            else if (filter.Equals("Loại SP"))
            {
                product = productDAO.DataTable_ProductOnScreenSearchByProductType(searchVal);
            }

            else if (filter.Equals("Nhà sản xuất"))
            {
                product = productDAO.DataTable_ProductOnScreenSearchByProvider(searchVal);
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
            tbxCustomerName.Enabled = false;
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
                cbx_DungDiem.Checked = false;
                tbxCustomerName.Text = customer.Rows[0]["TenKhachHang"].ToString();
                tbxPoint.Text = customer.Rows[0]["DiemTichLuy"].ToString();
            }    
            

            
        }

        private void AddNewButton_SellingView_Click(object sender, EventArgs e)
        {
           
            if(!String.IsNullOrWhiteSpace(tbxCustomerName.Text) && String.IsNullOrWhiteSpace(tbxPoint.Text))
            {
                Customer customer = new Customer(tbxPhoneNum.Text, tbxCustomerName.Text, 0);
                CustomerDAO customerDAO = new CustomerDAO();
                customerDAO.AddCustomer(customer);
                MessageBox.Show("Thêm khách hàng thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
            else
            {
                MessageBox.Show("Chưa nhập đủ thông tin khách hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tbxPhoneNum.Text = string.Empty;
            tbxCustomerName.Text = string.Empty;
            tbxCustomerName.Enabled = false;
            
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
                if(receiptDAO.UpdateProductQuantity(new ReceiptInfo(dgvHoaDon.Rows[e.RowIndex].Cells["Id"].Value.ToString(), quan)))
                {
                    int tongTien = receiptDAO.ReturnReceiptTotalMoney();
                    lblSoTienTongCong.Text = tongTien.ToString() + "đ";
                }
                else
                {
                    dgvHoaDon.Rows[e.RowIndex].Cells["Qty"].Value = 1;
                }

              
            }
        }

        

        private void btnPay_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrWhiteSpace(tbxTienKhachDua.Text) && dgvHoaDon.Rows.Count > 0)
            {
                int tienKhachDua = int.Parse(tbxTienKhachDua.Text);
                receiptDAO.UpdateReceipt(new Receipt(tienKhachDua, "Chưa thanh toán"));
                

                //Tích điểm cho khách hàng nếu có nhập thông tin khách hàng
                if (!String.IsNullOrWhiteSpace(tbxCustomerName.Text))
                {
                    if(cbx_DungDiem.Checked)
                    {
                        //Tru diem o day
                        CustomerDAO customerDAO = new CustomerDAO();
                        customerDAO.UsePoint(new Customer(tbxPhoneNum.Text));
                    }    

                    else
                    {
                        receiptDAO.AccumulatePoints(tbxPhoneNum.Text);
                    }
                    
                    
                }

                if(receiptDAO.EndReceiptProcess())
                {
                    receiptDAO.UpdateReceipt(new Receipt(tienKhachDua, "Đã thanh toán"));
                    MessageBox.Show("Đã thanh toán thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }    

                else
                {
                    return;
                }    






                
                SellingView_Load(sender, e);

            }
            else
            {
                MessageBox.Show("Chưa nhập số tiền khách hàng đưa hoặc chưa có sản phẩm nào trong hóa đơn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvHoaDon.Columns[e.ColumnIndex].Name == "DelColumn")
            {
                string id = dgvHoaDon.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                receiptDAO.DeleteProduct(new ReceiptInfo(id));
                dgvHoaDon.Rows.RemoveAt(e.RowIndex);
                lblSoTienTongCong.Text = receiptDAO.ReturnReceiptTotalMoney().ToString() + "đ";
            }    
        }
        private void cbx_DungDiem_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbx_DungDiem.Checked)
            {
                lblSoTienTongCong.Text = receiptDAO.ReturnReceiptTotalMoney().ToString() + "đ";
                tbxTienKhachDua.Enabled = true;
            }

            else if (!String.IsNullOrEmpty(tbxPhoneNum.Text))
            {
                if(dgvHoaDon.Rows.Count > 0)
                {
                    
                    int tongTienSau = receiptDAO.CheckMoneyIfUsePoint(new Customer(tbxPhoneNum.Text));
                    if(tongTienSau == 0)
                    {
                        
                        tbxTienKhachDua.Text = "0";
                        tbxTienKhachDua.Enabled = false;

                     
                    }

                    lblSoTienTongCong.Text = tongTienSau.ToString() + "đ";

                    


                }

                else if(cbx_DungDiem.Checked)
                {
                    MessageBox.Show("Chưa có tổng tiền để sử dụng điểm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbx_DungDiem.Checked = false;
                }

                
                    
                //CustomerDAO customerDAO = new CustomerDAO();
                //customerDAO.UsePoint(new Customer(tbxPhoneNum.Text));

            }

            else
            {
                if(cbx_DungDiem.Checked)
                {
                    MessageBox.Show("Chưa có thông tin khách hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbx_DungDiem.Checked = false;
                }
                    
            }
            
        }

        private void tbxTienKhachDua_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int tienKhachDua = int.Parse(tbxTienKhachDua.Text);
                receiptDAO.UpdateReceipt(new Receipt(tienKhachDua, "Chưa thanh toán"));

                receiptDAO.EndReceiptProcess();
                if (receiptDAO.ReturnChangedMoney() != -1)
                    lblSoTienThoi.Text = receiptDAO.ReturnChangedMoney().ToString() + "đ";
                else
                    lblSoTienThoi.Text = string.Empty;
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            tbxCustomerName.Enabled = true;
        }

        private void panelThongTin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedIndex == 4) //Cao đến thấp
            {
                product = productDAO.DataTable_ProductOnScreenSortFromHighToLow();
                LoadProductUC(product);
            }

            else if(cbFilter.SelectedIndex == 5) //Thấp đến cao
            {
                product = productDAO.DataTable_ProductOnScreenSortFromLowToHigh();
                LoadProductUC(product);
            }
            
        }
    }
}
