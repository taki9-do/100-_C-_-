using System;

namespace _210502_34
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input:");
            int a = int.Parse(Console.ReadLine());

            for (int i = 1; i < 10; i++)
            {
                if ((i == a)|| (i ==a+1 ))
                {

                }
                else
                {
                    Console.WriteLine(i);

                }
            }
        }
    }
}
