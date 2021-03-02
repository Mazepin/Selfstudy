using System;
using System.Collections.Generic;
using System.Text;

namespace TestPr26._8_OOP__object_oriented_programming__Part8_Inheritance
{
    class Teacher : Employee // inherits all fields of the class Employee
    {
        public void Teach()
        {
            Console.WriteLine("I teach children!");
        }
    }
}
