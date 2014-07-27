using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mongo;
using Mimetic;

namespace EmarSolutionStructure
{
    public class MimeBsonBuilder
    {
        public BSONObj Build(string mime)
        {

            return BuildMimeEntity(new MimeEntity(mime));
        }

        public BSONObj Build(Stream istream)
        {
            return Build(string.Empty);
        }

        private BSONObj BuildMimeEntity(MimeEntity me)
        {
            BSONObjBuilder builder = new BSONObjBuilder();
            BSONArrayBuilder arrBuilder = new BSONArrayBuilder();
            return new BSONObj();
        }
    }
}
