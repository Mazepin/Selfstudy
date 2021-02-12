using System;

namespace TestPr25._1_Enum_Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            // definition of the key that was pressed on the keyboard

            while (true)
            {
                Console.WriteLine("\nPress any key \nif you press the key ENTER, the program will exit");

                ConsoleKey key = Console.ReadKey().Key; // enum console

                int keyKode = (int)key;

                Console.WriteLine($"\tEnum key:  {key} \tKey code: {keyKode}");

                if (key == ConsoleKey.Enter)
                {
                    Console.WriteLine("You pressed Enter!");
                    return;
                }
            }
        }
    }
}
