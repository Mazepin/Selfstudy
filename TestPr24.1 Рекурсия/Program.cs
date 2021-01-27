using System;

namespace TestPr24._1_Рекурсия
{
    class Program
    {
        // Найти сумму элементов массива с помощью рекурсии

        static int Sum(int[] myArray, int i = 0)
        {
            if (i >= myArray.Length)
            {
                return 0;
            }

            int result = Sum(myArray, i + 1);  // рекурсия, вызываем метод в методе

            return myArray[i] + result;  // обязательный выход из рекурсии
        }
        static void Main(string[] args)
        {
            int[] myArray = { 356, 2, 77 };
            int result = Sum(myArray);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
