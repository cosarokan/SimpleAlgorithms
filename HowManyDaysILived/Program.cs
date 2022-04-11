using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowManyDaysILived
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the your date of birth: ");
            DateTime date = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("You lived " + HowManyDaysILived(date) + " days");

            Console.ReadKey();
        }
        static int HowManyDaysILived(DateTime dateTime)
        {
            DateTime date = DateTime.Now;
            TimeSpan result = (date - dateTime);

            int totalDays = Convert.ToInt32(result.TotalDays);


            return totalDays;
        }
    }
}
