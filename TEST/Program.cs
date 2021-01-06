using System;


namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 2, 45, 846, 231, 5, 78, 34, 88 };

            Console.WriteLine(myArray[^1]);  //выводит первый элемент с конца
            Console.WriteLine(myArray[^2]);  //выводит второй элемент с конца
            Console.WriteLine(myArray[0]);   //выводит первый элемент 
            Console.WriteLine(myArray[1..4]);   //выводит элементы с 1 по 3  индекс, не по 4 !!!!
            Console.WriteLine(myArray[..4]);   // выводит элементы массива с начала по 3 индекс включительно(4 не входит)


            string str = "Hello world !!! =)";

            Console.WriteLine(str[..6]);  // выводит элементы массива стрингового - Hello
            Console.WriteLine(str[^2..]);  // выводит последние 2 элемента -  =)

            int[,] myArray2 =
            {
                {3, 56, 55, 234, 12 },
                {57, 90, 138, 5, 3 },
                {456, 23, 56, 7, 124 }
            };

            int height = myArray2.GetLength(0);
            int width = myArray2.GetLength(1);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(myArray2[i,j] + " ");
                }
                Console.WriteLine();
            }



            Console.ReadLine();
        }
    }
}
