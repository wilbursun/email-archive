using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICTCLAS;

namespace EmarSolutionStructure
{
    public class Tokenizer
    {
        public void Process(string str)
        {
            ICTCLAS_.ParagraphProcessA();
            ICTCLAS_.ResultFree(new List<string>());
        }

        private void IntrestedIn(tagICTCLAS_Result result)
        { 
        }

        private void ProcessToken(string text, tagICTCLAS_Result result, List<string> words)
        { 
        }
    }
}
