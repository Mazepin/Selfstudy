using System;
using System.Linq;

namespace TestPr18__Method_outputs_a_string_from_characters
{
    class Program
    {
        static void PrintLine(string symbol, uint symbolsCount)
        {
            for (int i = 0; i < symbolsCount; i++)
            {
                Console.Write(symbol);
            }

            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Program.PrintLine("Line ", 10); // Program можно не указавывать, т.к. вызов метода находится в том же class Program
        }
    }
}
