using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testPractical.Model
{
    class Student
    {
        public int id { get; set; }
        public String name { get; set; }
        public float math { get; set; }
        public float lett { get; set; }
        public int active { get; set; }

        public Student(string name, float math, float lett, int active)
        {
            this.name = name;
            this.math = math;
            this.lett = lett;
            this.active = active;
        }
    }
}
