using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeCalculate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Your date of birth: ");
            DateTime dateTime = Convert.ToDateTime(Console.ReadLine());
            
            Console.WriteLine("Your Age: " + AgeCalculate(dateTime));

            Console.ReadKey();
        }
        public static int AgeCalculate(DateTime date)
        {
            DateTime dateTime = DateTime.Now;
            return dateTime.Year - date.Year;
        }
    }
}
