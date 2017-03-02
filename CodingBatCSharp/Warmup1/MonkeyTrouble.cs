﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBatCSharp.Warmup1
{
    public static class MonkeyTrouble
    {
        public static string name = "MonkeyTrouble";
        public static string description = "We have two monkeys, a and b, and the parameters aSmile and bSmile indicate if each is smiling. We are in trouble if they are both smiling or if neither of them is smiling. Return true if we are in trouble.";

        static public bool ShowAnswer(bool aSmile, bool bSmile)
        {
            return ((aSmile && bSmile) || (!aSmile && !bSmile));
        }
    }
}