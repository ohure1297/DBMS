using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangTuChon
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }
        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            dtgv_employee.DataSource = GetTable.getEmployees();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            NewEmployeeForm form = new NewEmployeeForm();
            form.Show();
            
        }
    }
}
