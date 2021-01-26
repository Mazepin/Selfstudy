using System;

namespace TestPr22_Params
{
    class Program
    {
        // Params когда не знаешь сколько параметров в методе будет передано 


        static void Show ( params object[] parameters) // мы не знаем какие параметры будут и сколько передано
        {
            string message = "Тип параметра {0}, значение {1}"; // 0 - выведется значение item.GetType(); 1 - выведется item 

            foreach (var item in parameters)
            {
                Console.WriteLine(message, item.GetType(), item);
            }
        }
        static void Main(string[] args)
        {
            Show("test Igor", 55, true, 5.86f, 'M');

            Console.ReadKey();
        }
        
    }
}
