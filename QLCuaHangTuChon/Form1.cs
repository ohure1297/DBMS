﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangTuChon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            DBConn.ConnOpen();
            DBConn db = new DBConn();
            SqlCommand cmd = new SqlCommand("SELECT * FROM ThongTinNhanVien", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable nhanVienTable = new DataTable();
            adapter.Fill(nhanVienTable);
            dgvNhanVien.DataSource = nhanVienTable;
            DBConn.ConnClose();


            //hello
        }
    }
}
