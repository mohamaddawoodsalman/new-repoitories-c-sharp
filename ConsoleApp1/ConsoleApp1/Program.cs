using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            for (int i = 5; i > 0; i--)
            {

                Console.WriteLine();
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
            }

            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine();
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
            }
            Console.ReadKey();
        }
    }
}