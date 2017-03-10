using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBatCSharp.Warmup1
{
    public class EndUp
    {
        public string Name = "EndUp";
        public string Description = "Given a string, return a new string where the last 3 chars are now in upper case. If the string has less than 3 chars, uppercase whatever is there.Note that str.toUpperCase() returns the uppercase version of a string.";

        public static string ShowAnswer(string str)
        {
            if (str.Length <= 3)
            {
                return str.ToUpper();
            }

            return str.Substring(0, str.Length - 3) + str.Substring(str.Length - 3, 3).ToUpper();
        }

    }
}
