using System;

namespace _210511_56
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input number:");
            int number = int.Parse(Console.ReadLine());
            int[] box = new int[16];

            for(int i = 0; i < box.Length; i++)
            {
                box[i] = number % 2;
                number /= 2;
            }

            for(int j = 15; j >= 0; j--)
            {
                Console.Write(box[j]);

            }
        }
    }
}
