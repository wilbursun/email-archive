using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mongo;

namespace EmarSolutionStructure
{
    public class EmailArchiver
    {
        private Indexer _indexer;
        private Archiver _archiver;

        private List<Email> email_queue;

        public void Archive(Email email)
        { 
        }

        public void Archive(Stream istream)
        { 
        }

        private void ArchiveEmail(Email email)
        {
        }

        private void Archive(string mime)
        {
            MimeBsonBuilder mbb = null;
            BSONObj email_bson = mbb.Build(mime);
            _archiver.ArchiveEmail(email_bson);
            _archiver.ArchiveIndex(_indexer.Index(new Mimetic.MimeEntity(mime), new OID()));
        }

        private void Archive(BSONObj email_bson)
        { 
        }

        private void Task()
        { 
        }
    }
}
