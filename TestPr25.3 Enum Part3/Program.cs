using System;

namespace TestPr25._3_Enum_Part3
{
    class Program
    {
        // ENUM определение и вывод значения на консоль из enum
        enum Color
        {
            White,
            Red,
            Blue,
            Green,
            Orange
        }
        static void Main(string[] args)
        {

            // 1 СПОСОБ определение и вывод значения на консоль из enum 

            Console.WriteLine("Enter the color: ");
            string str = Console.ReadLine();
            Color color = (Color)Enum.Parse(typeof(Color), str, ignoreCase: true); // парсим введенное значение str
                                                                                   // и игнорируем заглавные и маленькие буквы
            Console.WriteLine($"Your color is:  {color}");

            var value = Enum.GetValues(typeof(Color)); // определяем тип enum 
            Console.WriteLine("\nEnum Color: ");
            foreach (var item in value)
            {
                Console.WriteLine(item); // выводим все значения enum на консоль
            }

            // 2 СПОСОБ определение и вывод значения на консоль из enum
            // создаем switch  

            switch (color)      // swith + 2 раза TAB, вписываем colour и автоматически создаются все case 
            {
                case Color.White:
                    Console.WriteLine($"Entered color is: {color}");
                    break;

                case Color.Red:
                    Console.WriteLine($"Entered color is: {color}");
                    break;
                case Color.Blue:
                    Console.WriteLine($"Entered color is: {color}");
                    break;
                case Color.Green:
                    Console.WriteLine($"Entered color is: {color}");
                    break;
                case Color.Orange:
                    Console.WriteLine($"Entered color is: {color}");
                    break;
                default:
                    Console.WriteLine("Incorrect !!!!");
                    break;
            }
        }
    }
}
