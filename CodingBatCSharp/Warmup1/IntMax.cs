using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBatCSharp.Warmup1
{
    public class IntMax
    {
        public string Name = "Int Max";
        public string Description = "Given three int values, a b c, return the largest.";

        public static int ShowAnswer(int a, int b, int c)
        {
            int maxInt;

            if (a > b)
            {
                maxInt = a;
            }
            else
            {
                maxInt = b;
            }
            if (c > maxInt)
            {
                maxInt = c;
            }

            return maxInt;
        }
    }
}
