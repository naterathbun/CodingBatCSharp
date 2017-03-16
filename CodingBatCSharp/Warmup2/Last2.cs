using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBatCSharp.Warmup2
{
    public class Last2
    {
        public string Name = "Last2";
        public string Description = "Given a string, return the count of the number of times that a substring length 2 appears in the string and also as the last 2 chars of the string, so 'hixxxhi' yields 1 (we won't count the end substring).";

        public static int ShowAnswer(string str)
        {
            string lastTwo = str.Substring(str.Length - 2, 2);
            int count = 0;

            for (int i = 0; i < str.Length-2; i++)
            {
                if (str[i].ToString() + str[i+1].ToString() == lastTwo)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
