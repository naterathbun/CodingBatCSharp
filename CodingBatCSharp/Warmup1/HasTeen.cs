using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBatCSharp.Warmup1
{
    public static class HasTeen
    {
        public static string Name = "HasTeen";
        public static string Description = "We'll say that a number is 'teen' if it is in the range 13..19 inclusive. Given 3 int values, return true if 1 or more of them are teen.";

        public static bool ShowAnswer(int a, int b, int c)
        {
            bool aIsTeen = a >= 13 && a <= 19;
            bool bIsTeen = b >= 13 && b <= 19;
            bool cIsTeen = c >= 13 && b <= 19;

            return aIsTeen || bIsTeen || cIsTeen;
        }
    }
}
