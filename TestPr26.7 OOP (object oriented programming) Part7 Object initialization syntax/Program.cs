using System;

namespace TestPr26._7_OOP__object_oriented_programming__Part7_Object_initialization_syntax
{
    class Program
    {
        static void Main(string[] args)
        {
            //OOP Object initialization syntax

            // first method initialization syntax

            Person person1 = new Person();
            person1.FirstName = "Igor";
            person1.LastName = "Mazepin";
            Address address1 = new Address();
            address1.Country = "Belarus";
            address1.Region = "Minsk Region";
            address1.City = "Minsk";
            person1.Address = address1;

            // second method initialization syntax
            // it's better to use this initialization method

            Person person2 = new Person
            {
                FirstName = "Igor",    // use a comma, not a semicolon
                LastName = "Mazepin",
                Address = new Address
                {
                    Country = "Belarus",
                    Region = "Minsk Region",
                    City = "Minsk",

                }
            };

            person1.Print(person1);
            person2.Print(person2);

            Console.ReadKey();

        }
    }
}
