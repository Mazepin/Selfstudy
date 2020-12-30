using System;

namespace TestPr9_MinMaxValueArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find minimum and maximum values ​​from an array of numbers

            Console.WriteLine("Enter the size of array: ");
            int NumberElementMassive = int.Parse(Console.ReadLine());
            int[] massive = new int[NumberElementMassive];
            int ElementMaximum = massive[0];// максимальный элемент 
            int ElementMinimum = massive[0];// минимальный элемент
            Random randomizer = new Random();
            Console.WriteLine("Your array of random numbers: ");

            for (int i = 0; i < massive.Length; i++)// рандомайзер чисел
            {
                massive[i] = randomizer.Next(-1000, 1000);
                Console.WriteLine(massive[i]);
            }
            for (int i = 0; i < massive.Length; i++)// сравниваем числа, ищем минимальное
            {
                if (massive[i] < ElementMinimum)
                {
                    ElementMinimum = massive[i];
                }
                else if (massive[i] > ElementMaximum)// сравниваем числа, ищем максимальное
                {
                    ElementMaximum = massive[i];
                }
            }

            Console.WriteLine($"Minimal element in massive is: = {ElementMinimum}");
            Console.WriteLine($"Maximum element in massive is: = {ElementMaximum}");
            Console.ReadLine();
        }
    }
}
