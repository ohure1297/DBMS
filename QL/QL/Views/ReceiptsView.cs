using QL.DAO;
using System;
using System.Data;
using System.Windows.Controls;
using System.Windows.Forms;

namespace QL.Views
{
    public partial class ReceiptsView : Form
    {
        // Khai báo đối tượng DAO để làm việc với dữ liệu
        ReceiptDAO receiptDAO = new ReceiptDAO();

        public ReceiptsView()
        {
            InitializeComponent();
        }

        private void ReceiptsView_Load(object sender, EventArgs e)
        {
            btnAdd.Hide();
            LoadReceipts();
        }

        private void LoadReceipts()
        {
            DataTable receipts = receiptDAO.GetAllReceipts();
            if (receipts != null && receipts.Rows.Count > 0)
            {
                dgvCategory.DataSource = receipts;
            }
            else
            {
                MessageBox.Show("Không có hóa đơn nào để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //dgvCategory.DataSource = null;
            }
            dgvCategory.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            foreach (DataGridViewColumn column in dgvCategory.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Ví dụ căn giữa cho tất cả các cột
            }
        }

        private void btnSearch_Receipt_Click(object sender, EventArgs e)
        {
            string keyword = txtSearchReceipt.Text.Trim();

            if (!string.IsNullOrEmpty(keyword))
            {
                // Gọi phương thức tìm kiếm qua đối tượng receiptDAO
                DataTable searchResult = receiptDAO.TimKiemHoaDon(keyword);

                if (searchResult != null && searchResult.Rows.Count > 0)
                {
                    dgvCategory.DataSource = searchResult;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hóa đơn nào phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvCategory_Click(object sender, EventArgs e)
        {
 
        }

        private void txtSearchReceipt_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo người dùng nhấp vào hàng dữ liệu chứ không phải tiêu đề
            {
                string maHoaDon = dgvCategory.Rows[e.RowIndex].Cells["MaHoaDon"].Value.ToString();
                // Mở form DetailReceiptView và truyền mã hóa đơn
                DetailReceiptView detailView = new DetailReceiptView(maHoaDon);
                detailView.Show();
            }
        }
    }
}
