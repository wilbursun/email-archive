using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmarSolutionStructure
{
    public class Email
    {
        public bool Valid()
        {
            return true;
        }
        public string MailFrom()
        {
            return string.Empty;
        }
        public string Content()
        {
            return string.Empty;
        }
        public List<string> Recipients()
        {
            return new List<string>();
        }

        public void SetMailFrom(string from)
        {
        }
        public void AddRecipient(string recipient)
        {
        }
        public void SetContent(string content)
        { 
        }

        public void Output(Email mail) 
        {
            mail.MailFrom();
            mail.Recipients();
            mail.Content();
        }
    }
}
