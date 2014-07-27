using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmarSolutionStructure
{
    using Base64Decoder = Mimetic.Base64.Decoder;
    using QuotedPrintableDecoder = Mimetic.QP.Decoder;

    public class EncodedWord
    {
        public static bool IsEncoded(string text)
        {
            return true;
        }

        public string Decode(string text)
        {
            Base64Decoder b64;
            QuotedPrintableDecoder qt;
            b64 = null;
            qt = null;
            return "";
        }
    }
}
