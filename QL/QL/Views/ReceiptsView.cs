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
    public partial class ReceiptsView : Form
    {
        public ReceiptsView()
        {
            InitializeComponent();
        }

        private void dgvCategory_Click(object sender, EventArgs e)
        {
            DetailReceiptView view = new DetailReceiptView();
            view.Show();
        }

        private void ReceiptsView_Load(object sender, EventArgs e)
        {
            btnAdd.Hide();
        }

       
    }
}
