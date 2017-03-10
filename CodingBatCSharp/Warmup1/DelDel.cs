using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBatCSharp.Warmup1
{
    public class DelDel
    {
        public string Name = "DelDel";
        public string Description = "Given a string, if the string 'del' appears starting at index 1, return a string where that 'del' has been deleted.Otherwise, return the string unchanged.";

        public static string ShowAnswer(string str)
        {
            if (str.Length >= 4 && str.Substring(1, 3) == "del")
            {
                return str[0].ToString() + str.Substring(4);
            }
            else
            {
                return str;
            }
        }
    }
}
