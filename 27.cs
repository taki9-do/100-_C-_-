using System;
using System.Linq;

namespace _210501_27
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if (a > 0)
            {
                int[] b = new int[a];

                for (int i = 0; i < a; i++)
                {
                    b[i] = i + 1;
                }

                Console.WriteLine(b.Sum());
            }
            else Console.WriteLine("0");
            
        }
    }
}
