using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj12Teht5
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };

            Console.WriteLine(ArrayCalcs.Sum(array));
            Console.WriteLine(ArrayCalcs.Average(array));
            Console.WriteLine(ArrayCalcs.Max(array));
            Console.WriteLine(ArrayCalcs.Min(array));
        }
    }
}
