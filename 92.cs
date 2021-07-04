using System;

namespace _210704_92
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 51; i++)
            {
                if (i % 3 == 0 && (i != 0))
                {
                    Console.Write("aho ");

                }
                else if (i % 10 == 3)
                {
                    Console.Write("aho ");
                }
                else if ((i / 10) % 3 == 0 && i > 9)
                {
                    Console.Write("aho ");
                }
                Console.WriteLine(i);

            }
        }
    }
}
