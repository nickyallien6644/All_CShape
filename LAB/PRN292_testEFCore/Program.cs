using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private static void Main(string[] args)
        {
            using (var context = new Context())
            {
                context.Database.CreateIfNotExists();

                var person = new Person
                {
                    FirstName = "Donald",
                    LastName = "Trump"
                };
                context.People.Add(person);
                context.SaveChanges();
            }
        }
    }
}
