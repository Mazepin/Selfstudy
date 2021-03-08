using System;
using System.IO;
using System.Text;

namespace TestPr31._1_Stream__FileStream__Using__Try_Catch_Finally
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var sw = new StreamWriter("document.txt", true, Encoding.UTF8))
            {
                Console.WriteLine("Enter your Name: ");
                string name = Console.ReadLine();
                sw.WriteLine(name);

                Console.WriteLine("Enter your Last Name: ");
                string lastName = Console.ReadLine();
                sw.WriteLine(lastName);

                Console.WriteLine("Enter your Date of Birthday (dd-mm-yyyy): ");
                DateTime dayBirthday1 = new DateTime();
                var dayBirthday = DateTime.TryParse(Console.ReadLine(), out dayBirthday1);
                sw.WriteLine(dayBirthday1);

                Console.ReadLine();




            }
        }
    }
}
