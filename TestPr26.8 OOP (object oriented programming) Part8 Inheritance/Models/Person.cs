using System;
using System.Collections.Generic;
using System.Text;

namespace TestPr26._8_OOP__object_oriented_programming__Part8_Inheritance
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void GetFullName()
        {
            Console.WriteLine($"Name: {FirstName} \tLastName: {LastName}");
        }
    }
}
