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
        private int totalPrice;

        public string StockReceiptID { get => stockReceiptID; set => stockReceiptID = value; }

        public string Status { get => status; set => status = value; }
        public int TotalPrice { get => totalPrice; set => totalPrice = value; }

        public StockReceipt(string stockReceiptID, string status, int totalPrice)
        {
            StockReceiptID = stockReceiptID;
            Status = status;
            TotalPrice = totalPrice;
        }
    }
}
