using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class ArrayAnalyzer
    {
        public void AnalyzeArray(int[] array, ref int max, out double average)
        {
            if (array == null || array.Length == 0)
            {
                max = 0;
                average = 0.0;
                return;
            }
            max = array[0];
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                sum += array[i];
            }
            average = (double)sum / array.Length;
        }
    }
}
