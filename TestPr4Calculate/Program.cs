using System;

namespace TestPr4Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            // калькулятор простой +,-,*,/

            Console.WriteLine("Введите первое число");
            double firstValue = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите арифметическое действие: '+' '-' '*' '/' ");
            string userSymbol = Console.ReadLine();
            Console.WriteLine("Введите второе число");
            double secondValue = double.Parse(Console.ReadLine());

            switch (userSymbol)
            {
                case "+":
                    Console.WriteLine($"{firstValue} + {secondValue} = {firstValue + secondValue}");
                    break;
                case "-":
                    Console.WriteLine($"{firstValue} - {secondValue} = {firstValue - secondValue}");
                    break;
                case "*":
                    Console.WriteLine($"{firstValue} * {secondValue} = {firstValue * secondValue}");
                    break;
                case "/":
                    if (secondValue == 0)
                    {
                        Console.WriteLine("Невозможно выполнить деление на ноль !");
                    }
                    else
                        Console.WriteLine($"{firstValue} / {secondValue} = {firstValue / secondValue}");
                    break;
                default:
                    Console.WriteLine("Вы ввели неправильные параметры !");
                    break;

                    Console.ReadLine();
            }
        }
    }
}
