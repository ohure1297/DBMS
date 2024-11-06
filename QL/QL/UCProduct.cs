using QL.Models;
using QL.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class UCProduct : UserControl
    { 
        public event EventHandler onSelect = null;

        public string ProductId; 
        public string ProductName { get => lblName.Text; set => lblName.Text = value; }
        public string CurrentPrice { get => lblCurrentPrice.Text; set => lblCurrentPrice.Text = value; }
        public string Price { get => lblPrice.Text; set => lblPrice.Text = value; }
        public string Discount { get => lblDiscount.Text; set => lblDiscount.Text = value; }

        private void ptbProductImg_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }
        public UCProduct()
        {
            InitializeComponent();
        }

        
    }
}
