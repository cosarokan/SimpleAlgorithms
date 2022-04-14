using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IsPrimeNumber(11);

            Console.ReadKey();
        }
        static void IsPrimeNumber(int x)
        {
            bool isPrimeNumber = false;

            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                {
                    isPrimeNumber = true;
                    break;
                }
            }
            if (isPrimeNumber == false)
            {
                Console.WriteLine("It is a prime number.");
            }
            else
            {
                Console.WriteLine("It is not a prime number.");
            }
        }
    }
}
