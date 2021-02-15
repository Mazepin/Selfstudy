using System;

namespace TestPr21._3_Delegate_Action__Predicate_and_Func
{
    class Program
    {


        // Delegate Action, Predicate & Func

        //public delegate void Action(); // можно не объявлять вот так, т.к. Action это уже подразумевает
        // объявили встроенную (шаблонную) делегату Action, которая не возвращает нам значения

        static void Main(string[] args)
        {

            #region DELEGATE
            // ACTION

            Action action = Method1; // объявляем делегат и присваеваем ему значение метода1. Выше эту делегату можно не объявлять!!!
            action();

            Action<int> action1;   // СООТВЕТСТВУЕТ вот этому встроенному объявлению public delegate void Action (int i)
            Action<int, int, string> action2;  // СООТВЕТСТВУЕТ public delegate Action (int, int, string)
            Console.WriteLine("===========");


       // PREDICATE

            Predicate<object> predicate1;  //  СООТВЕТСТВУЕТ объявлению public delegate bool Predicate(int value);
                                           // в качестве возвращаемого значения true или false 
                                           // используется для сравнения, сопоставления некоторого объекта object определенному условию
            
            Predicate<int> isPositive = delegate (int x) { return x > 0; };

            Console.WriteLine(isPositive(20));  // TRUE
            Console.WriteLine(isPositive(-20));  // FALSE
            Console.WriteLine("===========");

       // FUNC

            Func<string, char, int> function1;  // СООТВЕТСТВУЕТ public delegate int Func(string str, char c)
                                                // ПОСЛЕДНИЙ параметр int - это мы задаем тип возвращаемого значения
                                                // далее до 16 штук типы аргументов, может их не быть
            Func<int, int> function2 = ValueMethod;

            function2?.Invoke((new Random().Next(1000)));  // обязательно нужно делать проверку
            // или можно было записать так эту строку
            // if (function2 != null)   
            // function2((new Random().Next(1000)));


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
        #endregion
    }
}
