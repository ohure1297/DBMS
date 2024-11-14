using QL.DAO;
using QL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QL.Views
{
    public partial class DetailReceiptView : Form
    {
        private ReceiptDAO ReceiptDAO = null;
 


        public DetailReceiptView(Employee userVal, string maHoaDon)
        {
            InitializeComponent();

            ReceiptDAO = new ReceiptDAO(userVal);
            // Gọi hàm lấy thông tin chi tiết hóa đơn
            DataTable dt = ReceiptDAO.LayDanhSachChiTietHoaDon(maHoaDon);
            if (dt != null)
            {
                dgvCategory.DataSource = dt;
            }
            dgvCategory.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            foreach (DataGridViewColumn column in dgvCategory.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Ví dụ căn giữa cho tất cả các cột
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DetailReceiptView_Load(object sender, EventArgs e)
        {

        }

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
