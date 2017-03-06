using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBatCSharp.Warmup1
{
    public static class IcyHot
    {
        public static string Name = "IcyHot";
        public static string Description = "Given two temperatures, return true if one is less than 0 and the other is greater than 100.";

        public static bool ShowAnswer(int temp1, int temp2)
        {
            return ((temp1 < 0 && temp2 > 100) || (temp1 > 100 && temp2 < 0));
        }
    }
}
