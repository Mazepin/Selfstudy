using System;
using MyLibrary;

namespace TestPr27_dll___creating_a_class_library
{
    class Program
    {
        static Student GetStudent()
        {
            Student student = new Student();

            student.firstName = "Inna";
            student.lastName = "Mazepina";
            student.middleName = "Victorovna";
            student.age = 33;
            student.ID = Guid.NewGuid();
            student.group = "TMS06";

            return student;
        }

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
            var firstPerson = GetStudent();

            Print(firstPerson);

            Console.ReadKey();

        }
    }
}
