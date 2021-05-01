using System;
using System.Linq;

namespace _210501_29
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine(a.Sum());
        }
    }
}
