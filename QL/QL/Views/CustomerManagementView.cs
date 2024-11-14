using QL.DAO;
using QL.Models;
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
    public partial class CustomerManagementView : Form
    {
        readonly CustomerDAO customerDAO = null;

        private Employee user = null;
        public CustomerManagementView()
        {
            InitializeComponent();
        }

        public CustomerManagementView(Employee userVal)
        {
            InitializeComponent();
            user = userVal;
        }

        private void CustomerManagementView_Load(object sender, EventArgs e)
        {
            dgv_Customer.DataSource = customerDAO.DataTable_Customer();
        }

        private void Searchbutton_CustomerManagement_Click(object sender, EventArgs e)
        {
            if (cbSearchOptions.Text.Equals("Tên"))
            {
                dgv_Customer.DataSource = customerDAO.DataTable_SearchByName(tbxSearch.Text);
            }
            else if (cbSearchOptions.Text.Equals("SĐT"))
            {
                MessageBox.Show("1");
                dgv_Customer.DataSource = customerDAO.DataTable_SearchBySDT(tbxSearch.Text);
            }
        }

        private void btnAdd_CustomerManagement_Click(object sender, EventArgs e)
        {
            CustomerAddView view = new CustomerAddView(user);
            view.Show();
        }

        private void dgv_Customer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 &&
                    dgv_Customer.Columns[e.ColumnIndex].HeaderText != "Xóa")
            {
                CustomerDetailView view = new CustomerDetailView(user, dgv_Customer.Rows[e.RowIndex].Cells["SDT"].Value.ToString());
                view.Show();
            }
            else if (dgv_Customer.Columns[e.ColumnIndex].HeaderText.Equals("Xóa"))
            {
                
                MessageBox.Show("nhấn Xóa");
                customerDAO.DeleteCustomer(dgv_Customer.Rows[e.RowIndex].Cells["SDT"].Value.ToString());
                CustomerManagementView_Load(sender, e);
            }
        }
    }
}
