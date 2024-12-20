﻿using Guna.UI2.WinForms;
using QL.DAO;
using QL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL.Views
{
    public partial class ProductsView : Form
    {
        private ProductDAO productDAO = null;

        private Employee user = null;
        public ProductsView()
        {
            InitializeComponent();
        }


        public ProductsView(Employee userVal)
        {
            InitializeComponent();
            user = userVal;
            productDAO = new ProductDAO(userVal);
        }


        private void ProductsView_Load(object sender, EventArgs e)
        {
            dgvProduct.DataSource = productDAO.DataTable_Product();
            //MessageBox.Show(dgvProduct[0, 2].Value.ToString());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddProductView view = new AddProductView(user);
            view.Show();
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 &&
                    dgvProduct.Columns[e.ColumnIndex].HeaderText != "Sửa" &&
                    dgvProduct.Columns[e.ColumnIndex].HeaderText != "Xóa")
            {
                DetailProductView detailView = new DetailProductView(user, dgvProduct.Rows[e.RowIndex].Cells["MaSPham"].Value.ToString());  
                detailView.Show();
            }
            else if (dgvProduct.Columns[e.ColumnIndex].HeaderText.Equals("Xóa"))
            {
                Product product = new Product()
                {
                    MaSP = dgvProduct.Rows[e.RowIndex].Cells["MaSPham"].Value.ToString()
                };
                productDAO.DeleteProduct(product);
            }

        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("Content Cell click");
            
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgvProduct.DataSource = productDAO.DataTable_ProductSearchByName(tbxSearch.Text);
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFilter.Text == "Giá từ cao đến thấp")
                dgvProduct.DataSource = productDAO.GiaCaoDenThap();
            else if (cbFilter.Text == "Giá từ thấp đến cao")
                dgvProduct.DataSource = productDAO.GiaThapDenCao();
            else
                dgvProduct.DataSource = productDAO.CoKhuyenMai();
        }
    }
}
