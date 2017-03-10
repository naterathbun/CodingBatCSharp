using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBatCSharp.Warmup1
{
    public class Or35
    {
        public string Name = "Or35";
        public string Description = "Return true if the given non-negative number is a multiple of 3 or a multiple of 5. Use the % 'mod' operator.";

        public static bool ShowAnswer(int n)
        {
            return ((n % 3 == 0) || (n % 5 == 0));
        }
    }
}
