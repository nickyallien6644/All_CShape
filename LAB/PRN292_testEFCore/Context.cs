using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Context : DbContext
    {
        public Context() : base("S03_connectionString")
        {

        }

        public DbSet<Person> People { get; set; }
    }
}
