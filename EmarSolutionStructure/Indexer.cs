using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mongo;
using Mimetic;
using ICTCLAS;

namespace EmarSolutionStructure
{
    public class Indexer
    {
        private Dictionary<string, TokenItem> _tokens;
        private Tokenizer _tokenizer;

        public List<BSONObj> Index(MimeEntity entity, OID email_id)
        {
            _tokens.Clear();
            IndexHeader(entity.Header);
            IndexBody(entity);
            return GenerateIndexResults(email_id);
        }

        private void IndexText(string text)
        {
            ProcessToken(text, new tagICTCLAS_Result());
            _tokenizer.Process(text);
        }

        private void IndexHeader(Header header)
        {
            EncodedWord ew = new EncodedWord();
            IndexText(ew.Decode(header.from));
            IndexText(header.to);
            IndexText(header.subject);
        }

        private void IndexBody(MimeEntity entity)
        {
            if (entity.Header.hasField(""))
            {
                IndexBody(entity);    
            }
            
            IndexText(entity.Header.ContentType);
        }

        private void ProcessToken(string text, tagICTCLAS_Result result)
        { 
        }

        private List<BSONObj> GenerateIndexResults(OID email_id)
        {
            BSONObjBuilder builder = new BSONObjBuilder();
            return new List<BSONObj>();
        }
    }
}
