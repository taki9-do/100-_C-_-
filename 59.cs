using System;

namespace _210512_59
{
    class Program
    {
        static void Main(string[] args)
        {
            //行列a３＊３定義
            int[][] mat_a = new int[3][];
            for(int i = 0; i < 3; i++)
            {
                mat_a[i] = new int[3];
            }

            //行列b３＊３定義
            int[][] mat_b = new int[3][];
            for(int i = 0; i < 3; i++)
            {
                mat_b[i] = new int[3];
            }

            Console.WriteLine("１つめの行例");
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    mat_a[j][i] = int.Parse(Console.ReadLine());

                }
            }


            Console.WriteLine("２つめの行例");
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    mat_b[j][i] = int.Parse(Console.ReadLine());
                }

            }

            Console.WriteLine("和");
            for (int j = 0; j< mat_b.Length; j++)
            {
                for (int i = 0; i < mat_b[0].Length; i++)
                {
                    if (i == mat_b[i].Length - 1)
                    {
                        Console.WriteLine(mat_a[j][i] + mat_b[j][i]);

                    }
                    else
                    {
                        Console.Write(mat_a[j][i] + mat_b[j][i]);
                        Console.Write(" ");

                    }
                }
            }


            Console.WriteLine();
        }
    }
}
