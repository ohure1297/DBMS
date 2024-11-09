using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL.DAO;
using QL.Models;

namespace QL.Views
{
    public partial class StockReceiptAddView : Form
    {
        StockReceiptDAO stockDAO = new StockReceiptDAO();
        string maSP = null;
        int soluongnhap;
        int index;
        public StockReceiptAddView()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StockReceiptAddView_Load(object sender, EventArgs e)
        {
            try
            {
                dgvStockProductList.DataSource = stockDAO.LoadStockProductList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvStockProductList.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["colChooseProduct"].Value) == true)
                    {
                        maSP = dgvStockProductList.Rows[index].Cells["MaSPham"].Value.ToString();
                        soluongnhap = Convert.ToInt32(dgvStockProductList.Rows[index].Cells["colProductNumber"].Value);
                    }
                }
                stockDAO.AddStockReceipt(maSP, soluongnhap);
            }
            catch (SqlException ex)
            {
                if (ex.Errors[0].Class == 16)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvStockProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvStockProductList.Columns[e.ColumnIndex].Name == "colChooseProduct")
            {
                bool isChecked = dgvStockProductList.Rows[e.RowIndex].Cells["colChooseProduct"].Value != null
                         && (bool)dgvStockProductList.Rows[e.RowIndex].Cells["colChooseProduct"].Value;

                dgvStockProductList.Rows[e.RowIndex].Cells["colChooseProduct"].Value = !isChecked;
                dgvStockProductList.Rows[e.RowIndex].Cells["colProductNumber"].Value = 1;

                index = e.RowIndex;
            }
            else
            {
                index = 0;
            }
        }
    }
}
