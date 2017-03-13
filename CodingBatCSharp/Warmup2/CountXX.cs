using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBatCSharp.Warmup2
{
    public class CountXX
    {
        public string Name = "CountXXTest";
        public string Description = "Count the number of 'xx' in the given string. We'll say that overlapping is allowed, so 'xxx' contains 2 'xx'";

        public static int ShowAnswer(string str)
        {
            int counter = 0;

            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == 'x' && str[i+1] == 'x')
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
