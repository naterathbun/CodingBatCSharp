using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBatCSharp.Warmup1
{
    public class EveryNth
    {
        public string Name = "EveryNth";
        public string Description = "Given a non-empty string and an int N, return the string made starting with char 0, and then every Nth char of the string. So if N is 3, use char 0, 3, 6, ... and so on.N is 1 or more.";

        public static string ShowAnswer(string str, int n)
        {
            string returnString = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                returnString += str[i].ToString();
                i = i + (n - 1);
            }
            return returnString;
        }
    }
}
