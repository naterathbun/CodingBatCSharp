using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBatCSharp.Warmup2
{
    public class ArrayCount9
    {
        public string Name = "ArrayCount9";
        public string Description = "Given an array of ints, return the number of 9's in the array.";

        public static int ShowAnswer(int[] array1)
        {
            int count = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                if(array1[i] == 9)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
