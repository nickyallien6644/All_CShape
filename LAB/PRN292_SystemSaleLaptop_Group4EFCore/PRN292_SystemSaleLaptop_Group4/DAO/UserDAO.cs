using PRN292_SystemSaleLaptop_Group4.ContextEF;
using PRN292_SystemSaleLaptop_Group4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN292_SystemSaleLaptop_Group4.DAO
{
    public class UserDAO
    {
        public User login(String email, String password)
        {
            using (var context = new Context())
            {
                //context.Database.CreateIfNotExists();

                /*var User = new User
                {
                    fullname = "minhtin",
                    password = password,
                    email = email,
                    phone = "234156788",
                    address = "tiengiang",
                    image = "https://scontent.fvca1-2.fna.fbcdn.net/v/t1.0-9/53431859_790037724695378_3570738017784037376_n.jpg?_nc_cat=104&ccb=1&_nc_sid=174925&_nc_ohc=T8uvxcikOkIAX9QsO8K&_nc_ht=scontent.fvca1-2.fna&oh=349693aac1ae7e8d3fc2535aafc4d4b6&oe=5FB76DA3",
                    role = 1,
                    active = 1
                };
                context.Users.Add(User);*/
                var result = context.Users.Where(a => a.email == email && a.password == password).ToList();
                
                foreach(User account in result)
                {
                    return account;
                }
                return null;
            }
        }
    }
}
