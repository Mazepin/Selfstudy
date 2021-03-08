using System;

namespace TestPr7._1_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            // DateTime
            // Обработчик введенного дня недели
            {
                bool firstDate = false;
                bool secondDate = false;
                DateTime date = new DateTime();
                DateTime date1 = new DateTime();

                while (!firstDate)
                {
                    Console.WriteLine(" Введите начальную дату (число-месяц-год): ");
                    firstDate = DateTime.TryParse(Console.ReadLine(), out date);

                    if (!firstDate)
                    {
                        Console.WriteLine("Ошибка!!! Неверный формат ( dd-mm-yyyy)!!! Попробуйте снова ");
                    }
                }

                while (!secondDate)
                {
                    Console.WriteLine(" Введите конечную дату (число-месяц-год): ");
                    secondDate = DateTime.TryParse(Console.ReadLine(), out date1);

                    if (!secondDate)
                    {
                        Console.WriteLine("Ошибка!!! Неверный формат ( dd-mm-yyyy)!!! Попробуйте снова ");
                    }
                    else if (date > date1)
                    {
                        Console.WriteLine("Ошибка!!! Вторая дата должна идти после первой. Попробуйте снова ");
                    }
                }

                Console.WriteLine("----------------------------");
                Console.WriteLine(" Начальная дата - " + date);
                Console.WriteLine(" Конечная дата - " + date1);
                Console.WriteLine("----------------------------");

                Console.WriteLine(" Введите значение дня недели (на английском): ");
                var userInput = Console.ReadLine();
                Console.WriteLine("----------------------------");

                while (date1 >= date)
                {
                    if (date.DayOfWeek.ToString() == userInput)
                    {
                        Console.WriteLine("Искомому дню недели соответсвует " + date + date.DayOfWeek);
                    }
                    date = date.AddDays(1);
                }
                Console.ReadLine();
            }
        }
    }
}
