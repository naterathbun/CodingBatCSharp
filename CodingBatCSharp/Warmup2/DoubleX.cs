using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBatCSharp.Warmup2
{
    public class DoubleX
    {
        public string Name = "DoubleX";
        public string Description = "Given a string, return true if the first instance of 'x' in the string is immediately followed by another 'x'.";

        public static bool ShowAnswer(string str)
        {
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == 'x' & str[i + 1] == 'x')
                {
                    return true;
                }
            }
            return false;
        }
    }
}
