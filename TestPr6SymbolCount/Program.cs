using System;

namespace TestPr6SymbolCount
{
    class Program
    {
        // вывод символа введенного пользователем, столько раз, сколько захочет пользователь. Вывод через метод
        static void PrintString(string symbol, uint symbolCount)
        {
            for (int i = 0; i < symbolCount; i++)
            {
                Console.Write(symbol);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символ: ");
            string symbolUser = Console.ReadLine();

            Console.WriteLine("Введите количество символов: ");
            uint symbolCountUser = uint.Parse(Console.ReadLine());

            Console.WriteLine("=========================");
            PrintString(symbolUser, symbolCountUser);            // вызываем метод PrintString
            Console.ReadLine();
        }
    }
}
