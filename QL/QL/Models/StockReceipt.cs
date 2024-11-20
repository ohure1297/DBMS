using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL.Models
{
    public class StockReceipt
    {
        private string stockReceiptID;
        private string status;
        private string employeeID;

        public string StockReceiptID { get => stockReceiptID; set => stockReceiptID = value; }

        public string Status { get => status; set => status = value; }
        public string EmployeeID { get => employeeID; set => employeeID = value; }

        public StockReceipt(string stockReceiptID, string status, string employeeID)
        {
            StockReceiptID = stockReceiptID;
            Status = status;
            EmployeeID = employeeID;
        }
    }
}
