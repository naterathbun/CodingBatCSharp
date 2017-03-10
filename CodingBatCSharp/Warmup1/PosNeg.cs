using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBatCSharp.Warmup1
{
    public class PosNeg
    {
        public string Name = "PosNeg";
        public string Description = "Given 2 int values, return true if one is negative and one is positive.Except if the parameter 'negative' is true, then return true only if both are negative.";

        public static bool ShowAnswer(int a, int b, bool negative)
        {
            if (negative)
            {
                return (a < 0 && b < 0);
            }
            else
            {
                return ((a < 0 && b > 0) || (a > 0 && b < 0));
            }
        }
    }
}
