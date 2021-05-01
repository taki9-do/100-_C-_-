using System;

namespace _210501_28
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if (a > 0)
            {
                int b = 1;
                for (int i = 0; i < a; i++)
                {
                    b = b * (i + 1);
                }
                Console.WriteLine(b);
            }
            else Console.WriteLine(1);
           
        }

    }
}
