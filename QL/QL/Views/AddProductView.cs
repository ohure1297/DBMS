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
        
        private Employee user = null;

        ProductDAO ProductDAO = null;
        public AddProductView()
        {
            InitializeComponent();
        }

        public AddProductView(Employee userVal)
        {
            InitializeComponent();
            user = userVal;
            ProductDAO = new ProductDAO(userVal);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            byte[] imageBinaryData = null;
            if (filePath != null)
            {
                imageBinaryData = File.ReadAllBytes(filePath);
            }
            else
            {
                MessageBox.Show("Vui lòng thêm ảnh!");
                return;
            }
            
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
