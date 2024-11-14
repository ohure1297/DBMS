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
        Discount discount = null;
        DiscountDAO discountDAO = new DiscountDAO();
        public DiscountAddView()
        {
            InitializeComponent();
        }

        public DiscountAddView(Discount discount)
        {
            InitializeComponent();
            this.discount = discount;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Discount discount = new Discount()
            {
                Makhuyenmai = tbxId.Text,
                Tenkhuyenmai = tbxName.Text,
                Ngbatdau = dtpStartDate.Value,
                Nghethan = dtpEndDate.Value,
                Muckhuyenmai = (float)Convert.ToDecimal(tbxDiscountval.Text)
            };

            DiscountDAO discountDAO = new DiscountDAO();
            int result = discountDAO.AddDiscount(discount);

            MessageBox.Show("Thêm Khuyến Mãi Thành Công");
            if (result > 0 && clbProductIds.CheckedItems.Count > 0)
            {
                foreach (var item in clbProductIds.CheckedItems)
                {
                    string maSP = item.ToString();
                    discountDAO.AddDiscountedProduct(discount.Makhuyenmai, maSP);
                }
                discountDAO.LoadDiscountTable();
            }
            else
            {
                return;
            }
        }

        private void DiscountAddView_Load(object sender, EventArgs e)
        {
            Dbcon.openConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM V_DsSanPhamChuaKhuyenMai", Dbcon.getConnection);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                clbProductIds.Items.Add(reader["MaSPham"].ToString());
            }
        }

        public void LoadDiscount()
        {
            tbxId.Text = discount.Makhuyenmai.ToString();
            tbxName.Text = discount.Tenkhuyenmai.ToString();
            dtpStartDate.Value = discount.Ngbatdau;
            dtpEndDate.Value = discount.Nghethan;
            tbxDiscountval.Text = discount.Muckhuyenmai.ToString();
        }

        private void btnUpdateDiscount_Click(object sender, EventArgs e)
        {
            Discount discountupdate = new Discount
            {
                Makhuyenmai = tbxId.Text,
                Tenkhuyenmai = tbxName.Text,
                Ngbatdau = dtpStartDate.Value,
                Nghethan = dtpEndDate.Value,
                Muckhuyenmai = (float)Convert.ToDecimal(tbxDiscountval.Text),

            };
            discountDAO.UpdateDiscount(discountupdate);
        }
    }
}
