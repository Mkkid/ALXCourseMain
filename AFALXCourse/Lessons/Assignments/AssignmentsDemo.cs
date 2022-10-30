using AFALXCourse.Lessons.L1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AFALXCourse.Lessons.Assignments
{
    public class AssignmentsDemo
    {
        public static void Run()
        {
            Book book = new Book("Ala","J.Kowalski",5);
            book.Info();

            Doll doll = new Doll();
            doll.Info();

        }
   
       
}
}
