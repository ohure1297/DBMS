using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangTuChon
{
    public class SanPham
    {
        private string masp;
        private string tensp;
        private string hinhanh;
        private string nhasx;
        private int giaban;
        private int tonkho;
        private int daban;

        public string MaSP { get { return masp; } set {  masp = value; } }
        public string TenSP { get { return tensp; } set {  tensp = value; } }
        public string Hinhanh { get {  return hinhanh; } set {  hinhanh = value; } }
        public string NhaSX { get { return nhasx; } set { nhasx = value; } }
        public int Giaban { get {  return giaban; } set {  giaban = value; } }
        public int Tonkho { get {  return tonkho; } set {  tonkho = value; } }
        public int Daban { get { return daban; } set {  daban = value; } }

        public SanPham() { }

        public SanPham (string masp, string tensp, string hinhanh, string nhasx, int giaban, int tonkho, int daban)
        {
            MaSP = masp;
            TenSP = tensp;
            Hinhanh = hinhanh;
            NhaSX = nhasx;
            Giaban = giaban;
            Tonkho = tonkho;
            Daban = daban;
        }
    }
}
