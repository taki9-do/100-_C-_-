using System;

namespace _210511_53
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input number:");
            int input_number = int.Parse(Console.ReadLine());
            int devide = 2;
            int temp = input_number;
            while (temp != 1)
            {
                if (temp % devide == 0)
                {
                    temp /= devide;
                    Console.Write(devide+" ");

                }
                else
                {
                    devide += 1;
                }
            }
        }
    }
}
