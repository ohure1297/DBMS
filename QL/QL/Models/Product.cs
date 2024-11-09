using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL.Models
{
    public class Product
    {
        private string maSP;
        private string tenSP;
        private byte[] hinhAnh;
        private string nhaSanXuat;
        private int giaBan;
        private int tonKho;
        private string nhomSanPham;
        private string tinhTrang;
        public string MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public string NhaSanXuat { get => nhaSanXuat; set => nhaSanXuat = value; }
        public int GiaBan { get => giaBan; set => giaBan = value; }
        public int TonKho { get => tonKho; set => tonKho = value; }
        public string NhomSanPham { get => nhomSanPham; set => nhomSanPham = value; }
        public byte[] HinhAnh { get => hinhAnh; set => hinhAnh = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }

        public Product(string maSP, string tenSP, byte[] hinhAnh, string nhaSanXuat, int giaBan, int tonKho,  string nhomSanPham, string tinhTrang = "Còn hàng")
        {
            MaSP = maSP;
            TenSP = tenSP;
            HinhAnh = hinhAnh;
            NhaSanXuat = nhaSanXuat;
            GiaBan = giaBan;
            TonKho = tonKho;
            NhomSanPham = nhomSanPham;
            TinhTrang = tinhTrang;
        }

        public Product()
        {

        }
    }
}
