using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBatCSharp.Warmup1
{
    public static class In3050
    {
        public static string Name = "In3050";
        public static string Description = "Given 2 int values, return true if they are both in the range 30..40 inclusive, or they are both in the range 40..50 inclusive.";

        public static bool ShowAnswer(int a, int b)
        {
            bool a30To40 = a <= 40 && a >= 30;
            bool b30To40 = b <= 40 && b >= 30;
            bool a40To50 = a <= 50 && a >= 40;
            bool b40To50 = b <= 50 && b >= 40;

            return ((a30To40 && b30To40) || (a40To50 && b40To50));
        }
    }
}
