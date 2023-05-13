using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonnacci_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 15;
            int a = 0;
            int b = 1;
            int c;

            Console.WriteLine("Fibonacci sequence up to {0}:", n);

            Console.WriteLine("{0} {1} ", a, b);

            for (int i = 1; i < n; i++)
            {
                c = a + b;
                Console.WriteLine("{0} ", c);
                a = b;
                b = c;
            }
            Console.ReadKey();
        }
    }
}

