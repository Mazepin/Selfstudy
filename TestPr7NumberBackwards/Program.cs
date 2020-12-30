using System;

namespace TestPr7NumberBackwards
{
    class Program
    {
        static void Main(string[] args)
        {
            // сделать число перевертышь

            int number, result;
            Console.WriteLine("Enter you number:");
            number = int.Parse(Console.ReadLine());
            
            while (number > 0)
            {
                result = result + number % 10;
                number = number / 10;
            }
            
            Console.WriteLine("Your inverted number : ");
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
