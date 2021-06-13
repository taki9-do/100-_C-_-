using System;

namespace _210609_82
{
    class Program
    {
        static void Main(string[] args)
        {
            //段数
            int step = int.Parse(Console.ReadLine());

            int[][] pascal = new int[step][];
            for(int i = 0; i < pascal.Length; i++)
            {
                pascal[i] = new int[i+1];
            }

            for (int i = 0; i < step; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    if (i == 0)
                    {
                        pascal[0][0] = 1;

                    }

                    if (i >= 1)
                    {
                        //上加算（要素番号末尾以外）
                        if (j < pascal[i - 1].Length)
                        {
                            pascal[i][j] += pascal[i - 1][j];

                        }
                        //左上加算（要素番号0以外）
                        if (j  >= 1)
                        {
                            pascal[i][j] += pascal[i - 1][j-1];
                        }
                    }
                    Console.Write(pascal[i][j]+" ");

                }
                Console.WriteLine();


            }

        }
    }
}
