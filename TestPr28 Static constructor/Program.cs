using System;

namespace TestPr28_Static_constructor
{
    // Static constructor

    class DbRepository
    {
        private static string connectionString;

        static DbRepository() // создаем статический конструктор который вызовется только один раз
        {
            ConfigurationManager configurationManager = new ConfigurationManager();
            connectionString = configurationManager.GetConnectionString();
        }

        public void GetData()
        {
            Console.WriteLine("Used: " + connectionString);
        }
    }

    class ConfigurationManager
    {
        public string GetConnectionString()
        {
            return "local DB";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DbRepository dbRepository = new DbRepository();

            dbRepository.GetData();

            Console.ReadKey();
        }
    }
}
