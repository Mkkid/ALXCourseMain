using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlxCourseHomework.MailingService
{
    internal class Homework2Test
    {
        public static void Run()
        {

            


            Console.WriteLine("Enter from email: ");
            var from = Console.ReadLine();
            Console.WriteLine("Enter to email: ");
            var to = Console.ReadLine();
            Console.WriteLine("Enter subject: ");
            var subject = Console.ReadLine();
            Console.WriteLine("Enter message: ");
            var message = Console.ReadLine();


            var emailService = new EmailService();
            var email = new Email();
            email.From = from;
            email.To = to;
            email.Subject = subject;
            email.Message = message;
            Console.WriteLine("Send email");
            emailService.SendEmail(email);


            
        }
    }
}
