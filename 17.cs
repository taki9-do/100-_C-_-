using System;

namespace _210501_17
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = i;
                Console.WriteLine(a[i]);
            }

            
        }
    }
}
