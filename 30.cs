using System;

namespace _210501_30
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.Write("input:");
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("\n");
        }
    }
}
