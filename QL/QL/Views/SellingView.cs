using GiaoDien;
using QL.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL.Views
{
    public partial class SellingView : Form
    {

        private ProductDAO productDAO = new ProductDAO();
        public SellingView()
        {
            InitializeComponent();
        }

        private void SellingView_Load(object sender, EventArgs e)
        {
            DataTable product = productDAO.DataTable_ProductOnSaleScreen();
            foreach(DataRow row in product.Rows)
            {
                if(row["MaSPham"] != null)
                {
                    UCProduct uCProduct = new UCProduct();
                    uCProduct.LblName.Text = row["TenSPham"].ToString();
                    uCProduct.LblCurrentPrice.Text = row["GiaSauKhuyenMai"].ToString() + "đ";
                    

                    if (int.Parse(row["GiaBanDuocKhuyenMai"].ToString()) != 0)
                    {
                        uCProduct.LblPrice.Text = row["GiaBan"].ToString() + "đ";
                        uCProduct.LblDiscount.Text = "-" + row["MucKhuyenMai"].ToString() + "%";

                    }
                    else
                    {
                        uCProduct.LblPrice.Text = "";
                        uCProduct.LblDiscount.Text = "";
                    }
 
                        
                    flowPanelSanPham.Controls.Add(uCProduct); 

                }    
                
            }    
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

        
    }
}
