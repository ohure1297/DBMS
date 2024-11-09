using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL.Models
{
    public class Discount
    {
        private string makhuyenmai;
        private string tenkhuyenmai;
        private DateTime ngbatdau;
        private DateTime nghethan;
        private float muckhuyenmai;

        public string Makhuyenmai { get => makhuyenmai; set => makhuyenmai = value; }
        public string Tenkhuyenmai { get => tenkhuyenmai; set => tenkhuyenmai = value; }
        public DateTime Ngbatdau { get => ngbatdau; set => ngbatdau = value; }
        public DateTime Nghethan { get => nghethan; set => nghethan = value; }
        public float Muckhuyenmai { get => muckhuyenmai; set => muckhuyenmai = value; }

        public Discount() { }
        public Discount (string makhuyenmai, string tenkhuyenmai, DateTime ngbatdau, DateTime nghethan, float muckhuyenmai)
        {
            Makhuyenmai = makhuyenmai;
            Tenkhuyenmai = tenkhuyenmai;
            Ngbatdau = ngbatdau;
            Nghethan = nghethan;
            Muckhuyenmai = muckhuyenmai;
        }
    }
}
