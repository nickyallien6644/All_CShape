using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PRN292_Nhom4_PH1
{
    public partial class HocKy : Form
    {
        SqlConnection conn;
        private object dtMonHoc;

        public HocKy()
        {
            InitializeComponent();  
            String conString = ConfigurationManager.ConnectionStrings["PH1"].ConnectionString.ToString();
            conn = new SqlConnection(conString);
            show();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {

            String value = txtSearch.Text;

            if(value == "")
            {
                MessageBox.Show("Vui long dien thong tin de search");
            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from HocKy WHERE Ma_HK=@hocky", conn);
                cmd.Parameters.AddWithValue("@hocky", value);

                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(dr);
                dtHocKy.DataSource = table;
                
                conn.Close();
                
            }
        }

        public void show()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from HocKy", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(dr);
            conn.Close();
            dtHocKy.DataSource = table;
            dtHocKy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtHocKy.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
    }
}
