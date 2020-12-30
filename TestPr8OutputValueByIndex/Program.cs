using System;

namespace TestPr8OutputValueByIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            // вывод значения из числа по введенному индексу

            Console.WriteLine("Enter you number : ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter you index of number : ");
            int index = int.Parse(Console.ReadLine());
            index -= 1; // если понятно, что отчисление начинается с 0, то эта строка не нужна

            string result = number.ToString();

            Console.WriteLine("The index of the number corresponds to the digit :");
            Console.WriteLine(result[index]);
            Console.ReadKey();
        }
    }
}
