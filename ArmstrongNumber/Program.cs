using System;
using System.Collections.Generic;
using System.Linq;

namespace ArmstrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in FindTheArmstrongNumber(1000))
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
        static bool IsTheArmstrongNumber(int value)
        {
            // it finds whether the entered number is armstrong number
            string stringValue = value.ToString();
            int[] intArray = stringValue.ToArray().Select(x => Convert.ToInt32(x.ToString())).ToArray();

            double total = 0;
            for (int i = 0; i < intArray.Length; i++)
            {
                double pow = Math.Pow(intArray[i], 3);
                total += pow;
            }
            return Convert.ToInt32(total) == value;
        }

        static List<int> FindTheArmstrongNumber(int value)
        {
            // it returns all armstrong numbers.
            List<int> ar = new List<int>();

            for (int i = 1; i < value; i++)
            {
                if (IsTheArmstrongNumber(i) == true)
                {
                    ar.Add(i);
                }
            }
            return ar;
        }

    }
}
