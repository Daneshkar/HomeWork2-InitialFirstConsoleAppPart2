using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Statistics
    {
        public string AnalyzeNumbers(int a, ref int b, out int c)
        {
            c = a + b;
            b = b * 2;
            return a.ToString();
        }
    }
}
