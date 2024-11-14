using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL.Models
{
    public class Employee
    {
        private string maNV;
        private string hoTen;
        private string gioiTinh;
        private DateTime ngaySinh;
        private string sdt;
        private string dChi;
        private byte[] anhDaiDien;
        private string mKhau;
        private DateTime ngayTuyenDung;
        private string chucvu;

        public string MaNV { get => maNV; set => maNV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string DChi { get => dChi; set => dChi = value; }
        public byte[] AnhDaiDien { get => anhDaiDien; set => anhDaiDien = value; }
        public string MKhau { get => mKhau; set => mKhau = value; }
        public DateTime NgayTuyenDung { get => ngayTuyenDung; set => ngayTuyenDung = value; }
        public string Chucvu { get => chucvu; set => chucvu = value; }

        public Employee(string maNV, byte[] anhDaiDien)
        {
            MaNV = maNV;
            AnhDaiDien = anhDaiDien;
        }

        public Employee(string maNV, string hoTen, string gioiTinh, DateTime ngaySinh, string sdt, string dChi, byte[] anhDaiDien, string mKhau, DateTime ngayTuyenDung, string chucvu)
        {
            MaNV = maNV;
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            Sdt = sdt;
            DChi = dChi;
            AnhDaiDien = anhDaiDien;
            MKhau = mKhau;
            NgayTuyenDung = ngayTuyenDung;
            Chucvu = chucvu;
        }
    }
}
