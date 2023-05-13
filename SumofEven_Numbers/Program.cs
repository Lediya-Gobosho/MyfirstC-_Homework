using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumofEven_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 20;

            int sum = 0;

            for (int i = 1; i <= n; i += 1)
            {
                sum += i;
            }

            Console.WriteLine("The sum of all even numbers from 1 to {0} is {1}", n, sum);
            Console.ReadKey();
        }
    }
}
