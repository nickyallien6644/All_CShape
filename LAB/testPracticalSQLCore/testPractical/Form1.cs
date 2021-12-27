using DevExpress.Data.Async;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors.ButtonPanel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using testPractical.Model;

namespace testPractical
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection conn;
        int idChoice = -1;
        
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
            dtTable.CancelEdit();
           

            txtMath.Minimum = 0;
            txtMath.Maximum = 10;
            txtLetteriter.Minimum = 0;
            txtLetteriter.Maximum = 10;

            String conString = ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString.ToString();
            conn = new SqlConnection(conString);
            show();
            clear();
        }

        public void clear()
        {
            txtName.Text = "";
            txtMath.Value = 1;
            txtLetteriter.Value = 1;
            cbActive.Checked = false;
        }

        public void show()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Student", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(dr);
            conn.Close();
            dtTable.DataSource = table;
            dtTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Insert into Student(name,math,literature,active) VALUES (@name, @math, @lett, @active)", conn);
            cmd.Parameters.AddWithValue("name", txtName.Text.Trim());
            cmd.Parameters.AddWithValue("math", txtMath.Value);
            cmd.Parameters.AddWithValue("lett", txtLetteriter.Value);
            cmd.Parameters.AddWithValue("active", cbActive.Checked ? 1 : 0);
            cmd.ExecuteNonQuery();
            conn.Close();
            show();
        }

        private void dtTable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.idChoice = Convert.ToInt32(dtTable.Rows[e.RowIndex].Cells["uId"].Value);
            txtName.Text = dtTable.Rows[e.RowIndex].Cells["name"].Value.ToString();
            txtMath.Value = Convert.ToInt32(dtTable.Rows[e.RowIndex].Cells["math"].Value);
            txtLetteriter.Value = Convert.ToInt32(dtTable.Rows[e.RowIndex].Cells["literature"].Value);

            int choice = Convert.ToInt32(dtTable.Rows[e.RowIndex].Cells["active"].Value);
            cbActive.CheckState = choice == 1 ? CheckState.Checked : CheckState.Unchecked;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(idChoice < 0)
            {
                MessageBox.Show("Nhap di dmm");
            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Student SET name=@name, math=@math, literature=@lett, active=@active WHERE uId=@id", conn);
                cmd.Parameters.AddWithValue("name", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("math", txtMath.Value);
                cmd.Parameters.AddWithValue("lett", txtLetteriter.Value);
                cmd.Parameters.AddWithValue("active", cbActive.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("id", this.idChoice);
                cmd.ExecuteNonQuery();
                conn.Close();
                idChoice = -1;
                show();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Delete FROM Student WHERE uId=@id", conn);
            cmd.Parameters.AddWithValue("id", this.idChoice);
            cmd.ExecuteNonQuery();
            conn.Close();
            idChoice = -1;
            show();
        }
    }
}
