using System;

namespace TestPr26._3_OOP__object_oriented_programming__Part3_Inheritance
{

    // OOP Part3 Inheritance (наследование)

    class Animal // создаем класс Animal 
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public void Print()
        {
            Console.WriteLine(Name);
        }
    }
    class Cat : Animal  // создаем класс Cat он наследует все свойства от Animal
    {
        private float speed; // создали приватную велечину в других классах она недоступна
        public Cat(float speed, string name) : base(name)
        {
            this.speed = speed;
            Console.WriteLine("Speed: " + speed);
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Cat tom = new Cat(15.6f, "Tom"); 
            Console.WriteLine(tom.Name);
            Console.WriteLine("=======");

            Cat jerry = new Cat(23.8f, "Jerry");
            Console.WriteLine(jerry.Name); 
            Console.WriteLine("=======");

            jerry.Print(); // вывели тоже самое что и Console.WriteLine(jerry.Name) только через метод Print

            Console.ReadKey();
        }
    }
}
