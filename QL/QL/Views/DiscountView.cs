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

namespace QL.Views
{
    public partial class DiscountView : Form
    {
        DiscountDAO dao = new DiscountDAO();
        public DiscountView()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DiscountAddView view = new DiscountAddView();   
            view.Show();
        }

        private void DiscountView_Load(object sender, EventArgs e)
        {
            try
            {
                dgvCategory.DataSource = dao.LoadDiscountTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFindDisCount_Click(object sender, EventArgs e)
        {
            if (cbFindDisCount.Text.Equals("Theo Mã Khuyến Mãi"))
            {
                dgvCategory.DataSource = dao.FindDiscountByID(tbxSearch.Text);
            }
            else if (cbFindDisCount.Text.Equals("Theo Tên Khuyến Mãi"))
            {
                dgvCategory.DataSource = dao.FindDiscountByName(tbxSearch.Text);
            }
        }
    }
}
