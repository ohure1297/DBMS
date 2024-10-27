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
            AddControls(new CategoryView());
        }

        private void btn_employee_Click(object sender, EventArgs e)
        {
            AddControls(new EmployeesView());
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            AddControls(new ProductsView());
        }
    }
}
