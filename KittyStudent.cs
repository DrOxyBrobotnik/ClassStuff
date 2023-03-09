using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_stuff
{
    internal class KittyStudent
    {
        public string Name { get; set; }
        public string Major { get; set; }
        public double Gpa { get; set; }

        public KittyStudent(string aName, string aMajor, double aGpa) 
        {
            Name = aName;
            Major = aMajor;
            Gpa = aGpa;
        }

        public bool HasHonors() 
        {
            if (Gpa >= 3.5)
            {
                return true;
            }
            return false;
        }
    }
}
