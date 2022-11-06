using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AlxCourseHomework.MailingService
{
    internal class Homework1Test
    {
        public static void Run()
        {
            
            var emailService = new EmailService();

            Console.WriteLine("First email");

            var email1 = new Email();
            email1.From = "agata@gmail.com";
            email1.To = "ala@gmail.com";
            email1.Subject = "invitation";
            email1.Message = "Hellow";
            emailService.SendEmail(email1);

            Console.WriteLine("Second email");

            var email2 = new Email();
            email2.From = "Tomek20@gmail.com";
            email2.To = "ala@gmail.com";
            email2.Subject = "invitation";
            email2.Message = "come to me";
            emailService.SendEmail(email2);

            Console.WriteLine("Third email");
            var email3 = new Email("Teacher3@gmail.com", "Student3@gmail.com", "Exercise", "Hard exercise");
            emailService.SendEmail(email3);

            Console.WriteLine("Fourth email");
            var email4 = new Email("Teacher4@gmail.com", "Student4@gmail.com","Exercise 4", "Hard exercise 4");
            emailService.SendEmail(email4);


            Console.WriteLine("Fourth email");
            var email5 = new Email("Teacher5@gmail.com", "Student5@gmail.com", "Exercise 5", "Hard exercise 5");
            emailService.SendEmail(email5);
        }
    }
}
