using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ar = Fibonacci(10);

            foreach (int item in ar)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
        public static List<int> Fibonacci(int count)
        {
            List<int> ar = new List<int> { 0, 1 };

            for (int i = 2; i < count; i++)
            {
                int twoPrevious = ar[i - 2];
                int onePrevious = ar[i - 1];

                ar.Add(twoPrevious + onePrevious);
            }
            return ar;
        }
    }
}
