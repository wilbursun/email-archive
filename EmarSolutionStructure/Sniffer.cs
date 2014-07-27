using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nids;

namespace EmarSolutionStructure
{
    public class Sniffer
    {
        static SmtpHandler smtpHandler;

        public static void tcp_callback(tcp_stream stream, object param)
        {
            smtpHandler.Handle(stream, param);
        }

        public static void disable_check_sum()
        {
            nids_.chksum_ctl();
        }

        static void Main(string[] args)
        {
            Logger logger = new Logger();
            logger.Info("");
            logger.Duration("",DateTime.Now,DateTime.Now);
            logger.Debug("");

            smtpHandler.SetServerPort(25);
            nids_.init();
            
        }
    }
}
