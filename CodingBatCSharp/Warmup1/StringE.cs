using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBatCSharp.Warmup1
{
    public static class StringE
    {
        public static string Name = "StringE";
        public static string Description = "Return true if the given string contains between 1 and 3 'e' chars.";

        public static bool ShowAnswer(string str)
        {
            int eCount = 0;

            for (int i = 0; i < str.Count(); i++)
            {
                if (str[i] == 'e')
                {
                    eCount++;
                }
            }
            return (eCount >= 1 && eCount <= 3);
        }
    }
}
