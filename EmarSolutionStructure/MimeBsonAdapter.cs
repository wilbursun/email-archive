using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mongo;

namespace EmarSolutionStructure
{
    public class MimeBsonAdapter
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string ContentType { get; set; }

        public OID Id { get; set; }
        public BSONElement Body { get; set; }

        private string GetStringField(string field)
        {
            return string.Empty;
        }
    }
}
