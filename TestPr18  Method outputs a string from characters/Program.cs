using System;
using System.Linq;

namespace TestPr18__Method_outputs_a_string_from_characters
{
    class Program
    {
        static void PrintLine(string symbol, uint symbolsCount)  // метод для вывода строки
        {
            for (int i = 0; i < symbolsCount; i++)
            {
                Console.Write(symbol);
            }

            Console.ReadLine();
        }

        static void PrintChar(char symbolChar, uint symbolsCountChar)    // метод для вывода символа
        {
            for (int i = 0; i < symbolsCountChar; i++)
            {
                Console.Write(symbolChar);
            }

            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            // вызываем метод для вывода строки

            Console.WriteLine("Enter string: ");
            string symbolEnter = Console.ReadLine();

            Console.WriteLine("Enter the required number of string for output");
            uint symbolsCountOutput = uint.Parse(Console.ReadLine());

            Program.PrintLine(symbolEnter, symbolsCountOutput); // Program можно не указавывать, т.к. вызов метода находится в том же class Program


            // =========================
            // вызываем метод для вывода символа

            Console.WriteLine("Enter a char: ");
            char symbolChar = Console.ReadKey().KeyChar;

            Console.WriteLine("\nEnter the required number of characters for output");
            uint symbolsCountChar = uint.Parse(Console.ReadLine());

            Program.PrintChar(symbolChar, symbolsCountChar);

        }
    }
}
