using System;

namespace _210511_50
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i < 101; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine("foobar");

                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("foo");

                }
                else if (i % 5 == 0)
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
