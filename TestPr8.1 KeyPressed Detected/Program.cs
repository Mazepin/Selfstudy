using System;

namespace TestPr8._1_KeyPressed_Detected
{
    class Program
    {
        // Key pressed detected

        static void Main(string[] args)
        {
            // Determining the type of key pressed

            Console.WriteLine("\t===Determining the type of key pressed===");
            Console.WriteLine("Press any key");
            string keyUser = Console.ReadLine();

            var resultType = keyUser.GetTypeCode();
            Console.WriteLine($"Type is: {resultType}");

            // Key pressed detected

            Console.WriteLine();
            Console.WriteLine("\t===Key pressed detected===");
            Console.WriteLine("Press any key");
            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
            Console.WriteLine($"\nYou pressed: {consoleKeyInfo.KeyChar}");

            Console.ReadKey();
        }
    }
}
