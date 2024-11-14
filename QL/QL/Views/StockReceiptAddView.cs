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
        List<StockReceiptProducts> productsList = new List<StockReceiptProducts>();
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
                        StockReceiptProducts product = new StockReceiptProducts
                        {
                            MaSPham = dgvStockProductList.Rows[row.Index].Cells["MaSPham"].Value.ToString(),
                            SoLuongNhap = Convert.ToInt32(dgvStockProductList.Rows[row.Index].Cells["colProductNumber"].Value)
                        };
                        productsList.Add(product);
                    }
                    else
                    {
                        continue;
                    }
                }
                stockDAO.AddStockReceipt(productsList);
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
            }
        }

        private void dgvStockProductList_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvStockProductList.IsCurrentCellDirty)
            {
                dgvStockProductList.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
    }
}
