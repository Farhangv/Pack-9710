using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDemo
{
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }

        public override string ToString()
        {
            return $"{Family}, {Name}";
        }

        public override int GetHashCode()
        {
            //return Id;
            return $"{Name}{Family}".GetHashCode();
        }

        public override bool Equals(object obj)
        {
            //return this.GetHashCode() == obj.GetHashCode();
            //if (obj is Person)// Type Check
            //{
                //Person other = (Person)obj;//Unboxing
            Person other = obj as Person;
            if (other != null)
            {
                if (this.Name == other.Name && this.Family == other.Family)
                    return true;
            }
            return false;
            //}
            //else
            //    return false;
        }
    }
}
