using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2.Task4
{
    class ArrayAnalyzer
    {
        // متد AnalyzeArray
        public static void AnalyzeArray(int[] array, ref int max, out double average)
        {
            // اگر آرایه خالی باشد
            if (array == null || array.Length == 0)
            {
                max = 0;
                average = 0.0;
                return;
            }

            int sum = 0;
            max = array[0];

            foreach (int num in array)
            {
                if (num > max)
                    max = num;

                sum += num;
            }

            average = (double)sum / array.Length;
        }
    }
}
