using System;

namespace _210504_41
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input:");
            int a = int.Parse(Console.ReadLine());

            if ((a >= 0) && (a < 9))
            {
                Console.WriteLine(a+" is single figure");
            }

           
            Console.WriteLine(a+"is not single figure");
        }
    }
}
