using QL.Models;
using QL.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL
{
    public partial class MainForm : Form
    {

        private Employee user = null;
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(Employee userVal)
        {
            InitializeComponent();
            user = userVal;
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            btn_Max.PerformClick();
            lblManv.Text = user.MaNV;

            //using (MemoryStream ms = new MemoryStream(user.AnhDaiDien))
            //{
            //    p_avatar.Image = Image.FromStream(ms);
            //}

            
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
            AddControls(new ReceiptsView(user));
        }

        private void btn_employee_Click(object sender, EventArgs e)
        {
            AddControls(new EmployeesView(user));
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            AddControls(new ProductsView(user));
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            AddControls(new SellingView(user));
        }

        private void btn_stockReceipt_Click(object sender, EventArgs e)
        {
            AddControls(new StockReceiptsView(user));
        }

        private void btn_discount_Click(object sender, EventArgs e)
        {
            AddControls(new DiscountView(user));
        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            AddControls(new CustomerManagementView(user));
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
