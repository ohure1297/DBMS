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
    public partial class CustomerAddView : Form
    {
        readonly CustomerDAO customerDAO = new CustomerDAO();
        public CustomerAddView()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                PhoneNum = tbxSDT.Text,
                Name = tbxName.Text
            };
            customerDAO.AddCustomer(customer);
            MessageBox.Show("Thêm khách hàng thành công!");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
