using QL.DAO;
using QL.Models;
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

namespace QL.Views
{
    public partial class EmployeeAddView : Form
    {
        private string filePath = null;
        public event Action OnEmployeeAdded;


        EmployeeDAO employeeDAO = new EmployeeDAO();
        public EmployeeAddView()
        {
            InitializeComponent();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

            // Kiểm tra xem tất cả các trường thông tin bắt buộc có được điền đủ không
            if (string.IsNullOrWhiteSpace(tbxID.Text) ||
                string.IsNullOrWhiteSpace(tbxName.Text) ||
                string.IsNullOrWhiteSpace(tbxPhoneNumber.Text) ||
                string.IsNullOrWhiteSpace(tbxUserName.Text) ||
                string.IsNullOrWhiteSpace(tbxPassword.Text) ||
                (radiobtnMale.Checked == false && radiobtnFemale.Checked == false) ||
                dtpBirthDate.Value == null ||
                dtpHireDate.Value == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem có chọn hình ảnh không
            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
            {
                MessageBox.Show("Vui lòng chọn ảnh đại diện cho nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Đọc dữ liệu hình ảnh dưới dạng byte array
            byte[] imageBinaryData = File.ReadAllBytes(filePath);
            Employee employee = new Employee()
            {
                MaNV = tbxID.Text,
                HoTen = tbxName.Text,
                GioiTinh = radiobtnMale.Checked ? "Nam" : " Nữ",
                NgaySinh = dtpBirthDate.Value,
                Sdt = tbxPhoneNumber.Text,
                AnhDaiDien = imageBinaryData,
                TenTK = tbxUserName.Text,
                MKhau = tbxPassword.Text,
                NgayTuyenDung = dtpHireDate.Value,
                MaNguoiQuanLy = radiobtnManager.Checked ? tbxID.Text : null,
                TinhTrang = "Hoạt động"
            };
            employeeDAO.ThemNhanVien(employee);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected file path
                    filePath = openFileDialog.FileName;
                    ptbAvatar.Image = Image.FromFile(filePath);
                }
            }
        }
    }
}
