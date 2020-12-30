using System;

namespace TestPr11_SortingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //sorting array numbers in ascending/descending order

            Console.WriteLine("Enter the size of array: ");
            int NumberElementMassive = int.Parse(Console.ReadLine());
            int[] massive = new int[NumberElementMassive];
            int ElementMassive;

            Random randomizer = new Random();
            Console.WriteLine("Your array of random numbers: ");

            for (int i = 0; i < massive.Length; i++)// рандомайзер чисел
            {
                massive[i] = randomizer.Next(-1000, 1000);
                Console.WriteLine(massive[i]);
            }

            for (int i = 0; i < massive.Length; i++)
            {
                for (int j = i + 1; j < massive.Length; j++)//следующее число массива
                {
                    if (massive[i] > massive[j])//  по возрастанию
                    {
                        ElementMassive = massive[i];// меняем числа местами
                        massive[i] = massive[j];
                        massive[j] = ElementMassive;
                    }

                }
            }

            Console.WriteLine("Sorted ascending array");// вывод отсортированного по возрастанию массива

            for (int i = 0; i < massive.Length; i++)
            {
                Console.WriteLine(massive[i]);
            }

            // тоже самое повторяем практически для вывода по убыванию
            for (int i = 0; i < massive.Length; i++)
            {
                for (int j = i + 1; j < massive.Length; j++)//следующее число массива
                {
                    if (massive[i] < massive[j])// по убыванию
                    {
                        ElementMassive = massive[i];// меняем числа местами
                        massive[i] = massive[j];
                        massive[j] = ElementMassive;
                    }
                }
            }

            Console.WriteLine("Sorted descending array");// вывод отсортированного по убыванию массива

            for (int i = 0; i < massive.Length; i++)
            {
                Console.WriteLine(massive[i]);
            }
            Console.ReadLine();
        }
    }
}
