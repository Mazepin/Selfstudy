using System;
using System.Collections.Generic;
using System.Text;

namespace TestPr26._8_OOP__object_oriented_programming__Part8_Inheritance
{
    class Student : Person // inherits all fields of the class Person
    {
        public void TeachStudent()
        {
            Console.WriteLine("I'm learning!");
        }
    }
}
