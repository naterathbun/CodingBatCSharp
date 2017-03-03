using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBatCSharp.Warmup1
{
    public static class Front3
    {

        public static string name = "Front3";
        public static string description = "Given a string, we'll say that the front is the first 3 chars of the string. If the string length is less than 3, the front is whatever is there. Return a new string which is 3 copies of the front.";

        static public string ShowAnswer(string str)
        {
            string returnString = "";

            if (str.Length < 4)
            {
                returnString = str;
            }
            else if (str.Length >= 4)
            {
                returnString += str[0].ToString() + str[1].ToString() + str[2].ToString();
            }

            return returnString + returnString + returnString;
        }
    }
}
