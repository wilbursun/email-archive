using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mongo;

namespace EmarSolutionStructure
{
    public class Db
    {
        private DBClientConnection conn;
        public Db()
        {
            conn = new DBClientConnection("localhost");
        }

        public DBClientConnection Conn()
        {
            return conn;
        }
    }
}
