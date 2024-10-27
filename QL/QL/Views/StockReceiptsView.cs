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
    public partial class StockReceiptsView : Form
    {
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
            btnAdd.Hide();
        }
    }
}
