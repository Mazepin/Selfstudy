using System;

namespace TestPr26._5_OOP__object_oriented_programming__Part5_Encapsulation
{
    // OOP Part5 Encapsulation

    class Gun
    {
        private bool isLoaded; // обязательное условие для выстрела, поэтому ставим private и инкапсулируем

        private void ReLoad()  // инкапсулируем 
        {
            Console.WriteLine("Loading weapon...");

            isLoaded = true;

            Console.WriteLine("The gun is loaded");
        }

        public void Shoot()
        {
            if (!isLoaded)
            {
                Console.WriteLine("The gun is not loaded...");
                ReLoad();
            }
            Console.WriteLine("Shot!!!");
            isLoaded = false;
        }

    }
    class program
    {
        static void Main(string[] args)
        {
            Gun gun = new Gun();
            gun.Shoot();

            Console.ReadKey();
        }
    }
}
