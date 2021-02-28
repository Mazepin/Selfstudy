using System;

namespace TestPr30_Const_vs_Readonly
{

    // const and readonly 
    // const - When we create a constant that cannot be changed. And we know the value of the constant in advance
    // readonly - When we create a constant that cannot be changed. And we DONT know the value of the constant in advance

    class Program
    {
      
        static void Main(string[] args)
        {
            Car car = new Car(new MyLogger());

            car.Drive();
            car.StartEngine();
            car.StartEngine();
            car.Drive();

            Console.ReadKey();
        }
    }
}
