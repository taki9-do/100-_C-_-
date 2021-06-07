using System;

namespace _210608_81
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] box = new int[3];
            Console.Write("入力1：");
            box[0] = int.Parse(Console.ReadLine());
            Console.Write("入力2：");
            box[1] = int.Parse(Console.ReadLine());
            Console.Write("入力3：");
            box[2] = int.Parse(Console.ReadLine());

            int temp = 0;

            for(int i = 0; i < box.Length-1; i++)
            {
                for(int j = 1; j < box.Length - i; j++)
                {
                    if (box[i] > box[i + j])
                    {
                        temp = box[i + j];
                        box[i + j] = box[i];
                        box[i] = temp;
                    }
                }
                
            }

            Console.WriteLine(box[box.Length/2]);
            
        }
    }
}
