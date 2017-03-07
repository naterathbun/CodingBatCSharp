using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBatCSharp.Warmup1
{
    public static class MixStart
    {
        public static string Name = "MixStart";
        public static string Description = "Return true if the given string begins with 'mix', except the 'm' can be anything, so 'pix', '9ix' .. all count.";

        public static bool ShowAnswer(string str)
        {
            return str.Substring(1, 2) == "ix";
        }
    }
}
