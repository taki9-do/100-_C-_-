using System;

namespace _210711_97
{
    class Program
    {
        static void Main(string[] args)
        {
            //5*5のビンゴ配列宣言
            int[,] bingo = new int[5,5];

            //ビンゴ配列に値格納
            bingo = generate_bingo();

            //ビンゴ表示
            show_bingo(bingo);

        }

        static int[,] generate_bingo()
        {
            int[,] box = new int[5, 5];
            int[] array_1to75 = generate_array_1to75_mixed();

            



            for (int i = 0; i < box.GetLength(0); i++)
            {
                for(int j = 0;j< box.GetLength(0); j++)
                {
                    box[i, j] = array_1to75[i * box.GetLength(0) + j];
                }
                
            }

            return box;
        }

        static int[] generate_array_1to75_mixed()
        {
            int[] box = new int[75];

            for(int i = 0; i < box.Length; i++)
            {
                box[i] = i + 1;
            }

            for (int i = 0; i < box.Length; i++)
            {
                Random rnd = new Random();

                int temp = box[i];
                int index = rnd.Next(0, 75);

                box[i] = box[index];
                box[index] = temp;
            }

            return box;

        }

        static void show_bingo(int[,] box)
        {

            for (int i = 0; i < box.GetLength(0); i++)
            {
                for (int j = 0; j < box.GetLength(0); j++)
                {
                    Console.Write(box[i,j].ToString()+"\t");

                }
                Console.WriteLine();
            }

        }
    }
}
