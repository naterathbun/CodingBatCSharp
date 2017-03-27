using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBatCSharp.Warmup2
{
    public class Array123
    {
        public string Name = "Array123";
        public string Description = "Given an array of ints, return true if the sequence of numbers 1, 2, 3 appears in the array somewhere.";

        public static bool ShowAnswer(int[] myArray)
        {
            if (myArray.Length < 3)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < myArray.Length - 2; i++)
                {
                    if (myArray[i] == 1 && myArray[i + 1] == 2 && myArray[i + 2] == 3)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
