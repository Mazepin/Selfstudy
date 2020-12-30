using System;

namespace TestPr12_CombineArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //combine two arrays

            int[] FirstArray = new[] { 2, 5, 6, 8, 9 };//первый упорядоченный массив
            int[] SecondArray = new[] { 1, 3, 5, 7, 9 };// второй упорядоченный массив
            int ElementMassive;

            Console.WriteLine("First ordered array");

            for (int i = 0; i < FirstArray.Length; i++)
            {
                Console.WriteLine(FirstArray[i]);
            }

            Console.WriteLine("Second ordered array");

            for (int j = 0; j < SecondArray.Length; j++)
            {
                Console.WriteLine(SecondArray[j]);
            }

            //int[] combine = FirstArray.Concat(SecondArray).ToArray();//объединяем 2 массива
            int[] combine = new int[FirstArray.Length + SecondArray.Length];
            int index = 0;

            for (int i = 0; i < FirstArray.Length; i++)
            {
                combine[index++] = FirstArray[i];
            }

            for (int i = 0; i < FirstArray.Length; i++)
            {
                combine[index++] = SecondArray[i];
            }
            // была мысль объединить как то так, но не получалось ничего. Пришлось посмотреть CONTACT

            for (int i = 0; i < combine.Length; i++)// распределяем по возрастанию
            {
                for (int j = i + 1; j < combine.Length; j++)//следующее число массива
                {
                    if (combine[i] > combine[j])//  по возрастанию
                    {
                        ElementMassive = combine[i];// меняем числа местами
                        combine[i] = combine[j];
                        combine[j] = ElementMassive;
                    }
                }
            }

            Console.WriteLine("Combine two arrays");

            foreach (var Result in combine)// перебираем поочередно все элементы массива
            {
                Console.Write($" {Result}");
            }
            Console.ReadLine();
        }
    }
}
