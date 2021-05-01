using System;

namespace _210501_18
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            int b = int.Parse(Console.ReadLine());
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = b;
                Console.WriteLine(a[i]);
            }

            
        }
    }
}
