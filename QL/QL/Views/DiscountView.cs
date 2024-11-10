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
            view.btnUpdateDiscount.Enabled = false;
            view.btnAdd.BringToFront();
            view.Show();
        }

        private void DiscountView_Load(object sender, EventArgs e)
        {
            try
            {
                dgvDiscount.DataSource = dao.LoadDiscountTable();
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
                dgvDiscount.DataSource = dao.FindDiscountByID(tbxSearch.Text);
            }
            else if (cbFindDisCount.Text.Equals("Theo Tên Khuyến Mãi"))
            {
                dgvDiscount.DataSource = dao.FindDiscountByName(tbxSearch.Text);
            }
        }

        private void dgvDiscount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Update
            if (dgvDiscount.CurrentCell.OwningColumn.Name == "dgvUpdate")
            {
                string makhuyenmai = dgvDiscount.Rows[e.RowIndex].Cells["MaKhuyenMai"].Value.ToString();
                Discount discount = dao.LoadDisCountInfo(makhuyenmai);

                DiscountAddView discountview = new DiscountAddView(discount);
                discountview.LoadDiscount();
                discountview.btnAdd.Enabled = false;
                discountview.Show();
            }

            //Delete
            else if (dgvDiscount.CurrentCell.OwningColumn.Name == "dgvDelete")
            {
                string makhuyenmai = dgvDiscount.Rows[e.RowIndex].Cells["MaKhuyenMai"].Value.ToString();
                dao.DeleteDisCount(makhuyenmai);
                dgvDiscount.DataSource = dao.LoadDiscountTable();
            }
        }

        private void btnValidDiscount_Click(object sender, EventArgs e)
        {
            try
            {
                dgvDiscount.DataSource = dao.LoadValidDiscount();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
