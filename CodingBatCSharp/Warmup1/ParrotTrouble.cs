using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBatCSharp.Warmup1
{
    public static class ParrotTrouble
    {

        static public string name = "ParrotTrouble";
        static public string description = "We have a loud talking parrot.The 'hour' parameter is the current hour time in the range 0..23. We are in trouble if the parrot is talking and the hour is before 7 or after 20. Return true if we are in trouble.";

        static public bool ShowAnswer(bool talking, int hour)
        {
            return ((talking && hour < 7) || (talking && hour > 20));
        }
    }
}
