using QL.DAO;
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
        readonly CustomerDAO customerDAO = new CustomerDAO();
        public CustomerManagementView()
        {
            InitializeComponent();
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
    }
}
