using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL.Models
{
    public class StockReceiptProducts
    {
        private string maspham;
        private int soluongnhap;

        public string MaSPham { get => maspham; set => maspham = value; }
        public int SoLuongNhap { get => soluongnhap; set => soluongnhap = value; }

        public StockReceiptProducts() { }

        public StockReceiptProducts(string maspham, int soluongnhap) 
        {
            MaSPham = maspham;
            SoLuongNhap = soluongnhap;
        }
    }
}
