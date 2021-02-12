using System;

namespace TestPr25._2_Enum_Part2
{
    class Program
    {

        // Enum Test program

        enum DayOfWeek : byte // присвоили значение типа byte
        {
            Monday = 1, // по умолчанию начинается с 0 индекса
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            DayOfWeek dayOfWeek = DayOfWeek.Thursday;
            Console.WriteLine("The type is: ");
            Console.WriteLine(Enum.GetUnderlyingType(typeof(DayOfWeek))); // detected type 
            Console.WriteLine(dayOfWeek);

            Console.WriteLine($"\nThe entered day of the week is the {(int)dayOfWeek} in the enumeration");
            Console.WriteLine((int)dayOfWeek); // приводим DayOfWeek к int 

            Console.WriteLine("\nThe second day of the week from the enum is: ");
            Console.WriteLine((DayOfWeek)2); // приводим int к DayOfWeek
                                             //в данном случае день недели из enum который соответсвует 3 индексу

            Console.WriteLine("\nNext day of week: ");
            DayOfWeek nextDay = GetNextDay(dayOfWeek);
            Console.WriteLine(nextDay);

            Console.ReadKey();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="day"></param>
        /// <returns></returns>
        static DayOfWeek GetNextDay(DayOfWeek day)
        {
            if (day < DayOfWeek.Sunday)
                return day + 1;

            return DayOfWeek.Monday;

        }
    }
}
