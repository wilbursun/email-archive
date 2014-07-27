using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmarSolutionStructure
{
    public class SmtpHandler
    {
        public void Handle(tcp_stream tcp, object param) 
        {
            EqualToTuple4 eq;
            AddSession();
            RemoveSession();
        }

        public void SetServerPort(int port) { }

        private void AddSession() { }

        private void RemoveSession() { }
    }

    public struct tcp_stream
    { 
    }
}
