using System;

namespace _210501_23
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if (a >= -5)
            {
                if (a < 10)
                {
                    Console.WriteLine("OK");

                }
                else
                {
                    Console.WriteLine("NG");

                }
            }
            else
            {
                Console.WriteLine("NG");

            }
        }
    }
}
