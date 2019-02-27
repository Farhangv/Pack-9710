using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Student:Person
    {
        public Course[] Courses { get; set; }

        public override double GetBalance()
        {
            int sum = 0;
            for (int i = 0; i < Courses.Length; i++)
            {
                sum += Courses[i].Tuition;
            }
            return sum;
        }
    }
}
