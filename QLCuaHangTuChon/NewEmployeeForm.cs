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
    public partial class NewEmployeeForm : Form
    {
        public NewEmployeeForm()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien(maNV: tbx_maNV.Text, 
                                        hoTen: tbx_hoten.Text,
                                        gioiTinh: cb_GioiTinh.Text,
                                        sdt: tbxSdt.Text,
                                        dChi: tbx_DiaChi.Text,
                                        anhDaiDien: lb_anhURL.Text,
                                        mKhau: tbx_MatKhau.Text,
                                        ngayTuyenDung: tbx_NgayTuyenDung.Text,
                                        chucVu: tbx_ChucVu.Text,
                                        ngaySinh: tbx_NgaySinh.Text);

            QuanTri.ThemNhanVien(nv);
            
        }
    }
}
