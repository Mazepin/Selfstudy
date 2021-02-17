using System;

namespace TestPr21._4_Delegate_Event
{
    class Program
    {
        // Delegate Event, EventHandler

        public delegate int DelegateValue(int i);

        public delegate void MyDelegate();

        public event MyDelegate DelegateEvent; // объявляем событие

        public event Action EventeAction; // это событие совпадает с тем что выше

        static void Main(string[] args)
        {
            Person person = new Person();

            Console.WriteLine("Entet a name of Person");
            person.NamePerson = Console.ReadLine();

            person.GoToSleep += Person_GoToSleep; // присвоили событие GoToSleep 
            person.NotSleepNow += Person_NotSleepNow; // подписываемся на событие NotSleepNow


            person.TakeTime(DateTime.Now);
            //person.TakeTime(DateTime.Parse("16-02-2021 19:24:07"));
            //person.TakeTime(DateTime.Parse("16-02-2021 4:24:07"));

            Console.ReadLine();
        }

        private static void Person_NotSleepNow(object sender, EventArgs e)
        {
            if (sender is Person)   // выполняем проверку от неправильного ввода
            {
                Console.WriteLine($"{((Person)sender).NamePerson} does not sleep now !!!"); // приводим object к типу person
            }
        }

        private static void Person_GoToSleep()
        {
            Console.WriteLine("Person go to sleep !!!");
        }
    }
}
