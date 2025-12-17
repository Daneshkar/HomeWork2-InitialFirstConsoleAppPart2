using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2.Task3
{
    class Statistics
    {
        public static void AnalyzeNumbers(int a, ref int b, out int c)
        {
            // محاسبه مجموع عدد اول و دوم
            c = a + b;

            // رساندن عدد دوم به توان 2
            b = b * b;

            // چاپ عدد اول بدون تغییر
            Console.WriteLine("عدد اول داخل متد: " + a);
        }
    }

    
}
