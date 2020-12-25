using System;

namespace TestPr1
{
    class Program
    {
        // среднее арифметическое двух чисел
        static void Main(string[] args)
        {
            double firstValue, secondValue, result1;

            Console.WriteLine("Введите первое значение числа");
            firstValue = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Введите второе значение числа");
            secondValue = double.Parse(Console.ReadLine());
            
            result1 = (firstValue + secondValue) / 2;
            Console.WriteLine("---------------------------");
            Console.WriteLine(" Первое число " + firstValue);
            Console.WriteLine(" Второе число " + secondValue);
            Console.WriteLine("Среднее арифметическое значение двух чисел = " + result1);
            Console.ReadLine();

        }
    }
}
