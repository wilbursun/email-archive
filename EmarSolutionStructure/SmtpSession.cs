using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmarSolutionStructure
{
    public class SmtpSession
    {
        SmtpCommand _command;
        SmtpResponse _response;

        public void ServerSays(string msg, int length) 
        {
            SmtpResponse response = new SmtpResponse();
            response.Create("", 0);
            response.Success();
            _command.Process(new Email());
        }
        public void ClientSays(string msg, int length) 
        {
            _response.Incomplete();
            _command.AppendData("", 0);
            new SmtpCommand().Create("", 0);
        }
    }
}
