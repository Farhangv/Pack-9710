using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetterSetterDemo
{
    class Person
    {
        private string fullname;
        private DateTime birthDate;
        //private int age;

        public string GetFullName()
        {
            return this.fullname;
        }

        public void SetFullName(string _fullname)
        {
            if (_fullname.Trim().Length >= 3 && _fullname.Trim().Contains(" "))
                this.fullname = _fullname;
            else
                Console.WriteLine("Invalid Full Name"); // Bad Practice
        }

        public DateTime GetBirthDate()
        {
            return this.birthDate;
        }

        public void SetBirthDate(DateTime _birthDate)
        {
            if (_birthDate >= DateTime.Now.AddYears(-100) && _birthDate <= DateTime.Now.AddYears(-5))
                this.birthDate = _birthDate;
            else
                Console.WriteLine("Invalid BirthDate");
        }

        public void SetBirthDate(string _birthDate)
        {
            this.SetBirthDate(DateTime.Parse(_birthDate));
        }

        public int GetAge()
        {
            return DateTime.Now.Year - this.birthDate.Year;
        }
    }
}
