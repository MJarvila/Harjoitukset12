using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj12Teht5
{
    class ArrayCalcs
    {
            public static double Sum(double[] array)
            {
                Console.Write("Summa ");
                return array.Sum();
            }
            public static double Average(double[] array)
            {
                Console.Write("Keskiarvo ");
                return array.Average();
            }
            public static double Max(double[] array)
            {
                Console.Write("Max ");
                return array.Max();
            }
            public static double Min(double[] array)
            {
                Console.Write("Min ");
                return array.Min();
            }
        }
}
