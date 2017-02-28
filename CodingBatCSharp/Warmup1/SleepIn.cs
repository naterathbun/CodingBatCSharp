using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBatCSharp.Warmup1
{
    public static class SleepIn
    {
        static public string name = "SleepIn";
        static public string description = "The parameter weekday is true if it is a weekday, and the parameter vacation is true if we are on vacation. We sleep in if it is not a weekday or we're on vacation. Return true if we sleep in.";
        
        static public bool ShowAnswer(bool weekday, bool vacation)
        {
            return (vacation || !weekday);
        }

    }
}
