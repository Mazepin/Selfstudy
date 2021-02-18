using System;
using System.Collections.Generic;

namespace TestPr21_List
{
    class Program
    {
        static void Main(string[] args)
        {
            // List testing

            List<int> number = new List<int>() { 2, 34, 7, 68, 9 };

            foreach (int i in number)
            {
                Console.Write(i + " ");
            }

            number.Add(6); // добавление элемента

            number.Insert(0, 777); // вставляем на первое место в списке число 777

            number.RemoveAt(1); // удаляем второй элемент

            Console.WriteLine();

            foreach (int i in number)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine("\n=====================");
            List<Person> people = new List<Person>();
            people.Add(new Person() { Name = "Igor" });
            people.Add(new Person() { Name = "Bill" });

            foreach (Person p in people)
            {
                Console.WriteLine(p.Name);
            }

            Console.ReadLine();
        }
    }

    class Person
    {
        public string Name { get; set; }
    }


}


