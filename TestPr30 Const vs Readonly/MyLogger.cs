using System;
using System.Collections.Generic;
using System.Text;

namespace TestPr30_Const_vs_Readonly
{
    class MyLogger
    {
        public void Info(string message)
        {
            Console.WriteLine($"{DateTime.Now}\t|INFO|\t{message}");
        }
        public void Error(string message)
        {
            Console.WriteLine($"{DateTime.Now}\t|ERROR|\t{message}");
        }
        public void Warning(string message)
        {
            Console.WriteLine($"{DateTime.Now}\t|WARNING|\t{message}");
        }
    }
}
