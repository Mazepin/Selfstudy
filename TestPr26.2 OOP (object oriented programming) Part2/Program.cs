using System;

namespace TestPr26._2_OOP__object_oriented_programming__Part2
{
    class Program
    {
        static Student GetStudent() // создаем метод GetStudent 
        {
            Student student = new Student();  // создаем экземпляр класса Student 

            student.firstName = "Igor";
            student.lastName = "Mazepin";
            student.middleName = "Mihailovich";
            student.age = 37;
            student.group = "TMS06";
            student.ID = Guid.NewGuid();

            return student;
        }

        // создаем метод Print
        static void Print(Student student)
        {
            Console.WriteLine("Information about student");
            Console.WriteLine($"ID: {student.ID}");
            Console.WriteLine($"Name: {student.firstName}");
            Console.WriteLine($"Surname: {student.lastName}");
            Console.WriteLine($"Patronymic: {student.middleName}");
            Console.WriteLine($"Age: {student.age}");
            Console.WriteLine($"Group: {student.group}");

        }

        static void Main(string[] args)
        {
            var firstStudent = GetStudent();

            Print(firstStudent);
        }
    }
}

