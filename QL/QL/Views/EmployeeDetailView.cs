using QL.DAO;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QL.Views
{
    public partial class EmployeeDetailView : Form
    {
        private EmployeeDAO employeeDAO = new EmployeeDAO();
        private bool isEditing = false; // Kiểm tra chế độ chỉnh sửa
        private string currentEmployeeId; // Lưu mã nhân viên đang xem
        private EmployeesView employeeView = new EmployeesView();
        private EmployeesView parentView;

        public EmployeeDetailView(EmployeesView parent)
        {
            InitializeComponent();
            SetFieldsEditable(false); // Khóa các trường khi load form
            this.parentView = parent;
        }

        // Hàm Load chi tiết nhân viên
        public void LoadEmployeeDetails(string maNV)
        {
            currentEmployeeId = maNV;
            DataRow nhanVien = employeeDAO.LayThongTinChiTietNhanVien(maNV);

            if (nhanVien != null)
            {
                tbxId.Text = nhanVien["MaNV"].ToString();
                tbxName.Text = nhanVien["HoTen"].ToString();
                tbxSDT.Text = nhanVien["SDT"].ToString();
                dtpBirthDate.Value = Convert.ToDateTime(nhanVien["NgaySinh"]);
                dtpHireDate.Value = Convert.ToDateTime(nhanVien["NgTuyenDung"]);


                if (nhanVien["GioiTinh"].ToString() == "Nam")
                    radiobtnMale.Checked = true;
                else
                    radiobtnFemale.Checked = true;

                if (nhanVien["AnhDaiDien"] != DBNull.Value)
                {
                    byte[] imgData = (byte[])nhanVien["AnhDaiDien"];
                    using (MemoryStream ms = new MemoryStream(imgData))
                    {
                        ptbAvatar.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    ptbAvatar.Image = null;
                }

                if (nhanVien["TinhTrang"].ToString() == "Hoạt động")
                    radiobtnActive.Checked = true;
                else
                    radiobtnActive.Checked = false;
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin chi tiết của nhân viên.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                // Gọi hàm cập nhật dữ liệu
                UpdateEmployeeDetails();

                isEditing = false;
                SetFieldsEditable(false); // Đặt lại các trường chỉ đọc

                parentView.RefreshEmployeeList();
                this.Close(); // Đóng form sau khi lưu
            }
        }

        // Hàm cập nhật dữ liệu nhân viên vào CSDL
        private void UpdateEmployeeDetails()
        {
            string hoTen = tbxName.Text;
            string sdt = tbxSDT.Text;
            DateTime ngaySinh = dtpBirthDate.Value;
            DateTime ngayTuyenDung = dtpHireDate.Value;
            string gioiTinh = radiobtnMale.Checked ? "Nam" : "Nu";
            byte[] anhDaiDien = null;
            string tinhTrang = radiobtnActive.Checked ? "Hoạt động" : "Không hoạt động";


            bool success = employeeDAO.UpdateEmployee(currentEmployeeId, hoTen, gioiTinh, ngaySinh, ngayTuyenDung, sdt, tinhTrang);

            if (success)
            {
                MessageBox.Show("Cập nhật thông tin nhân viên thành công!");
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin nhân viên thất bại.");
            }
        }

        // Hàm đặt các trường có thể chỉnh sửa hoặc không
        private void SetFieldsEditable(bool canEdit)
        {
            tbxName.ReadOnly = !canEdit;
            tbxSDT.ReadOnly = !canEdit;
            dtpBirthDate.Enabled = canEdit;
            dtpHireDate.Enabled = canEdit;
            radiobtnMale.Enabled = canEdit;
            radiobtnFemale.Enabled = canEdit;
            radiobtnActive.Enabled = canEdit;
            ptbAvatar.Enabled = canEdit;

        }
        private void btnClose_Click (object sender, EventArgs e)
        {
            this.Close();
        }
        private void lblAddress_Click (object sender, EventArgs e)
        {

        }
        private void panelTop_Paint (object sender, PaintEventArgs e)
        {

        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            isEditing = true;
            SetFieldsEditable(true);
        }

        private void radiobtnTinhTrang_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
