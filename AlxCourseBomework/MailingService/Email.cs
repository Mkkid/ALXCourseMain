using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlxCourseHomework.MailingService
{
    internal class Email
    {
       public string From;
       public string To;
       public string Subject;
       public string Message;

        public Email()
        {

        }

        public Email(string from, string to, string subject, string message)
        {
            From = from;
            To = to;
            Subject = subject;
            Message = message;
        }   
    }
}
