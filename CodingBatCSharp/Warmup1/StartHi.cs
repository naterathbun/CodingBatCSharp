﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBatCSharp.Warmup1
{
    public static class StartHi
    {
        public static string name = "StartHi";
        public static string description = "Given a string, return true if the string starts with 'hi' and false otherwise.";

        public static bool ShowAnswer(string str)
        {
            return (str[0] == 'h' && str[1] == 'i');
        }
    }
}
