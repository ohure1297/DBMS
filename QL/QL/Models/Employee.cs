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
        private byte[] anhDaiDien;
        private string tenTK;
        private string mKhau;
        private DateTime ngayTuyenDung;
        private string maNguoiQuanLy;
        private string tinhTrang;

        public string MaNV { get => maNV; set => maNV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public byte[] AnhDaiDien { get => anhDaiDien; set => anhDaiDien = value; }
        public string TenTK { get => tenTK; set => tenTK = value; }
        public string MKhau { get => mKhau; set => mKhau = value; }
        public DateTime NgayTuyenDung { get => ngayTuyenDung; set => ngayTuyenDung = value; }
        public string MaNguoiQuanLy { get => maNguoiQuanLy; set => maNguoiQuanLy = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        
        public Employee(string maNV, string hoTen, string gioiTinh  , DateTime ngaySinh, string sdt, byte[] anhDaiDien, string tenTK, string mKhau, DateTime ngayTuyenDung, string maNguoiQuanLy, string tinhTrang)
        {
            MaNV = maNV;
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            Sdt = sdt;
            AnhDaiDien = anhDaiDien;
            TenTK = tenTK;
            MKhau = mKhau;
            NgayTuyenDung = ngayTuyenDung;
            MaNguoiQuanLy = maNguoiQuanLy;
            TinhTrang = tinhTrang;
        }
        public Employee()
        {
            
        }
        public Employee(string maNV, string hoTen, string gioiTinh, DateTime ngaySinh, string sdt, string tenTK, string mKhau, DateTime ngayTuyenDung, string maNguoiQuanLy, string tinhTrang)
        {
            MaNV = maNV;
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            Sdt = sdt;
            TenTK = tenTK;
            MKhau = mKhau;
            NgayTuyenDung = ngayTuyenDung;
            MaNguoiQuanLy = maNguoiQuanLy;
            TinhTrang = tinhTrang;
        }
    }
}
