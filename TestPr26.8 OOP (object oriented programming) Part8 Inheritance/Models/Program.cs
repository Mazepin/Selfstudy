using System;

namespace TestPr26._8_OOP__object_oriented_programming__Part8_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // OOP Part8 Inheritance

            Teacher teacher = new Teacher { FirstName = "Igor", LastName = "Mazepin" };
            teacher.GetFullName();
            teacher.Teach();
            Console.WriteLine("");

            Student student = new Student { FirstName = "Anton", LastName = "Makarov" };
            student.GetFullName();
            student.TeachStudent();
            Console.WriteLine("");

            Security security = new Security { FirstName = "Radion", LastName = "Borodach" };
            security.GetFullName();
            security.Guard();
            Console.WriteLine("");

            // output to the console in a different way

            Person[] people = { teacher, student, security };
            PrintPersons(people);

            static void PrintPersons(Person[] people)
            {
                foreach (var person in people)
                {
                    person.GetFullName();
                }
            }

            Console.ReadKey();

        }
    }
}
