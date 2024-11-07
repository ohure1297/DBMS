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
        StockReceiptDAO dao = new StockReceiptDAO();
        public StockReceiptsView()
        {
            InitializeComponent();
        }

        private void StockReceiptsView_Load(object sender, EventArgs e)
        {
            try
            { 
                dgvStockReceipt.DataSource = dao.LoadStockReceipts();
            }
            catch (Exception  ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFindStockReceipt_Click(object sender, EventArgs e)
        {
            try
            {
                dgvStockReceipt.DataSource = dao.FindStockReceipt(tbxSearch.Text);
            }
            catch (SqlException ex)
            {
                if (ex.Errors[0].Class == 16)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string maPhieuNhap = dgvStockReceipt.Rows[e.RowIndex].Cells["MaPhieuNhap"].Value.ToString();
                DetailStockReceiptView fChiTietHoaDon = new DetailStockReceiptView(maPhieuNhap);
                fChiTietHoaDon.ShowDialog();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StockReceiptAddView addStock = new StockReceiptAddView();
            addStock.ShowDialog();
        }
    }
}
