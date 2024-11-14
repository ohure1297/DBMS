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
    public partial class EmployeesView : Form
    {
        EmployeeDAO employeeDAO = new EmployeeDAO();

        private Employee user = null;
        public EmployeesView()
        {
            InitializeComponent();
        }

        public EmployeesView(Employee userVal)
        {
            InitializeComponent();
            user = userVal;
        }

        private void EmployeesView_Load(object sender, EventArgs e)
        {

            DataTable dt = employeeDAO.LayDanhSachNhanVien();
            if (dt != null)
            {
                dgvEmployee.DataSource = dt;

            }
            else
            {
                MessageBox.Show("Không thể lấy danh sách nhân viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgvEmployee.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            foreach (DataGridViewColumn column in dgvEmployee.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Ví dụ căn giữa cho tất cả các cột
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EmployeeAddView view = new EmployeeAddView(user);   
            view.Show();
            view.OnEmployeeAdded += RefreshEmployeeList;
            RefreshEmployeeList();
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string maNV = dgvEmployee.Rows[e.RowIndex].Cells["MaNV"].Value.ToString();
                EmployeeDetailView detailsForm = new EmployeeDetailView(this);
                detailsForm.LoadEmployeeDetails(maNV);
                detailsForm.ShowDialog();
            }
        }

        public void RefreshEmployeeList()
        {
            DataTable dt = employeeDAO.LayDanhSachNhanVien();
            if (dt != null)
            {
                dgvEmployee.DataSource = dt;
            }
        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string maNV = tbxSearch.Text.Trim();
            string hoTen = tbxSearch.Text.Trim();
            string sdt = tbxSearch.Text.Trim();
            string tinhTrang = tbxSearch.Text.Trim();

            EmployeeDAO employeeDAO = new EmployeeDAO();
            DataTable dt = employeeDAO.TimKiemNhanVien(maNV, hoTen, sdt, tinhTrang);

            if (dt != null && dt.Rows.Count > 0)
            {
                dgvEmployee.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên nào phù hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvEmployee.DataSource = null;
            }
        }
    }
}
