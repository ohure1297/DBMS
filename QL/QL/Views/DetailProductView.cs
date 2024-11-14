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
        private bool isEdit = false;
        private byte[] imageBinaryData = null;
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
            cbCategory.Text = product.NhomSanPham;
            tbxQuantity.Text = product.TonKho.ToString();
            if(product.HinhAnh != null)
            {
                MemoryStream ms = new MemoryStream(product.HinhAnh);
                ptbProductImg.Image = Image.FromStream(ms);
            }
            

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (isEdit == false)
            {
                isEdit = true;
                btn_edit.Text = "Finish";
                tbxName.Enabled = true;
                tbxProvider.Enabled = true;
                tbxSellPrice.Enabled = true;
                cbCategory.Enabled = true;
                ptbProductImg.Enabled = true;
                tbxQuantity.Enabled = true;
                imageBinaryData = GetImageBytesFromPictureBox(ptbProductImg);

            }
            else
            {
                
                Product product = new Product()
                {
                    MaSP = tbxId.Text,
                    TenSP = tbxName.Text,
                    HinhAnh = imageBinaryData,
                    NhaSanXuat = tbxProvider.Text,
                    GiaBan = int.Parse(tbxSellPrice.Text),
                    TonKho = int.Parse((tbxQuantity.Text)),
                    NhomSanPham = cbCategory.Text,
                };

                productDAO.UpdateProduct(product);

                isEdit = false;
                btn_edit.Text = "Edit";
                tbxName.Enabled = false;
                tbxProvider.Enabled = false;
                tbxSellPrice.Enabled = false;
                ptbProductImg.Enabled = false;
                cbCategory.Enabled = false;
                tbxQuantity.Enabled = false;
                
            }
            
        }

        private void ptbProductImg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected file path
                    string filePath = openFileDialog.FileName;
                    ptbProductImg.Image = Image.FromFile(filePath);
                }
            }
        }

        public byte[] GetImageBytesFromPictureBox(PictureBox pictureBox)
        {
            if (pictureBox.Image == null)
                return null;

            using (MemoryStream ms = new MemoryStream())
            {
                pictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                return ms.ToArray();
            }
        }
    }
}
