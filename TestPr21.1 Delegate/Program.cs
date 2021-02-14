using System;

namespace TestPr21._1_Delegate
{
    class Program
    {
        public int GoodMorning { get; set; }
        public int GoodEvening { get; set; }

        delegate void Message();            // объявляем делегат
        static void Main(string[] args)
        {
            Message mes;                   // создаем переменную делегата

            if (DateTime.Now.Hour < 12)
            {
                mes = GoodMorning;         // присваеваем этой переменной адрес метода
            }
            else
            {
                mes = GoodEvening;
            }

            mes();                         //  вызываем метод 

            Console.ReadKey();


            static void GoodMorning()
            {
                Console.WriteLine("GoodMorning");
            }

            static void GoodEvening()
            {
                Console.WriteLine("GoodEvening");
            }
        }
    }
}
