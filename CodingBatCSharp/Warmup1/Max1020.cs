using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBatCSharp.Warmup1
{
    public static class Max1020
    {
        public static string Name = "Max1020";
        public static string Description = "Given 2 positive int values, return the larger value that is in the range 10..20 inclusive, or return 0 if neither is in that range.";

        public static int ShowAnswer(int a, int b)
        {
            bool aInRange = a >= 10 && a <= 20;
            bool bInRange = b >= 10 && b <= 20;

            if (aInRange && bInRange)
            {
                return Math.Max(a, b);
            }
            else if (aInRange)
            {
                return a;
            }
            else if (bInRange)
            {
                return b;
            }
            return 0;
        }
    }
}
