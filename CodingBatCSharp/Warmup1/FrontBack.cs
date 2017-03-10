using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBatCSharp.Warmup1
{
    public class FrontBack
    {
        public string name = "FrontBack";
        public string description = "Given a string, return a new string where the first and last chars have been exchanged.";

        public static string ShowAnswer(string str)
        {
            if (str.Length == 0 || str.Length == 1)
            {
                return str;
            }

            string string1 = str.Substring(0, 1);
            string string2 = str.Substring(str.Length - 1, 1);

            if (str.Length == 2)
            {
                return string2 + string1;
            }
            
            string string3 = str.Substring(1, str.Length - 2);

            return string2 + string3 + string1;
        }
    }
}
