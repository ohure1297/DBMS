using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL.DAO;
using QL.Models;

namespace QL.Views
{
    public partial class DiscountAddView : Form
    {
        public DiscountAddView()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Discount discount = new Discount(tbxId.Text, tbxName.Text, dtpStartDate.Value, dtpEndDate.Value, (float)Convert.ToDecimal(tbxDiscountval.Text));
            DiscountDAO discountDAO = new DiscountDAO();
            discountDAO.AddDiscount(discount);
        }
    }
}
