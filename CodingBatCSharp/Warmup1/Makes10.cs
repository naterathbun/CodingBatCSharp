using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBatCSharp.Warmup1
{
    public static class Makes10
    {
        public static string name = "Makes10";
        public static string description = "Given 2 ints, a and b, return true if one if them is 10 or if their sum is 10.";

        public static bool ShowAnswer(int a, int b)
        {
            return (a == 10 || b == 10 || a + b == 10);
        }

    }
}
