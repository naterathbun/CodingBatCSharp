using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBatCSharp.Warmup1
{
    public class SumDouble
    {
        public string Name = "SumDouble";
        public string Description = "Given two int values, return their sum.Unless the two values are the same, then return double their sum.";

        static public int ShowAnswer(int a, int b)
        {
            if (a == b)
            {
                return 2 * (a + b);
            }
            else
            {
                return (a + b);
            }
        }
    }
}
