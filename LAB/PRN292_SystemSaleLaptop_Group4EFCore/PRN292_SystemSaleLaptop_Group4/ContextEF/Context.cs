using PRN292_SystemSaleLaptop_Group4.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN292_SystemSaleLaptop_Group4.ContextEF
{
    public class Context : DbContext
    {
        public Context() : base("name=dbTest")
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
