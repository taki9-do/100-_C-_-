using System;

namespace _210502_31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input:");
            int a = int.Parse(Console.ReadLine());

            for(int i = 1; i <= a; i++)
            {
                if (i == 1)
                {
                    Console.Write("*");
                }
                else if ((i % 5) == 1)
                {
                    Console.Write("\t"+"*");

                }
                else
                {
                    Console.Write("*");

                }
            }
            
        }
    }
}
