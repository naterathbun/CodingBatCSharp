using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBatCSharp.Warmup2
{
    public class StringBits
    {
        public string Name = "StringBits";
        public string Description = "Given a string, return a new string made of every other char starting with the first, so 'Hello' yields 'Hlo'.";

        public static string ShowAnswer(string str)
        {
            string returnString = string.Empty;

            for (int i = 0; i < str.Length; i+=2)
            {
                returnString += str[i];
            }

            return returnString;
        }
    }
}
