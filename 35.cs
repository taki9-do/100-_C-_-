using System;

namespace _210502_35
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a= { 3, 7, 0, 8, 4, 1, 9, 6, 5, 2 };
            Console.Write("input index1:");
            int i = int.Parse(Console.ReadLine());
            Console.Write("input index2:");
            int j = int.Parse(Console.ReadLine());


            Console.WriteLine(a[i]+"*"+a[j]+"="+a[i]*a[j]);

           
            
        }
    }
}
