using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBatCSharp.Warmup2
{
    public class ArrayFront9
    {
        public string Name = "ArrayFront9";
        public string Description = "Given an array of ints, return true if one of the first 4 elements in the array is a 9. The array length may be less than 4.";

        public static bool ShowAnswer(int[] myArray)
        {
            for (int i = 0; i < 4; i++)
            {
                if(i < myArray.Length && myArray[i] == 9)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
