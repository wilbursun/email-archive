using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmarSolutionStructure
{
    public class SmtpCommand
    {
        public SmtpCommand Create(string cmd, int length)
        {
            Recognize();
            new EhloCommand();
            new MailFromCommand();
            new RcptToCommand();
            new DataCommand();
            return new SmtpCommand();
        }

        public void AppendData(string cmd, int length)
        { 
        }

        public virtual void Process(Email email)
        { 
        }

        private void Recognize() { }
    }
}
