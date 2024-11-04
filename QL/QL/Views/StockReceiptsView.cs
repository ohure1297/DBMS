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
        DBConnection dbCon;
        StockReceiptDAO stockreceiptDAO;
        public StockReceiptsView()
        {
            InitializeComponent();
        }

        private void dgvCategory_Click(object sender, EventArgs e)
        {
            DetailStockReceiptView view = new DetailStockReceiptView();
            view.Show();
        }

        private void StockReceiptsView_Load(object sender, EventArgs e)
        {
            try
            {
                dbCon = new DBConnection();
                dbCon.openConnection();

                stockreceiptDAO = new StockReceiptDAO();

                dgvCategory.DataSource = stockreceiptDAO.LoadStockReceipt();
            }
            catch (Exception  ex)
            {
                MessageBox.Show(ex.Message);
            }
            dbCon.closeConnection();
        }

        private void btnFindStockReceipt_Click(object sender, EventArgs e)
        {
            try
            {
                dbCon = new DBConnection();
                dbCon.openConnection();

                stockreceiptDAO = new StockReceiptDAO();

                dgvCategory.DataSource = stockreceiptDAO.FindStockReceipt(tbxSearch.Text);
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
            DetailStockReceiptView view = new DetailStockReceiptView();
            view.Show();
        }
    }
}
