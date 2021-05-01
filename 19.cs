using System;

namespace _210501_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("input:"+(a[i] = int.Parse(Console.ReadLine())));
                

                
            }
            for (int j = 0; j < a.Length; j++)
            {
                Console.WriteLine(a[j]);
            }
            
        }
    }
}
