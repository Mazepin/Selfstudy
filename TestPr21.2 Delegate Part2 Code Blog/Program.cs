using System;

namespace TestPr21._2_Delegate_Part2_Code_Blog
{


    public delegate void MyDelegate(); // объявляем делегат
    class Program
    {
        public delegate int ValueDelegate(int i);  // объявляем делегат
        static void Main(string[] args)
        {

            // 1-ый способ присвоения и вызова делегата

            MyDelegate myDelegate = Method1;   // присваеваем делегату имя метода1
            myDelegate(); // делегат вызывает метод1
            Console.WriteLine("==========");
            myDelegate += Method4;  // добавляем к делегату еще один метод !!!
            myDelegate += Method1; // добавляем еще один метод. Делегат вызывает 3 метода сразу последовательно
            myDelegate();
            Console.WriteLine("==========");

            // 2-ой способ вызова и присвоения делегата

            MyDelegate myDelegate2 = new MyDelegate(Method1);  // вызов конструктора и в качестве параметра передаем имя метода1
            myDelegate2 += Method4; // добавляем к делегату еще один метод4
            myDelegate2.Invoke();
            Console.WriteLine("==========");
            myDelegate2 -= Method4; // удаляем из делегата метод4
            myDelegate2.Invoke();
            Console.WriteLine("==========");
            myDelegate2 = myDelegate + myDelegate2;  // к делегату2 добавляем еще один делегат1
            myDelegate2.Invoke();   // вызываем делегат который вызывает метод1
            Console.WriteLine("==========");

            // 3-ий пример вызова и присвоения делегата

            var valueDelegate = new ValueDelegate(ValueMethod);
            valueDelegate += ValueMethod;  // одно число будет передано во все эти методы ниже!!!
            valueDelegate += ValueMethod;  
            valueDelegate += ValueMethod;
            valueDelegate += ValueMethod;

            valueDelegate((new Random()).Next(1000));   // вызываем делегат и передаем в него рандомное число
            Console.WriteLine("==========");
            valueDelegate(13);  // присваеваем 13 методу ValueMethod через вызов делегат


            Console.ReadLine();
        }

        public static int ValueMethod(int i)
        {
            Console.WriteLine(i);
            return i;
        }

        static void Method1()
        {
            Console.WriteLine("Method1");
        }

        static int Method2()
        {
            Console.WriteLine("Method2");
            return 0;
        }

        static void Method3(int i)
        {
            Console.WriteLine("Method3");
        }

        static void Method4()
        {
            Console.WriteLine("Method4");
        }
    }
}

