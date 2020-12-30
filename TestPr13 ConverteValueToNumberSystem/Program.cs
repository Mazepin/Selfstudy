using System;

namespace TestPr13_ConverteValueToNumberSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // displaying a number in the selected number system

            Console.WriteLine("Select the system number: 2, 8, 10 or 16 ");
            int SystemNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your number");
            int number = Convert.ToInt32(Console.ReadLine());

            if (SystemNumber == 2)
            {
                Console.Write("Your number in binary = ");
                Console.WriteLine(Convert.ToString(number, 2));
            }
            else if (SystemNumber == 8)
            {
                Console.Write("Your number in 8 system = ");
                Console.WriteLine(Convert.ToString(number, 8));
            }
            else if (SystemNumber == 10)
            {
                Console.Write("Your number in 10 system = ");
                Console.WriteLine(number);
            }
            else if (SystemNumber == 16)
            {
                Console.Write("Your number in 16 system = ");
                Console.WriteLine(Convert.ToString(number, 16));
            }
            else
            {
                Console.WriteLine("Your system number is not correct");
            }

            Console.ReadKey();
        }
    }
}
