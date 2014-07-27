using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mimetic
{
    public class Header
    {
        public string ContentType { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public string subject { get; set; }

        public bool hasField(string label)
        {
            return true;
        }
    }
}
