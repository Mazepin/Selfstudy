using System;

namespace TestPr24_Рекурсия
{
    class Program
    {

        // Вывод массива с помощью рекурсии

        static void PrintArray(int[] myArray, int i = 0)
        {
            if (i < myArray.Length)
            {
                Console.WriteLine(myArray[i]);
                PrintArray(myArray, i + 1);
            }
        }
        static void Main(string[] args)
        {
            int[] myArray = { 2, 5, 3 };
            PrintArray(myArray);
            Console.ReadKey();
        }
    }
}
