using QL.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            btn_Max.PerformClick();
            //btn_employee.Hide();
            //btn_discount.Hide();
        }
        public void AddControls(Form form)
        {
            this.CenterPanel.Controls.Clear();
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CenterPanel.Controls.Add(form);
            form.Show();
        }

        private void btn_category_Click(object sender, EventArgs e)
        {
            AddControls(new ReceiptsView());
        }

        private void btn_employee_Click(object sender, EventArgs e)
        {
            AddControls(new EmployeesView());
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            AddControls(new ProductsView());
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            AddControls(new SellingView());
        }

        private void btn_stockReceipt_Click(object sender, EventArgs e)
        {
            AddControls(new StockReceiptsView());
        }

        private void btn_discount_Click(object sender, EventArgs e)
        {
            AddControls(new DiscountView());
        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            AddControls(new CustomerManagementView());
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
