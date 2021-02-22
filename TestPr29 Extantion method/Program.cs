using System;
using LessonMyExtantion; // подключили пространство имен

namespace TestPr29_Extantion_method
{
    class Program
    {
        // Extantion method
        // обязательно static
        // ключевое слово this

        static void Main(string[] args)
        {
            DateTime currentDateTime = DateTime.Now;

            currentDateTime.Print();

            Console.WriteLine(currentDateTime.IsDayOfWeek(DayOfWeek.Sunday)); // проверка если текукщий день недели sunday то true 

            // проверяем на день недели и выполняем какой то код

            if (currentDateTime.IsDayOfWeek(DayOfWeek.Saturday) | currentDateTime.IsDayOfWeek(DayOfWeek.Sunday))
            {
                Console.WriteLine("Today is a day off!  You can drink beer!!!");
            }
            else 
            {
                Console.WriteLine("Today is a weekday! Go undress and work!!!");
            }

            Console.WriteLine();

        }
    }
}
