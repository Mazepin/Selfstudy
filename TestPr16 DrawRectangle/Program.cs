using System;

namespace TestPr16_DrawRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            // рисуем прямоугольник

            Console.Write("Введите высоту прямоугольника: ");
            int height = int.Parse(Console.ReadLine());

            Console.Write("Введите ширину треуголника: ");
            int widht = int.Parse(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < widht; j++)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
