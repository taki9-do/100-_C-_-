using System;

namespace _210505_42
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[3];

            Console.Write("input1:");
            a[0] = int.Parse(Console.ReadLine());
            Console.Write("input2:");
            a[1] = int.Parse(Console.ReadLine());
            Console.Write("input3:");
            a[2] = int.Parse(Console.ReadLine());

            if (a[0] <= a[1])
            {
                if (a[1] <= a[2])
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
