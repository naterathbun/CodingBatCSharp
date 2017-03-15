using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBatCSharp.Warmup2
{
    public class StringSplosion
    {
        public string Name = "StringSplosion";
        public string Description = "Given a non-empty string like 'Code' return a string like 'CCoCodCode'.";

        public static string ShowAnswer(string str)
        {
            string returnString = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                returnString += str.Substring(0, i + 1);
            }

            return returnString;
        }
    }
}
