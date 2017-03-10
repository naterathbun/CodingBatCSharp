using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBatCSharp.Warmup1
{
    public class LastDigit
    {
        public string Name = "LastDigit";
        public string Description = "Given two non-negative int values, return true if they have the same last digit, such as with 27 and 57. Note that the % 'mod' operator computes remainders, so 17 % 10 is 7.";

        public static bool ShowAnswer(int a, int b)
        {
            return (a % 10 == b % 10);
        }
    }
}
