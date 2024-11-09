using QL.DAO;
using QL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QL.Views
{
    public partial class DetailProductView : Form
    {
        private string productID;
        readonly ProductDAO productDAO = new ProductDAO();
        public DetailProductView()
        {
            InitializeComponent();
        }

        public DetailProductView(string productID)
        {
            InitializeComponent();
            this.productID = productID;
        }
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DetailProductView_Load(object sender, EventArgs e)
        {
            
            Product product = productDAO.DataTable_DetailProduct(productID);
            tbxId.Text = product.MaSP;
            tbxName.Text = product.TenSP;
            tbxProvider.Text = product.NhaSanXuat;
            tbxSellPrice.Text = product.GiaBan.ToString();
            tbxCategory.Text = product.NhomSanPham;
            MemoryStream ms = new MemoryStream(product.HinhAnh);
            ptbProductImg.Image = Image.FromStream(ms);

        }
    }
}
