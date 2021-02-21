using System;

namespace TestPr27_Overloading_class_constructors
{
    // Overloading class constructors

    class Student
    {
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private DateTime _berthday;
        private Guid _id;

        public Student(string lastName, DateTime berthday)
        {
            _lastName = lastName;
            _berthday = berthday;
        }

        public Student(string firstName, string middleName, string lastName, DateTime berthday)
        {
            _firstName = firstName;
            _middleName = middleName;
            _lastName = lastName;
            _berthday = berthday;
        }

        public Student(Student student) // Overloading class constructors
        {
            _firstName = student._firstName;
            _middleName = student._middleName;
            _lastName = student._lastName;
            _berthday = student._berthday;
        }

        public void Id()
        {
            _id = Guid.NewGuid();
        }

        public void Print()
        {
            Console.WriteLine($"Name: {_firstName} \nMiddleName: {_middleName}  \nLastName: {_lastName}  \nBerthday: {_berthday}  \nID: { _id}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nEnter First Name: ");
            string firstName1 = Console.ReadLine();

            Console.WriteLine("Enter Middle Name: ");
            string middleName1 = Console.ReadLine();

            Console.WriteLine("Enter Last Name: ");
            string lastName1 = Console.ReadLine();

            Console.WriteLine("Enter berthday:");
            DateTime berthday1 = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("\t===Student===");
            Student student1 = new Student(firstName1, middleName1, lastName1, berthday1); // создаем объект класса Student
            student1.Print();

            Console.WriteLine("\t===Student===");
            Student student2 = new Student(student1);  // создаем копию объекта класса Student с параметрами student1
            student2.Id();
            student2.Print(); // добавляем значение ID к копии первого стдента, не изменяя значения student1 

            Console.ReadKey();
        }
    }
}
