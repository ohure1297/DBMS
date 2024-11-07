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
        private string hinhAnh;
        private string nhaSanXuat;
        private int giaBan;
        private int tonKho;
        private int daBan;
        private string nhomSanPham;

        public string MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public string HinhAnh { get => hinhAnh; set => hinhAnh = value; }
        public string NhaSanXuat { get => nhaSanXuat; set => nhaSanXuat = value; }
        public int GiaBan { get => giaBan; set => giaBan = value; }
        public int TonKho { get => tonKho; set => tonKho = value; }
        public int DaBan { get => daBan; set => daBan = value; }
        public string NhomSanPham { get => nhomSanPham; set => nhomSanPham = value; }

        public Product(string maSP, string tenSP, string hinhAnh, string nhaSanXuat, int giaBan, int tonKho, int daBan, string nhomSanPham)
        {
            MaSP = maSP;
            TenSP = tenSP;
            HinhAnh = hinhAnh;
            NhaSanXuat = nhaSanXuat;
            GiaBan = giaBan;
            TonKho = tonKho;
            DaBan = daBan;
            NhomSanPham = nhomSanPham;
        }

        public Product()
        {

        }
    }
}
