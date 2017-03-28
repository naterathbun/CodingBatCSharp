using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBatCSharp.Warmup2
{
    public class StringMatch
    {
        public string Name = "StringMatch";
        public string Description = "Given 2 strings, a and b, return the number of the positions where they contain the same length 2 substring. So 'xxcaazz' and 'xxbaaz' yields 3, since the 'xx', 'aa', and 'az' substrings appear in the same place in both strings.";

        public static int ShowAnswer(string string1, string string2)
        {
            int matchCounter = 0;
            int shortestStringLength = Math.Min(string1.Length, string2.Length);

            for (int i = 0; i < shortestStringLength - 1; i++)
            {
                if (string1[i] == string2[i] && string1[i+1] == string2[i+1])
                {
                    matchCounter++;
                }
            }

            return matchCounter;
        }
    }
}
