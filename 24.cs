using System;

namespace _210501_24
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if (a < 0)
            {
                if (a >= -10) Console.WriteLine("OK");
                else Console.WriteLine("NG");
                
            }
            else if (a >= 10) Console.WriteLine("OK");
            else Console.WriteLine("NG!");
        }
    }
}
