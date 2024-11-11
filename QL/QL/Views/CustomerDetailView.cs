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
    public partial class CustomerDetailView : Form
    {
        readonly CustomerDAO customerDAO = new CustomerDAO();
        private string SDT = null;
        private bool isEdit = false;
        public CustomerDetailView()
        {
            InitializeComponent();
        }

        public CustomerDetailView(string SDT)
        {
            InitializeComponent();
            this.SDT = SDT;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomerDetailView_Load(object sender, EventArgs e)
        {
            Customer customer = customerDAO.GetCustomer(SDT);
            tbxSDT.Text = customer.PhoneNum;
            tbxName.Text = customer.Name;
            tbxPoint.Text = customer.Point.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (isEdit == false)
            {
                isEdit = true;
                btnEdit.Text = "Finish";
                tbxName.Enabled = true;
                tbxPoint.Enabled = true;

            }
            else
            {

                Customer customer = new Customer()
                {
                    PhoneNum = tbxSDT.Text,
                    Name = tbxName.Text,
                    Point = int.Parse(tbxPoint.Text),
                };

                customerDAO.EditCustomer(customer);

                isEdit = false;
                btnEdit.Text = "Edit";
                tbxName.Enabled =false;
                tbxPoint.Enabled =false;

                MessageBox.Show("Sửa khách hàng thành công!");
            }
        }
    }
}
