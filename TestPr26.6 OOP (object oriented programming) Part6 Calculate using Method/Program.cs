using System;

namespace TestPr26._6_OOP__object_oriented_programming__Part6_Calculate_using_Method
{
    class Program
    {
        // Calculate (using Method)

        static double Addition(double a, double b)
        {
            double result = a + b;
            Console.WriteLine($"{a} + {b} = {result}");

            return result;
        }
        static double Subtraction(double a, double b)
        {
            double result = a - b;
            Console.WriteLine($"{a} - {b} = {result}");

            return result;
        }

        static double Multiply(double a, double b)
        {
            double result = a * b;
            Console.WriteLine($"{a} * {b} = {result}");

            return result;
        }

        static double Division(double a, double b)
        {
            if (b != 0)
            {
                double result = a / b;
                Console.WriteLine($"{a} / {b} = {result}");
            }
            else
            {
                Console.WriteLine("Error!!! Division by zero");
            }
            return a / b;
        }
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("==============");
                Console.WriteLine("\nEnter first number: ");
                string number1 = Console.ReadLine();
                double _number1;
                bool a = double.TryParse(number1, out _number1);

                Console.WriteLine("Enter arithmetic operation ");
                string operation = Console.ReadLine();

                Console.WriteLine("Enter second number: ");
                // double _number2 = double.Parse(Console.ReadLine()); // можно так запарсить

                string number2 = Console.ReadLine();
                double _number2;
                bool b = double.TryParse(number2, out _number2);

                switch (operation)
                {
                    case "+":
                        Addition(_number1, _number2);
                        break;
                    case "-":
                        Subtraction(_number1, _number2);
                        break;
                    case "*":
                        Multiply(_number1, _number2);
                        break;
                    case "/":
                        Division(_number1, _number2);
                        break;
                    default:
                        Console.WriteLine("\nIncorrect input!!!");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}

