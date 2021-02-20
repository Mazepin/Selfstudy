using System;

namespace TestPr13._2_ConverteValueToNumberSystem_Part2_TryParse_and_Convert
{
    class Program
    {
        // конвертация через Convert(try & catch), через Parse и TryParse (с проверкой но без выброса исключений)

        static void Main(string[] args)
        {
            Console.WriteLine("\t===Convertion throught Converte===");
            string str = "135";
            int a = Convert.ToInt32(str);  // конвертируем значение str "5" в значение int (число) 5
            Console.WriteLine(a);
            Console.WriteLine("=======");

            Console.WriteLine("\t===Convertion throught Parse===");
            int a1 = int.Parse(str); // конвертируе строку в число через parse
            Console.WriteLine(a1);
            Console.WriteLine("=======");

            // исключение через try catch при конвертации

            Console.WriteLine("\t===Convertion throught Parse with Exception===");
            Console.WriteLine("Enter number");
            string number = Console.ReadLine();

            try
            {
                int num = int.Parse(number);
                Console.WriteLine("Successful convertation !!! ");
            }
            catch (Exception)
            {
                Console.WriteLine("Error convertation");
                throw;
            }
            Console.WriteLine("=======");

            // исключения через TryParse при конвертации

            Console.WriteLine("\t===Convertion throught TryParse with Exception===");
            Console.WriteLine("Enter number 2");
            string number2 = Console.ReadLine();
            int result2;

            bool result3 = int.TryParse(number2, out result2); // конвертируем введенное число number2 c  
                                                               // проверкой на исключения без вывода исключения(ошибки) и присвоения выходного
                                                               // значения result2 значения типа int
                                                               // TryParse возвращает занчение bool
            if (result3)
            {
                Console.WriteLine("Successful convertation !!! ");
            }
            else
            {
                Console.WriteLine("Error convertation");
            }

            Console.WriteLine(result2);
            Console.WriteLine("========");


            Console.WriteLine("\t===Convertion throught Converte to bool===");
            Console.WriteLine("Enter true or false ");
            string str2 = Console.ReadLine();

            bool b = Convert.ToBoolean(str2);  // конвертируем ввод значения str2 в bool через Convert 

            if (!b)
            {
                Console.WriteLine("You enter false");
            }
            else
            {
                Console.WriteLine("You enter true");
            }
            Console.WriteLine("========");


            Console.WriteLine("Enter password");
            string password = Console.ReadLine();
            var result = Convert.GetTypeCode(password); // определяем тип введенного значенияд
            Console.WriteLine(result);
            Console.WriteLine("======");

            bool result1 = Convert.ToBoolean(result);

            var result1Type = Convert.GetTypeCode(result1);

            Console.WriteLine(result1Type);

            Console.ReadKey();
        }
    }
}

