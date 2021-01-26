using System;
using System.Threading; // это пространство имен поддерживает многопоточность

namespace TestPr23_Thread_basic_knowledge
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread myThread = new Thread(func); // создаем новый объект потока

            myThread.Start(); // запускаем поток

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("1-ый поток выводит" + i);
                Thread.Sleep(0);
            }

            Console.Read(); // приостанавливаем основной поток

            
            Console.WriteLine($"Запущен ли поток:  {myThread.IsAlive}");  // запущен ли поток
            // Console.WriteLine($"Приоритет потока:  {myThread.Priority}");
            Console.WriteLine($"Статус потока:  {myThread.ThreadState}");  // статус потока

            Console.ReadKey();

            // функция запускаемая из другого потока

            static void func()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("2-ой поток выводит" + i);
                    Thread.Sleep(0);
                }
            }

            Console.ReadKey();


        }
    }
}
