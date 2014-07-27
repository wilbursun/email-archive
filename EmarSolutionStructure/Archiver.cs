using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mongo;

namespace EmarSolutionStructure
{
    public class Archiver
    {
        public void ArchiveEmail(BSONObj email_bson)
        {
            DBClientConnection conn = new Db().Conn();
            conn.ensureIndex();
            conn.insert();
        }

        public void ArchiveIndex(List<BSONObj> index)
        {
            DBClientConnection conn = new Db().Conn();
            foreach (var item in index)
            {
                conn.insert();
                conn.update();
            }
        }
    }
}
