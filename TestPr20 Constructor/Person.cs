using System;

namespace TestPr20_Constructor
{
    class Person
    {
        public string name;
        public int age;
        public double height;
        public double weight;

        public Person(string n, int a, double h, double w) { name = n; age = a; height = h; weight = w; } // конструктор

        public void GetInfo ()
        {
            Console.WriteLine($"Имя: {name}  \nВозраст: {age}  \nРост: {height}  \nВес {weight}");
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя: ");
            string name = Console.ReadLine();

            Console.WriteLine("Введите возраст: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите рост: ");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите вес: ");
            double weight = double.Parse(Console.ReadLine());

            Person Adult = new Person(name, age, height, weight);
            Adult.GetInfo();

            Console.ReadKey();

        }
    }
}
