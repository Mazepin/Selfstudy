using System;

namespace TestPr2
{
    class Program
    {
        static void Main(string[] args)
        {
            // конвертер валют USD в EUR, BYN

            double USDtoEUR = 0.82;
            double USDtoBYN = 2.56;
            double USD;

            Console.WriteLine("ВВедите сумму долларах USD ");
            USD = double.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------");
            Console.WriteLine(USD + " USD в EUR = " + USD*USDtoEUR + " EUR");
            Console.WriteLine(USD + " USD в BYN = " + USD*USDtoBYN + " BYN");
            Console.ReadLine();
        }
    }
}
