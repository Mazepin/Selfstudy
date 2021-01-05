using System;

namespace TestPr17_Massive
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1) заполнение (ввод) массива с клавиатуры
            // 2) вывод введенного массива в обратном порядке
            // 3) сумма четных и нечетных чисел массива
            // 4) находим наименьшее число в массиве


            //заполнение (ввод) массива с клавиатуры

            Console.Write("Введите колличество элеметов массива: ");
            int sizeArray = int.Parse(Console.ReadLine());
            int[] myArray = new int[sizeArray];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"Введите {i} элемент массива: ");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            //вывод введенного массива

            Console.WriteLine("===========================");
            Console.WriteLine("Введенный вами массив: ");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            //вывод введенного массива в обратном порядке

            Console.WriteLine("===========================");
            Console.WriteLine("Ваш массив в обратном порядке: ");

            for (int j = myArray.Length - 1; j >= 0; j--)
            {
                Console.WriteLine(myArray[j]);
            }

            //сумма четных и нечетных чисел массива

            Console.WriteLine("===========================");

            int countEven = 0;
            int countAdd = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0)
                {
                    countEven += myArray[i];
                }
                else
                {
                    countAdd += myArray[i];
                }
            }

            Console.WriteLine("\nСумма четных значений массива равна: " + countEven);
            Console.WriteLine("\nСумма нечетных значений массива равна: " + countAdd);

            //находим наименьшее число в массиве

            int elementMinArray = myArray[0];

            for (int i = 1; i < myArray.Length; i++)
            {
                if (myArray[i] < elementMinArray)
                {
                    elementMinArray = myArray[i];
                }
            }

            Console.WriteLine($"\nНаименьшее значение массива: {elementMinArray}");

            Console.ReadLine();
        }
    }
}

