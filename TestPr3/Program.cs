using System;

namespace TestPr3
{
    class Program
    {
        static void Main(string[] args)
        {

            // проверка введенного числа на четность

            double value;
            Console.WriteLine("Введите число ");
            value = double.Parse(Console.ReadLine());

            if (value % 2 == 0)
            {
                Console.WriteLine("Введенное число является четным");
            }
            else
            {
                Console.WriteLine("Введенное число является нечетным");
            }
            Console.ReadLine();


        }
    }
}
