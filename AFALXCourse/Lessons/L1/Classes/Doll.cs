using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFALXCourse.Lessons.L1.Classes
{
    public class Doll
    {
        public string Typ;
        public string Marka;
        public int Age;
        public void Say()
        {
            Console.WriteLine("Hello its me lala");
        }
        public void Info()
        {
            Console.WriteLine($"Age to {Age}");
            Console.WriteLine($"Typ to {Typ}");
        }
    }
}

