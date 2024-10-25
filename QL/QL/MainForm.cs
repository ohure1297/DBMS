using GiaoDien.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void AddControl(Form form)
        {
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            CenterPanel.Controls.Add(form);
            form.Show();
        }
        private void guna2Button6_Click(object sender, EventArgs e)
        {
            EmployeesView form = new EmployeesView();
            AddControl(form);


        }
    }
}
