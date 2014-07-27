using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmarSolutionStructure
{
    public class Logger
    {
        public virtual void Info(string message) { }
        public virtual void Error(string message) { }
        public virtual void Debug(string message) { }
        public virtual void Duration(string message, DateTime start, DateTime end) { }

        static void Setup(Logger logger) 
        { 
        }

        static Logger Instance()
        {
            NullLogger logger = new NullLogger();
            return new GeneralLogger();
        }
    }

    public class NullLogger : Logger
    {
        public override void Info(string message)
        {
            base.Info(message);
        }

        public override void Error(string message)
        {
            base.Error(message);
        }

        public override void Debug(string message)
        {
            base.Debug(message);
        }

        public override void Duration(string message, DateTime start, DateTime end)
        {
            base.Duration(message, start, end);
        }
    }

    public class GeneralLogger : Logger
    {
        public override void Info(string message)
        {
            base.Info(message);
        }

        public override void Error(string message)
        {
            base.Error(message);
        }

        public override void Debug(string message)
        {
            base.Debug(message);
        }

        public override void Duration(string message, DateTime start, DateTime end)
        {
            base.Duration(message, start, end);
        }
    }
}
