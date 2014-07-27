using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mimetic;

namespace EmarSolutionStructure
{
    using Base64Decoder = Mimetic.Base64.Decoder;
    using QuotedPrintableDecoder = Mimetic.QP.Decoder;

    public class Decoder
    {
        public string Decode(string src, out string output)
        {
            new Mimetic.Mimetic().encode();
            output = string.Empty;

            return string.Empty;
        }
    }
}
