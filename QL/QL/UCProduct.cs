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
        public Label LblName { get => lblName; set => lblName = value; }
        public Label LblCurrentPrice { get => lblCurrentPrice; set => lblCurrentPrice = value; }
        public Label LblPrice { get => lblPrice; set => lblPrice = value; }
        public Label LblDiscount { get => lblDiscount; set => lblDiscount = value; }


        public UCProduct()
        {
            InitializeComponent();
        }


    }
}
