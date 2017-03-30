using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBatCSharp.Warmup2
{
    public class StringX
    {
        public string Name = "StringX";
        public string Description = "Given a string, return a version where all the 'x' have been removed. Except an 'x' at the very start or end should not be removed.";

        public static string ShowAnswer(string string1)
        {
            string returnString = string.Empty;
            returnString += string1[0];

            for (int i = 1; i < string1.Length - 1; i++)
            {
                if (string1[i] != 'x')
                {
                    returnString += string1[i];
                }
            }
            returnString += string1[string1.Length - 1];

            return returnString;
        }
    }
}
