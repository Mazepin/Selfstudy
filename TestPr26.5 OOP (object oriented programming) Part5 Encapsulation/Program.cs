using System;

namespace TestPr26._5_OOP__object_oriented_programming__Part5_Encapsulation
{
    // OOP Part5 Encapsulation

    class Gun
    {
        public Gun(bool isLoaded)
        {
            _isLoaded = isLoaded;
        }
        private bool _isLoaded; // обязательное условие для выстрела, поэтому ставим private и инкапсулируем

        private void ReLoad()  // инкапсулируем 
        {
            Console.WriteLine("Loading weapon...");

            _isLoaded = true;

            Console.WriteLine("The gun is loaded");
        }

        public void Shoot()
        {
            if (!_isLoaded)
            {
                Console.WriteLine("The gun is not loaded...");
                ReLoad();
            }
            Console.WriteLine("Shot!!!");
            _isLoaded = false;
        }

    }
    class program
    {
        static void Main(string[] args)
        {
            Gun gun = new Gun(true);  // если заряжен
            gun.Shoot();
            Console.WriteLine("========");


            Gun gun1 = new Gun(false);  // если не заряжен
            gun1.Shoot();

            Console.ReadKey();
        }
    }
}
