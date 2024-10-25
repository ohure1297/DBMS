using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien.Objects
{
    public class Employee
    {
        private string maNV;
        private string hoTen;
        private string gioiTinh;
        private DateTime ngaySinh;
        private string sdt;
        private string dChi;
        private string anhDaiDien;
        private string MKhau;
        private DateTime ngayTuyenDung;
        private string chucvu;

        public string MaNV { get => maNV; set => maNV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string DChi { get => dChi; set => dChi = value; }
        public string AnhDaiDien { get => anhDaiDien; set => anhDaiDien = value; }
        public string MKhau1 { get => MKhau; set => MKhau = value; }
        public DateTime NgayTuyenDung { get => ngayTuyenDung; set => ngayTuyenDung = value; }
        public string Chucvu { get => chucvu; set => chucvu = value; }

        public Employee(string maNV, string hoTen, string gioiTinh, DateTime ngaySinh, string sdt, string dChi, string anhDaiDien, string mKhau1, DateTime ngayTuyenDung, string chucvu)
        {
            MaNV = maNV;
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            Sdt = sdt;
            DChi = dChi;
            AnhDaiDien = anhDaiDien;
            MKhau1 = mKhau1;
            NgayTuyenDung = ngayTuyenDung;
            Chucvu = chucvu;
        }
    }
}
