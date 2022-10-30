using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFALXCourse.Lessons.L1.Classes
{
    public class Book
    {
        public string Title;
        public string Autor;
        public int Ile;
        public Book(string title, string autor, int ile)
        {
            Title = title;
            Autor = autor;
            Ile = ile;
        }
        public Book(int ile)
        {
            Ile = ile;
        }
        public void Say()
        {
            Console.WriteLine("ksiazki są fajne");
        }
        public void Info()
        {
            Console.WriteLine($"Title to {Title}");
            Console.WriteLine($"autor to {Autor}autor");
        }

    }
}
