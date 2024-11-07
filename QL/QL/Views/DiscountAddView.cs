using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        DBConnection Dbcon = new DBConnection();
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
            if (clbProductIds.CheckedItems.Count > 0)
            {
                Discount discount = new Discount(tbxId.Text, tbxName.Text, dtpStartDate.Value, dtpEndDate.Value, (float)Convert.ToDecimal(tbxDiscountval.Text));
                DiscountDAO discountDAO = new DiscountDAO();
                discountDAO.AddDiscount(discount);

                foreach (var item in clbProductIds.Items)
                {
                    string maSP = item.ToString();
                    discountDAO.AddDiscountedProduct(discount.Makhuyenmai, maSP);
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn sản phẩm được áp dụng khuyến mãi");
            }
        }

        private void DiscountAddView_Load(object sender, EventArgs e)
        {
            Dbcon.openConnection();
            SqlCommand cmd = new SqlCommand("SELECT MaSPham from SANPHAM", Dbcon.getConnection);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                clbProductIds.Items.Add(reader["MaSPham"].ToString());
            }
        }
    }
}
