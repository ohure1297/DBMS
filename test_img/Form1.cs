using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_img
{
    public partial class Form1 : Form
    {
        String strCon = "Data Source=LAPTOP-587J4388;Initial Catalog=Test;Integrated Security=True;Encrypt=False";
        
        SqlConnection conn;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Image";
            conn = new SqlConnection(strCon);
            conn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();


                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // Read the values from each row
                        string column1Value = reader["ImageID"].ToString();
                        string column2Value = reader["ImageName"].ToString();
                        string column3Value = reader["ImageData"].ToString();

                        // Process the values
                        MessageBox.Show($"ImageID: {column1Value}, ImageName: {column2Value}, ImageData: {column3Value}");

                        //imgID.Text = column1Value;
                        //imgname.Text = reader[1].ToString();
                        //byte[] image = (byte[])(reader[2]);

                        //MemoryStream ms = new MemoryStream(image);
                        //pgImage.Image = Image.FromStream(ms);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
