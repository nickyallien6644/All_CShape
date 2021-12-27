using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using PRN292_SystemSaleLaptop_Group4.View;
using PRN292_SystemSaleLaptop_Group4.ContextEF;
using System.Data.SqlClient;

namespace PRN292_SystemSaleLaptop_Group4
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
