using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlxCourseHomework.MailingService
{
    internal class EmailService
    {
public void SendEmail(Email email )
        {

            var from = email.From;
            var to = email.To;
            var subject = email.Subject;
            var message = email.Message;
            
            if (from == null)
            {
                from = "empty";
            }

            if (to == null)
            {
                to = "empty";
            }

            if (subject == null)
            {
                subject = "empty";
            }

            if (message == null)
            {
                message = "empty";
            }

            Console.WriteLine("The email has been sent");

            Console.WriteLine($"From: {from}\nTo: {to}\nSubject: {subject}\nMessage: {message}\n ");
        }
    }
}
