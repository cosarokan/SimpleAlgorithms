using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheChar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the text: ");
            string text = Console.ReadLine();

            Console.Write("Enter the char: ");
            char x = Convert.ToChar(Console.ReadLine());

            Console.WriteLine(AreThereAnyCharEnteredInTheText(text, x));

            Console.ReadKey();
        }
        static bool AreThereAnyCharEnteredInTheText(string text, char x)
        {
            bool result = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == x)
                {
                    result = true;
                }
            }
            return result;
        }
    }
}
