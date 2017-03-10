using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBatCSharp.Warmup2
{
    public class StringTimes
    {
        public string Name = "StringTimes";
        public string Description = "Given a string and a non-negative int n, return a larger string that is n copies of the original string.";

        public static string ShowAnswer(string str, int n)
        {
            string returnString = string.Empty;

            for (int i = 0; i < n; i++)
            {
                returnString += str;
            }

            return returnString;
        }
    }
}
