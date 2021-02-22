using System;
using System.Collections.Generic;
using System.Text;

namespace LessonMyExtantion  // создали пространство имен 
{
    // создаем extantion method
    // обязательно static
    // ключевое слово this 

    static class MyExtantion
    {
        public static void Print(this DateTime dateTime)
        {
            Console.WriteLine(dateTime);
        }

        public static bool IsDayOfWeek(this DateTime dateTime, DayOfWeek dayOfWeek)
        {
            return dateTime.DayOfWeek == dayOfWeek;
        }
    }
}
