using System;

namespace _210509_47
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input a:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("input b:");
            int b = int.Parse(Console.ReadLine());

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine("a="+a+",b="+b);
        }
    }
}
