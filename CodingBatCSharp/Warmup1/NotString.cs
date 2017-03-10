using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBatCSharp.Warmup1
{
    public class NotString
    {
        public string name = "NotString";
        public string description = "Given a string, return a new string where 'not ' has been added to the front. However, if the string already begins with 'not', return the string unchanged. Note: use .equals() to compare 2 strings.";

        public static string ShowAnswer(string str)
        {
            if (str.Length > 3 && str.Substring(0, 4).Equals("Not "))
            {
                return str;
            }
            else
                return "Not " + str;
        }
    }
}
