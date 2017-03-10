using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBatCSharp.Warmup1
{
    public class Close10
    {
        public string Name = "Close10";
        public string Description = "Given 2 int values, return whichever value is nearest to the value 10, or return 0 in the event of a tie.Note that Math.abs(n) returns the absolute value of a number.";

        public static int ShowAnswer(int a, int b)
        {
            if (Math.Abs(10 - a) < Math.Abs(10 - b))
            {
                return a;
            }
            else if (Math.Abs(10 - a) > Math.Abs(10 - b))
            {
                return b;
            }
            else
            {
                return 0;
            }
        }
    }
}
