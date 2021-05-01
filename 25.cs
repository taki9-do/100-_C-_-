using System;

namespace _210501_25
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if (a >= 0)
            {
                Console.WriteLine("range 3");

            }
            else if (a >= -10)
            {
                Console.WriteLine("range 2");

            }
            else
            {
                Console.WriteLine("range 1");

            }
            
        }
    }
}
