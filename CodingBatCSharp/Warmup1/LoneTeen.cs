using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBatCSharp.Warmup1
{
    public static class LoneTeen
    {
        public static string Name = "LoneTeen";
        public static string Description = "We'll say that a number is 'teen' if it is in the range 13..19 inclusive. Given 2 int values, return true if one or the other is teen, but not both.";

        public static bool ShowAnswer(int a, int b)
        {
            bool aIsTeen = a <= 19 && a >= 13;
            bool bIsTeen = b <= 19 && b >= 13;

            return aIsTeen ^ bIsTeen;
        }
    }
}
