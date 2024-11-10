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
    public partial class AddProductView : Form
    {
        private string filePath = null;
        ProductDAO ProductDAO = new ProductDAO();
        public AddProductView()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            byte[] imageBinaryData = File.ReadAllBytes(filePath);
            Product product = new Product()
            {
                MaSP = tbxId.Text,
                TenSP = tbxName.Text,
                HinhAnh = imageBinaryData,
                NhaSanXuat = tbxProvider.Text,
                GiaBan = int.Parse(tbxSellPrice.Text),
                TonKho = int.Parse((tbxQuantity.Text)),
                NhomSanPham = cbCategory.Text,
                TinhTrang = "Còn hàng"
            };
            
            ProductDAO.Add_Product(product);

        }

        private void ptbProductImg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected file path
                    filePath = openFileDialog.FileName;
                    ptbProductImg.Image = Image.FromFile(filePath);
                }
            }
        }
    }
}
