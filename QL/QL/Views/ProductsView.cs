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
        public ProductsView()
        {
            InitializeComponent();
        }

        private void dgvCategory_Click(object sender, EventArgs e)
        {
            DetailProductView view = new DetailProductView();
            view.Show();
        }

        private void ProductsView_Load(object sender, EventArgs e)
        {
            btnAdd.Hide();
        }
    }
}
