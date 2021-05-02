using System;

namespace _210502_32
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i < 21; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine(i);

                }
                else if ((i % 5) == 0)
                {
                    Console.WriteLine("bar");
                }
                else
                {
                    Console.WriteLine(i);

                }
            }
        }
    }
}
