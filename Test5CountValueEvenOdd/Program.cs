using System;

namespace Test5CountValueEvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            // подсчет четных и нечетных чисел в введенном диапазоне и сложение четных и нечетных чисел

            uint countEvenValue = 0;
            uint countOddValue = 0;

            int evenNumberSumm = 0;
            int oddNumberSumm = 0;

            Console.WriteLine("Введите начальное значение диапазона");
            int minimumValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите конечное значение диапазона");
            int maximumValue = int.Parse(Console.ReadLine());

            while (minimumValue <= maximumValue)
            {
                if (minimumValue % 2 == 0)
                {
                    countEvenValue++;
                    evenNumberSumm = evenNumberSumm + minimumValue;
                }
                else
                {
                    oddNumberSumm = oddNumberSumm + minimumValue;
                    countOddValue++;
                }
                minimumValue++;
            }

            Console.WriteLine("Колличество нечетных числе: " + countEvenValue);
            Console.WriteLine("Колличество четных чисел: " + countOddValue);
            Console.WriteLine("Сумма четных чисел: " + evenNumberSumm);
            Console.WriteLine("Сумма нечетных чисел: " + oddNumberSumm);
            Console.ReadLine();
        }
    }
}
