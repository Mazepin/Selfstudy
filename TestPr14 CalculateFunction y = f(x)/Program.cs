using System;

namespace TestPr14_CalculateFunction_y___f_x_
{
    class Program
    {
        static void Main(string[] args)
        {
            // calculate function value y = f(x)

            double y;
            Console.Write("We have a function y = f(x)" + "\n Enter \nx = ");
            double x = double.Parse(Console.ReadLine());

            if (x > 0)
            {
                y = 2 * x - 10;
            }
            else if (x == 0)
            {
                y = 0;
            }
            else
            {
                y = 2 * Math.Abs(x) - 1;
            }

            Console.Write("Result \ny = {0}", y);
            Console.ReadKey();
        }
    }
    // Вычислить значение функции y = f(x).
    //С клавиатуры вводится x.
    //y = 2x – 10, если x > 0
    //y = 0, если x = 0
    //y = 2 * | x | -1, если x< 0
}
