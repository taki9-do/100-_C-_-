using System;

namespace _210502_38
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 3, 7, 0, 8, 4, 1, 9, 6, 5, 2 };
            int temp = 0;
            for(int i = 0; i < 10; i++)
            {
                
                Console.WriteLine(a[temp]);
                temp = a[temp];
            }


        }
    }
}
