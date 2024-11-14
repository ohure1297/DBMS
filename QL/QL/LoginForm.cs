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

namespace QL
{
    public partial class LoginForm : Form
    {
        
        private LoginDAO loginDAO = new LoginDAO();

        private Employee user = null;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            
            string userName = tbxUserName.Text.Trim();
            string password = tbxPassword.Text.Trim(); 

            DataTable table = loginDAO.LoginCheck(userName, password);

            if(table.Rows.Count == 0)
            {
                MessageBox.Show("Không có thông tin tài khoản", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxUserName.ResetText();
                tbxPassword.ResetText();
            }    
            else
            {
                MessageBox.Show(table.Rows[0]["MaNV"].ToString());
                user = new Employee(table.Rows[0]["MaNV"].ToString(), table.Rows[0]["AnhDaiDien"] != DBNull.Value ? (byte[])table.Rows[0]["AnhDaiDien"] : null, table.Rows[0]["VaiTro"].ToString());

                if (table.Rows[0]["VaiTro"].ToString().Equals("nv"))
                {
                    MessageBox.Show("NV yay");
                    
                    
                }    
                else
                {
                    MessageBox.Show("QL yay");
                }

                

                MainForm form = new MainForm(user);
                form.Show();
                //this.Hide();

            }    
            
            
            
            
        }

        private void cbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxShowPass.Checked)
            {
                tbxPassword.PasswordChar = '\0';
            }
            else
            {
                tbxPassword.PasswordChar = '●';
            }
        }
    }
}
