using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesDemo
{
    class Person
    {
        public string Title { get; set; }

        private string fullName;
        public string FullName
        {
            get {
                return this.fullName;
            }

            set {
                if (value.Trim().Length >= 3 && value.Trim().Contains(" "))
                    this.fullName = value;
                else
                    Console.WriteLine("Invalid Full Name"); // Bad Practice
            }
        }

        private DateTime birthDate;

        public DateTime BirthDate
        {
            get { return birthDate; }
            set {
                if (value >= DateTime.Now.AddYears(-100) && value <= DateTime.Now.AddYears(-5))
                    this.birthDate = value;
                else
                    Console.WriteLine("Invalid BirthDate");

            }
        }

        public int Age
        {
            get {
                return DateTime.Now.Year - this.birthDate.Year;
            }
        }

    }
}
