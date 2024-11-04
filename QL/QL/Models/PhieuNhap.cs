using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL.Models
{
    public class PhieuNhap
    {
        private string maPhieuNhap;
        private DateTime ngayNhap;

        public string MaPhieuNhap { get => maPhieuNhap; set => maPhieuNhap = value; }
        public DateTime NgayNhap { get => ngayNhap; set => ngayNhap = value; }

        public PhieuNhap(string maPhieuNhap, DateTime ngayNhap)
        {
            MaPhieuNhap = maPhieuNhap;
            NgayNhap = ngayNhap;
        }
    }
}
