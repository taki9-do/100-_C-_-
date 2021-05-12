using System;

namespace _210512_58
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] box = new int[5];

            for(int i = 0; i < box.Length; i++)
            {
                Console.Write("input data[" + i + "]:");
                box[i] = int.Parse(Console.ReadLine());

            }

            for(int j = 0; j < box.Length; j++)
            {
                Console.Write(box[j] + "\t:");
                for(int k = 1; k <= box[j]; k++)
                {
                    Console.Write("*");
                    if (k % 5 == 0) 
                    { 
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
