using System;
using System.Collections.Generic;
using System.Text;


namespace TestPr26_OOP__object_oriented_programming_
{
    class Program
    {
        
        enum Color
        {
            Red,
            Green,
            Blue,
            White,
            Yellow,
            Black
        }

        // создаем класс point, можно создать класс в отдельную ветку
        class Point
        {
            public int x;  // значение класса point
            public int y;
            public Color color;  // значение класса point color, состоящее из enum Colour

        }

        static void Main(string[] args)
        {
            // создаем объект класса Point p1

            Point p1 = new Point(); 
            p1.x = 2;
            p1.y = 7;
            p1.color = Color.Red;

            Console.WriteLine("\nFirst point");
            Console.WriteLine($"X: {p1.x} | Y: {p1.y} | Color: {p1.color}");


            // создаем объект класса Point p2

            Point p2 = new Point(); 
            p2.x = 5;
            p2.y = 8;
            p2.color = Color.White;

            Console.WriteLine("\nSecond point");
            Console.WriteLine($"X: {p2.x} | Y: {p2.y} | Color: {p2.color}");
        }
    }
}
