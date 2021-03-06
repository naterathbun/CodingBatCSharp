﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBatCSharp.Warmup1
{
    public class Diff21
    {
        public string Name = "Diff21";
        public string Description = "Given an int n, return the absolute difference between n and 21, except return double the absolute difference if n is over 21.";

        static public int ShowAnswer(int n)
        {
            if (n > 21)
            {
                return (2 * Math.Abs(n - 21));
            }
            else
            {
                return Math.Abs(n - 21);
            }
        }
    }
}
