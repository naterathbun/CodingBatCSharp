using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBatCSharp.Warmup1
{
    public static class Front22
    {
        public static string Name = "Front22";
        public static string Description = "Given a string, take the first 2 chars and return the string with the 2 chars added at both the front and back, so 'kitten' yields 'kikittenki'. If the string length is less than 2, use whatever chars are there.";

        public static string ShowAnswer(string str)
        {
            string frontTwoChars = str[0].ToString() + str[1].ToString();

            return frontTwoChars + str + frontTwoChars;
        }
    }
}
