using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN292_SystemSaleLaptop_Group4.Model
{
    public class User
    {

        [Key]
        public int userId { get; set; }
        [StringLength(100)]
        public String fullname { get; set; }
        [StringLength(100)]
        public String password { get; set; }
        [StringLength(200)]
        public String email { get; set; }
        [StringLength(50)]
        public String phone { get; set; }
        [StringLength(200)]
        public String address { get; set; }
        public String image { get; set; }

        public int role { get; set; }

        public int active { get; set; }
    }
}
