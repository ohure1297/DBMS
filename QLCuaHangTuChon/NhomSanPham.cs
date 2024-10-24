using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangTuChon
{
    public class NhomSanPham
    {
        private string MaNhom;
        private string TenNhom;

        public NhomSanPham(string Ma, string Ten) 
        {
            MaNhom = Ma;
            TenNhom = Ten;
        }

        public string MaNhomVal { get => MaNhom;  }
        public string TenNhomVal { get => TenNhom; }
    }

   
}
