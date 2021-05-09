using System;

namespace _210509_48
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input number:");
            int a = int.Parse(Console.ReadLine());
            int count = 1;

            while (a != 1)
            {
                if ((a % 2) == 0)
                {
                    a /= 2;
                    Console.WriteLine(count + ":" + a);
                }
                else if ((a % 2) == 1)
                {
                    a = a * 3 + 1;
                    Console.WriteLine(count + ":" + a);

                }
                count++;
            }

            

        }
    }
}
