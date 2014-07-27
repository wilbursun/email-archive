using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmarSolutionStructure
{
    public class MailFromCommand : SmtpCommand
    {
        public override void Process(Email email)
        {
            email.SetMailFrom("");
        }
    }
}
