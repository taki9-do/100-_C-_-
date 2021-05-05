using System;

namespace _210505_43
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] confi = new int[3];
            int answer;
            
            Console.Write("input a:");
            confi[0] = int.Parse(Console.ReadLine());
            Console.Write("input b:");
            confi[1] = int.Parse(Console.ReadLine());
            Console.Write("input c:");
            confi[2] = int.Parse(Console.ReadLine());

            answer = (confi[1]*confi[1]) - 4 * confi[0] * confi[2];
            

            if (answer < 0)
            {
                Console.Write("2つの虚数解");
            }
            else if (answer == 0)
            {
                Console.Write("重解");

            }
            else
            {
                Console.Write("2つの実数解");

            }


        }
    }
}
