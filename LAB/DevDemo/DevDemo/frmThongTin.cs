﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Diagnostics;

namespace DevDemo
{
    public partial class frmThongTin : DevExpress.XtraEditors.XtraForm
    {
        dbDemoEntities db = new dbDemoEntities();
        Boolean add = false;
        public frmThongTin()
        {
            InitializeComponent();
            skin();
        }

        public void skin()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Valentine";
        }

        private void frmThongTin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbDemoDataSet1.tbDemo' table. You can move, or remove it, as needed.
            this.tbDemoTableAdapter.Fill(this.dbDemoDataSet1.tbDemo);
            tbDemoBindingSource1.DataSource = db.tbDemoes.ToList();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            add = true;
            tbDemoBindingSource1.AddNew();
            txtName.Focus();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (add)
            {
                tbDemo tb = new tbDemo();
                tb.uName = txtName.Text.Trim();
                tb.DiaChi = textEdit2.Text.Trim();
                tb.SoDienThoai = textEdit3.Text.Trim();
                db.tbDemoes.Add(tb);
                db.SaveChanges();
                add = false;
            }
            else
            {
                int id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString());
                tbDemo tb = new tbDemo();
                tb.uName = txtName.Text.Trim();
                tb.DiaChi = textEdit2.Text.Trim();
                tb.SoDienThoai = textEdit3.Text.Trim();
                db.tbDemoes.Add(tb);
                db.SaveChanges();
            }
        }
    }
}