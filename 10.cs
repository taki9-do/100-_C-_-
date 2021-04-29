using System;

namespace _210430_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if (a < 0)
            {
                a = -a;
            }

            Console.WriteLine(a);

        }
    }
}
