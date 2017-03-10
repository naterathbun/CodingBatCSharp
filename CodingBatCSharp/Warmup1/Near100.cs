using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBatCSharp.Warmup1
{
    public class Near100
    {
        public string name = "Near100";
        public string description = "Given an int n, return true if it is within 10 of 100 or 200. Note: Math.abs(num) computes the absolute value of a number.";

        public static bool ShowAnswer(int n)
        {
            return (Math.Abs(n - 100) <= 10 || Math.Abs(n - 200) <= 10);
        }
    }
}
