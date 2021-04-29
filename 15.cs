using System;

namespace _210430_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            for(int i = 0; i < a; i += 2)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}
