using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL.Models
{
    public class ReceiptInfo
    {
        private string maHoaDon;
        private string maSanPham;
        private int soLuong;
        private int thanhTien;

        public ReceiptInfo(string maHoaDon, string maSanPham, int soLuong, int thanhTien)
        {
            MaHoaDon = maHoaDon;
            MaSanPham = maSanPham;
            SoLuong = soLuong;
            ThanhTien = thanhTien;
        }

        public ReceiptInfo() { }    

        public string MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public string MaSanPham { get => maSanPham; set => maSanPham = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int ThanhTien { get => thanhTien; set => thanhTien = value; }
    }
}
