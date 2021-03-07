using System;
using System.IO;
using System.Text;

namespace TestPr31_Stream__FileStream__Using__Try_Catch_Finally
{
    class Program
    {
        static void Main(string[] args)
        {
            // Открыть
            // Прочитать/ записать
            // Закрыть

            Console.OutputEncoding = Encoding.UTF8; // кодировка консоли

            // Запись в файл. Файл создается в папке проекта
            // без true файл постоянно будет перезаписываться, с true будет дописываться в файл test.txt
            // также можно третим параметром указать кодировку Encoding.UTF8

            using (var sw = new StreamWriter("test.txt", true, Encoding.UTF8 )) // объект будет доступен только в этом методе. Using автоматически его закрывает
            {
                sw.WriteLine("\nLearning the method of writing text to a file and reading from the file"); // сохраняет текст в файл test.txt
                sw.WriteLine("Hello, World"); // сохраняет текст в файл test.txt
                sw.Write("Hello, User"); // сохраняет текст в файл test.txt
                sw.Write(" Igor"); // сохраняет текст в файл test.txt без перехода на следующую строку
            }

            // Чтение из файла

            using(var sr = new StreamReader("test.txt"))
            {
                while(!sr.EndOfStream)   // читает не весь файл а перебирает его
                {
                    Console.WriteLine(sr.ReadLine() + "\tend of string");
                }

                sr.DiscardBufferedData(); // позволяет перейти вначало текста файла
                sr.BaseStream.Seek(0, SeekOrigin.Begin);  // у основного потока мы вызываем метод перехода к определенной таблице устанавливаем на начало 

                var text = sr.ReadToEnd(); // ReadToEnd позволяет прочитать файл от начала до конца
                Console.WriteLine(text);
            }

            Console.ReadLine();
        }
    }
}
