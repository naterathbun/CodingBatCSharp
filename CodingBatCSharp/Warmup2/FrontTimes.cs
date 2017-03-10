using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBatCSharp.Warmup2
{
    public class FrontTimes
    {
        public string Name = "FrontTimes";
        public string Description = "Given a string and a non-negative int n, we'll say that the front of the string is the first 3 chars, or whatever is there if the string is less than length 3. Return n copies of the front.";

        public static string ShowAnswer(string str, int n)
        {
            string returnString = string.Empty;
            string frontString = string.Empty;

            if (str.Length < 3)
            {
                frontString = str;    
            }
            else
            {
                frontString = str.Substring(0, 3);
            }

            for (int i = 0; i < n; i++)
            {
                returnString += frontString;
            }

            return returnString;
        }
    }
}
