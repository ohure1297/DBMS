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

namespace QL.Views
{
    public partial class ActivitiesForm : Form
    {
        private string maNV;
        private SqlConnection dbConnection;

        public ActivitiesForm(string maNV)
        {
            InitializeComponent();
            this.maNV = maNV;
            dbConnection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CuaHangTienLoi;Integrated Security=True");
            LoadActivities();
        }

        private void LoadActivities()
        {
            try
            {
                dbConnection.Open();
                SqlCommand cmd = new SqlCommand("sp_GetEmployeeActivities", dbConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNV", maNV);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvActivities.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải hoạt động của nhân viên: " + ex.Message);
            }
            finally
            {
                dbConnection.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
