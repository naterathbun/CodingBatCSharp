using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBatCSharp.Warmup1
{
    public class MissingChar
    {
        public string name = "MissingChar";
        public string description = "Given a non-empty string and an int n, return a new string where the char at index n has been removed.The value of n will be a valid index of a char in the original string (i.e.n will be in the range 0..str.length()-1 inclusive).";

        static public string ShowAnswer(string str, int n)
        {
            if (n > 0)
            {
                return str.Substring(0, n) + str.Substring(n + 1, str.Length - (n + 1));
            }
            else
                return str.Substring(1, str.Length - 1);
        }
    }
}
