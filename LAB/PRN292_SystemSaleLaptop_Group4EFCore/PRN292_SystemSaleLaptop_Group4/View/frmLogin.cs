using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PRN292_SystemSaleLaptop_Group4.ContextEF;
using PRN292_SystemSaleLaptop_Group4.DAO;

namespace PRN292_SystemSaleLaptop_Group4.View
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || txtPass.Text == "")
                MessageBox.Show("Please input");
            else
            {
                String email = txtEmail.Text;
                String pass = txtPass.Text;

                UserDAO uDAO = new UserDAO();
                uDAO.login(email, pass);
                if (uDAO.login(email, pass) == null)
                {
                    MessageBox.Show("Incorect password or email");
                }
                else
                {
                    frmMain form = new frmMain();
                    form.Show();
                    this.Visible = false;
                }
            }
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked)
            {
                txtPass.UseSystemPasswordChar = true;
            }
            else
            {
                txtPass.UseSystemPasswordChar = false;
            }
        }
    }
}