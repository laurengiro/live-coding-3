using System;
using System.Collections.Generic;

namespace LiveCoding3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[] { 1, 5, 2 };
            int[] array2 = new int[] { 3, 4, 6 };
            ZippedArray(array1, array2);
        }

        static void ZippedArray(int[] array1, int[] array2)
        {
            int zipped_len = 2 * array1.Length;
            int[] zippedArray = new int[zipped_len];

            int single_array_position = 0;

            for (int x = 0; x < array1.Length; x++)
            {
                zippedArray[single_array_position] = array1[x];
                single_array_position++;
                zippedArray[single_array_position] = array2[x];
                single_array_position++;
            }

            Console.WriteLine("[" + string.Join(",", zippedArray) + "]");
        }
    }
}
