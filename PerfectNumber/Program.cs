using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Perfect Numbers: A number whose sum of all positive divisors excluding itself is equal to itself.

            List<int> numbers = PerfectNumber(1, 1000);

            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
        static List<int> PerfectNumber(int x, int y)
        {
            List<int> ar = new List<int>();

            for (int i = x; i < y; i++)
            {
                if (i == SumOfDivisiors(i))
                {
                    ar.Add(i);
                }
            }
            return ar;
        }
        static int SumOfDivisiors(int x)
        {
            int total = 0;

            for (int i = 1; i < x; i++)
            {
                if (x % i == 0)
                {
                    total += i;
                }
            }
            return total;
        }
    }
}
