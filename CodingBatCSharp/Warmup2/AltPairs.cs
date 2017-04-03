using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBatCSharp.Warmup2
{
    public class AltPairs
    {
        public string Name = "AltPairs";
        public string Description = "Given a string, return a string made of the chars at indexes 0,1, 4,5, 8,9 ... so 'kittens' yields 'kien'.";

        public static string ShowAnswer(string string1)
        {
            string returnString = string.Empty;

            for (int i = 0; i < string1.Length; i++)
            {
                returnString += string1[i].ToString();
                if (i < string1.Length - 1)
                {
                    returnString += string1[i + 1].ToString();
                }

                i = i + 3;
            }

            return returnString;
        }
    }
}
