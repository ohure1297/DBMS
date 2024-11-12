using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL.Models
{
    
    public class Receipt
    {
        private string maHoaDon;
        private DateTime ngayXuat;
        private int tongTien;
        private int tienKhachDua;
        private int tienThoi;
        private string tinhTrang;

        public Receipt(string maHoaDon, DateTime ngayXuat, int tongTien, int tienKhachDua, int tienThoi, string tinhTrang)
        {
            MaHoaDon = maHoaDon;
            NgayXuat = ngayXuat;
            TongTien = tongTien;
            TienKhachDua = tienKhachDua;
            TienThoi = tienThoi;
            TinhTrang = tinhTrang;
        }

        public Receipt(string tinhTrang)
        {
            TinhTrang = tinhTrang;
        }

        public Receipt(int tienKhachDua)
        {
            TienKhachDua = tienKhachDua;
        }


        public Receipt(int tienKhachDua, string tinhTrang)
        {
            TienKhachDua = tienKhachDua;
            TinhTrang = tinhTrang;
        }

        public Receipt() 
        {

        }

        public string MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public DateTime NgayXuat { get => ngayXuat; set => ngayXuat = value; }
        public int TongTien { get => tongTien; set => tongTien = value; }
        public int TienKhachDua { get => tienKhachDua; set => tienKhachDua = value; }
        public int TienThoi { get => tienThoi; set => tienThoi = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
    }
}
