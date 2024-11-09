using QL.DAO;
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
            string maNV = tbxID.Text;
            string hoTen = tbxName.Text;
            string sdt = tbxPhoneNumber.Text;
            string tenTK = tbxUserName.Text;
            string matKhau = tbxPassword.Text;
            DateTime ngaySinh = dtpBirthDate.Value;
            DateTime ngTuyenDung = dtpHireDate.Value;
            string gioiTinh = radiobtnMale.Checked ? "Nam" : "Nữ";
            string maNguoiQuanLy = radiobtnManager.Checked ? maNV : null;

            // Chuyển ảnh thành mảng byte nếu có
            byte[] anhDaiDien = null;
            if (ptbAvatar.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    ptbAvatar.Image.Save(ms, ptbAvatar.Image.RawFormat);
                    anhDaiDien = ms.ToArray();
                }
            }

            // Gọi phương thức thêm nhân viên với thông tin và ảnh đã chuyển đổi
            bool success = employeeDAO.ThemNhanVien(maNV, hoTen, gioiTinh, ngaySinh, sdt, anhDaiDien, tenTK, matKhau, ngTuyenDung, maNguoiQuanLy);

            if (success)
            {
                MessageBox.Show("Thêm nhân viên thành công!");
                this.Close(); // Đóng form sau khi thêm
                OnEmployeeAdded.Invoke();
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại.");
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Hiển thị ảnh lên PictureBox
                    ptbAvatar.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }
    }
}
