using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL.DAO;
using QL.Models;

namespace QL.Views
{
    public partial class DetailStockReceiptView : Form
    {
        readonly StockReceiptDAO dao = null;
        public DetailStockReceiptView(Employee userVal, string maphieunhap)
        {
            InitializeComponent();
            dao = new StockReceiptDAO(userVal);
            LoadStockReceiptDetail(maphieunhap);
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadStockReceiptDetail(string maphieunhap)
        {
            try
            {
                dgvCategory.DataSource = dao.GetStockReceiptProduct(maphieunhap);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
