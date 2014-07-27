using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmarSolutionStructure
{
    public class SmtpResponse
    {
        public SmtpResponse Create(string data, int length)
        {
            return new SmtpResponse();
        }

        public string Message()
        {
            return string.Empty;
        }

        public bool Success()
        {
            return true;
        }

        public bool Incomplete()
        {
            return false;
        }
    }
}
