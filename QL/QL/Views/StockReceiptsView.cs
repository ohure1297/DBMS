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
    public partial class StockReceiptsView : Form
    {
        StockReceiptDAO stockdao = new StockReceiptDAO();
        public StockReceiptsView()
        {
            InitializeComponent();
        }

        private void StockReceiptsView_Load(object sender, EventArgs e)
        {
            try
            { 
                dgvStockReceipt.DataSource = stockdao.LoadStockReceipts();
            }
            catch (Exception  ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StockReceiptAddView addStock = new StockReceiptAddView();
            addStock.ShowDialog();
        }

        private void dgvStockReceipt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvStockReceipt.Columns[e.ColumnIndex].Name == "colConfirm")
            {
                bool isChecked = dgvStockReceipt.Rows[e.RowIndex].Cells["colConfirm"].Value != null
                         && (bool)dgvStockReceipt.Rows[e.RowIndex].Cells["colConfirm"].Value;

                dgvStockReceipt.Rows[e.RowIndex].Cells["colConfirm"].Value = !isChecked;
            }
            else if (dgvStockReceipt.Columns[e.ColumnIndex].Name == "colDelete")
            {
                string maPhieuNhap = dgvStockReceipt.Rows[e.RowIndex].Cells["MaPhieuNhap"].Value.ToString();
                stockdao.DeleteStocReceipt(maPhieuNhap);
                dgvStockReceipt.DataSource = stockdao.LoadStockReceipts();
            }
            else
            {
                string maPhieuNhap = dgvStockReceipt.Rows[e.RowIndex].Cells["MaPhieuNhap"].Value.ToString();
                DetailStockReceiptView chitiet = new DetailStockReceiptView(maPhieuNhap);
                chitiet.ShowDialog();
            }
        }

        private void btnFindStockReceipt_Click(object sender, EventArgs e)
        {
            try
            {
                dgvStockReceipt.DataSource = stockdao.FindStockReceipt(tbxSearch.Text);
            }
            catch (SqlException ex)
            {
                if (ex.Errors[0].Class == 16)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnStockReceiptConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvStockReceipt.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["colConfirm"].Value) == true)
                    {
                        string maPhieuNhap = row.Cells["MaPhieuNhap"].Value.ToString();
                        string maNV = "NV001"; 

                        stockdao.ConfirmStockReceipt(maPhieuNhap, maNV);
                    }
                }
                dgvStockReceipt.DataSource = stockdao.LoadStockReceipts();
                MessageBox.Show("Xác Nhận Phiếu Nhập Thành Công");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
