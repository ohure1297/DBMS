using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL.Models
{
    public class Customer
    {
        string phoneNum;
        int point;
        public Customer() { }

        public Customer(string phoneNum, int point)
        {
            this.PhoneNum = phoneNum;
            this.Point = point;
        }

        public string PhoneNum { get => phoneNum; set => phoneNum = value; }
        public int Point { get => point; set => point = value; }
    }
}
