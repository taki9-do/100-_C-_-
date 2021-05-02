using System;

namespace _210502_37
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] a = { 3, 7, 0, 8, 4, 1, 9, 6, 5, 2 };
            Console.Write("input index:");
            int i = int.Parse(Console.ReadLine());
            

            int temp = a[i];

            Console.WriteLine("value = "+ a[temp]);
        }
    }
}
