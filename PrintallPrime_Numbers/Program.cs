using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintallPrime_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime numbers between 1 and 100:");

            for (int i = 1; i <= 100; i++)
            {
                bool isPrime = true;

                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.ReadKey();
        }
    }
    
}
