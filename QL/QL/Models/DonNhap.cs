using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL.Models
{
    public class DonNhap
    {
        private string maDonNhap;
        private DateTime ngayNhap;

        public string MaDonNhap { get => maDonNhap; set => maDonNhap = value; }
        public DateTime NgayNhap { get => ngayNhap; set => ngayNhap = value; }

        public DonNhap(string maDonNhap, DateTime ngayNhap)
        {
            MaDonNhap = maDonNhap;
            NgayNhap = ngayNhap;
        }
    }
}
