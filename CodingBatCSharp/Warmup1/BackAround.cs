using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBatCSharp.Warmup1
{
    public static class BackAround
    {
        public static string Name = "BackAround";
        public static string Description = "Given a string, take the last char and return a new string with the last char added at the front and back, so 'cat' yields 'tcatt'. The original string will be length 1 or more.";

        public static string ShowAnswer(string str)
        {
            string lastLetter = str[str.Length - 1].ToString();

            return lastLetter + str + lastLetter;
        }
    }
}
