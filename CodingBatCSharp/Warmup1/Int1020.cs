using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBatCSharp.Warmup1
{
    public class Int1020
    {
        public string Name = "Int1020";
        public string Description = "Given 2 int values, return true if either of them is in the range 10..20 inclusive.";

        public static bool ShowAnswer(int a, int b)
        {
            return ((a <= 20 && a >= 10) || (b <= 20 && b >= 10));
        }
    }
}
