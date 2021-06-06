using System;

namespace _210606_80
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("入力1：");
            int a = int.Parse(Console.ReadLine());
            Console.Write("入力2：");
            int b = int.Parse(Console.ReadLine());

            int divisor = 0;

            for(int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    if (b % i == 0)
                    {
                        divisor = i;
                    }
                }
            }

            if (divisor > 1)
            {
                Console.WriteLine("互いに素でない");
            }
            else if(divisor==1)
            {
                Console.WriteLine("互いに素である");

            }
        }
    }
}
