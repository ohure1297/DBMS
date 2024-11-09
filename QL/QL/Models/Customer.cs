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
        private string name;
        int point;
        public Customer() { }

        public Customer(string phoneNum, string name, int point)
        {
            this.PhoneNum = phoneNum;
            this.Name = name;
            this.Point = point;
        }

        public string PhoneNum { get => phoneNum; set => phoneNum = value; }
        public string Name { get => name; set => name = value; }
        public int Point { get => point; set => point = value; }
    }
}
