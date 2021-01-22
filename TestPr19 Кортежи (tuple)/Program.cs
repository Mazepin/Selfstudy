using System;

namespace TestPr19_Кортежи__tuple_
{
    class Program
    {
        static void Main(string[] args)
        {
            // примеры вывода кортежей и обозначение

            var korteg = (5, 7); // кортеж
            Console.WriteLine(korteg.Item1); // 5
            Console.WriteLine(korteg.Item2); // 7
            korteg.Item2 += 25;
            Console.WriteLine(korteg.Item2); // 32

            var korteg1 = (count: 5, sum: 10);  // присвоение названий полям кортежа
            Console.WriteLine(korteg1.count); // 5
            Console.WriteLine(korteg1.sum); // 10

            (string, int, double) korteg3 = ("Igor", 37, 67.5);
            Console.WriteLine($"Меня зовут: {korteg3.Item1} \nМой возраст : {korteg3.Item2} \nМой вес : {korteg3.Item3}");



            // ========================
            // возвращение нескольких параметров кортежа из метода

            var tuple = GetValues();
            Console.WriteLine(tuple.Item1); // 1
            Console.WriteLine(tuple.Item2); // 3
            Console.ReadKey();

        }
        private static (int, int) GetValues()
        {
            var result = (1, 3);
            return result;

        }


    }
}
