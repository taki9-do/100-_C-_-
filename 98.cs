using System;

namespace _210711_98
{
    class Program
    {
        static void Main(string[] args)
        {
            //5*5のビンゴ配列宣言
            int[,] bingo = new int[5, 5];

            //抽選数字の配列宣言
            int[] array_lottery = new int[75];
            array_lottery = generate_array_1to75_mixed();
;
            //ビンゴ配列に値格納
            bingo = generate_bingo();

            //回数カウント
            int count = 0;

            //ビンゴ判定、trueでゲーム終了
            bool flag_bingo = false;


            //抽選前ビンゴの表示
            show_bingo(bingo);

            //繰り返し抽選、フラグがtrueでビンゴ
            for (int k = 0; k < array_lottery.Length; k++)
            {
                count++;
                Console.Write(count + "個目：");
                Console.WriteLine(array_lottery[k]);

                bingo = judge_number(bingo, array_lottery, k);

                show_bingo(bingo);

                flag_bingo = judge_bingo(bingo);

                if (flag_bingo == true)
                {
                    Console.WriteLine("***** BINGO *****");

                    break;
                }

            }

        }

        #region ビンゴ配列の生成
        static int[,] generate_bingo()
        {
            int[,] box = new int[5, 5];
            int[] array_1to75 = generate_array_1to75_mixed();


            for (int i = 0; i < box.GetLength(0); i++)
            {
                for (int j = 0; j < box.GetLength(0); j++)
                {
                    box[i, j] = array_1to75[i * box.GetLength(0) + j];
                }

            }

            return box;
        }
        #endregion

        #region 1~75の数字をランダムに格納
        static int[] generate_array_1to75_mixed()
        {
            int[] box = new int[75];

            for (int i = 0; i < box.Length; i++)
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
        #endregion

        #region ビンゴ表示
        static void show_bingo(int[,] box)
        {

            for (int i = 0; i < box.GetLength(0); i++)
            {
                for (int j = 0; j < box.GetLength(0); j++)
                {
                    Console.Write(box[i, j].ToString() + "\t");

                }
                Console.WriteLine();
            }

        }
        #endregion

        #region ナンバー判定
        static int[,] judge_number(int[,] array_bingo,int[] array_lottery,int index)
        {
            for (int i = 0; i < array_bingo.GetLength(0); i++)
            {

                for (int j = 0; j < array_bingo.GetLength(0); j++)
                {
                    if (array_bingo[i, j] == array_lottery[index])
                    {
                        array_bingo[i, j] = 0;
                        Console.WriteLine("あった！");
                    }
                }
            }

            return array_bingo;
        }
        #endregion


        #region ビンゴ判定（横、縦、ななめ（\,/）判定）
        static bool judge_bingo(int[,] array_bingo)
        {
            bool flag = false;

            //横のビンゴ判定
            for (int i = 0; i < array_bingo.GetLength(0); i++)
            {
                int count_side = 0;

                for (int j = 0; j < array_bingo.GetLength(0); j++)
                {
                    if (array_bingo[i, j] == 0)
                    {
                        count_side++;
                    }
                    if (count_side == 5)
                    {
                        flag = true;
                        return flag;
                    }

                }

            }

            //縦のビンゴ判定
            for (int i = 0; i < array_bingo.GetLength(0); i++)
            {
                int count_vertical = 0;

                for (int j = 0; j < array_bingo.GetLength(0); j++)
                {
                    if (array_bingo[j, i] == 0)
                    {
                        count_vertical++;
                    }
                    if (count_vertical == 5)
                    {
                        flag = true;
                        return flag;
                    }

                }

            }

            // "\"ななめのビンゴ判定
            for (int i = 0; i < array_bingo.GetLength(0); i++)
            {
                int count_slante = 0;

                if (array_bingo[i, i] == 0)
                {
                    count_slante++;
                }
                if (count_slante == 5)
                {
                    flag = true;
                    return flag;
                }
            }

            // "/"ななめのビンゴ判定
            for (int i = 0; i < array_bingo.GetLength(0); i++)
            {
                int count_slante = 0;

                if (array_bingo[i, (4-i)] == 0)
                {
                    count_slante++;
                }
                if (count_slante == 5)
                {
                    flag = true;
                    return flag;
                }
            }


            return flag;
        }
        #endregion
    }
}
