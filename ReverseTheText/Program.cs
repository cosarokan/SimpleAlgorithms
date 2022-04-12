using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseTheText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the text: ");
            string text = Console.ReadLine();

            Console.WriteLine("The reverse of the entered text: " + FindTheReverseTheText(text));

            Console.ReadKey();
        }
        static string FindTheReverseTheText(string text)
        {
            string result = "";

            for (int i = 0; i < text.Length; i++)
            {
                result += text[text.Length - 1 - i];
            }
            return result;
        }
    }
}
