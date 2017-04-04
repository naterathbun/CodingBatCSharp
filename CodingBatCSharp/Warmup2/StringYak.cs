using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBatCSharp.Warmup2
{
    public class StringYak
    {
        public string Name = "StringYak";
        public string Description = "Suppose the string 'yak' is unlucky.Given a string, return a version where all the 'yak' are removed, but the 'a' can be any char. The 'yak' strings will not overlap.";

        public static string ShowAnswer(string string1)
        {
            string returnString = string.Empty;

            for (int i = 0; i < string1.Length; i++)
            {
                if (i + 2 < string1.Length && string1[i] == 'y' && string1[i+2] == 'k')
                {
                    i = i + 2;
                }
                else
                {
                    returnString += string1[i].ToString();
                }
            }

            return returnString;
        }

    }
}
