using System;

namespace TestPr26._4_OOP__object_oriented_programming__Part4
{
    class Program
    {
        // OOP(object oriented programming) Part4

        class Car
        {
            private int speed = 0;
            public void PrintSpeed()
            {
                if (speed > 0)
                {
                    Console.WriteLine($"The car is moving forward at a speed: {speed} km/h");
                }
                if (speed < 0)
                {
                    Console.WriteLine($"The car is moving backward at a speed: {-speed} km/h");
                }
                else
                {
                    Console.WriteLine($"The car is stop");
                }
            }

            public void GetForWard()
            {
                speed = 60;
            }

            public void Stop()
            {
                speed = 0;
            }

            public void MoveBackWard()
            {
                speed = -5;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\t====Car1====");

            var car1 = new Car();

            car1.PrintSpeed();
            car1.GetForWard();
            car1.PrintSpeed();
            car1.MoveBackWard();
            car1.PrintSpeed();
            car1.Stop();
            car1.PrintSpeed();

            Console.WriteLine("\n\t====Car2====");

            var car2 = new Car();

            car2.MoveBackWard();
            car2.PrintSpeed();
            car2.Stop();
            car2.PrintSpeed();
            car2.GetForWard();
            car2.PrintSpeed();

            Console.ReadKey();
        }
    }
}
