using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBatCSharp.Warmup1
{
    public class StartOz
    {
        public string Name = "StartOz";
        public string Description = "Given a string, return a string made of the first 2 chars(if present), however include first char only if it is 'o' and include the second only if it is 'z', so 'ozymandias' yields 'oz'.";

        public static string ShowAnswer(string str)
        {
            string returnString = string.Empty;

            if (str[0] == 'o')
            {
                returnString += str[0].ToString();
            }
            if (str[1] == 'z')
            {
                returnString += str[1].ToString();
            }

            return returnString;
        }
    }
}
