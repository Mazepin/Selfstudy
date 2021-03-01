using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace TestPr26._7_OOP__object_oriented_programming__Part7_Object_initialization_syntax
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }

        public void Print(Person person)
        {
            Console.WriteLine($"FirstName: {FirstName} \nLastName: {LastName} \nCountry: {Address.Country} \nRegion: {Address.Region} \nCity: {Address.City}");
            Console.WriteLine("");
        }
    }
}
