using System;

namespace TestPr9_RemoveDigitFromNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // remove a digit from number

            int result1 = 0, number2 = 1;
            Console.WriteLine("Enter you number:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the digit to be removed from the number :");
            int digit = int.Parse(Console.ReadLine());

            while (number != 0)
            {
                int result = number % 10;
                number = number / 10;
                if (result == digit)
                    continue;

                result1 = result1 + result * number2;
                number2 = number2 * 10;
            }

            Console.WriteLine($"The number without {digit} is: ");
            Console.WriteLine(result1);
            Console.ReadKey();
        }
    }
}
