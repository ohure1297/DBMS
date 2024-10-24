using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangTuChon
{
    public class NhanVien
    {
        private string maNV;
        private string hoTen;
        private string gioiTinh;
        private string ngaySinh;
        private string sdt;
        private string dChi;
        private string anhDaiDien;
        private string mKhau;
        private string ngayTuyenDung;
        private string chucVu;

        public string MaNV { get => maNV; set => maNV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string DChi { get => dChi; set => dChi = value; }
        public string AnhDaiDien { get => anhDaiDien; set => anhDaiDien = value; }
        public string MKhau { get => mKhau; set => mKhau = value; }
        public string NgayTuyenDung { get => ngayTuyenDung; set => ngayTuyenDung = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }

        public NhanVien() { }

        public NhanVien(string maNV, string hoTen, string gioiTinh,string ngaySinh, string sdt, string dChi, string anhDaiDien, string mKhau, string ngayTuyenDung, string chucVu)
        {
            MaNV = maNV;
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            Sdt = sdt;
            DChi = dChi;
            AnhDaiDien = anhDaiDien;
            MKhau = mKhau;
            NgayTuyenDung = ngayTuyenDung;
            ChucVu = chucVu;
            NgaySinh = ngaySinh;    
        }


    }
}
