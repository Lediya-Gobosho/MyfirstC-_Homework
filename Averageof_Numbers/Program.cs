using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Averageof_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, };

            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }

            double average = (double)sum / numbers.Count;

            Console.WriteLine("The average of the numbers is {0}", average);
            Console.ReadKey();
        }
    }
}
