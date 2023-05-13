using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplaytheGreater_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first integer: ");
            int firstnumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the second integer: ");
            int secondnumber = int.Parse(Console.ReadLine());

            if (firstnumber > secondnumber)
            {
                Console.WriteLine("{0} is greater than {1}", firstnumber, secondnumber);
            }
            else if (secondnumber > firstnumber)
            {
                Console.WriteLine("{0} is greater than {1}", secondnumber, firstnumber);
            }
            else
            {
                Console.WriteLine("The two numbers are equal");
            }
            Console.ReadKey();
        }
    }
}
