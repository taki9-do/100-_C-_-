using System;

namespace _210620_85
{
    class Program
    {
        static void Main(string[] args)
        {
            //石の入力
            Console.Write("石の数を入力してください（10以上）：");
            int stone = int.Parse(Console.ReadLine());

            //奇数；１のターン、偶数；２のターン
            int count=0;

            while (stone > 1)
            {
                count++;
                if (count % 2 == 1)
                {
                    Console.WriteLine("プレイヤー１の番です");
                }
                else if (count % 2 == 0)
                {
                    Console.WriteLine("プレイヤー２の番です");
                }
                stone = pulled_stone(stone);
            }

            if (stone == 1)
            {
                if (count % 2 == 1)
                {
                    Console.WriteLine("プレイヤー１の勝ち");
                }
                else if (count % 2 == 0)
                {
                    Console.WriteLine("プレイヤー２の勝ち");
                }
            }
            else if (stone <= 0)
            {
                if (count % 2 == 1)
                {
                    Console.WriteLine("プレイヤー１の反則まけ");
                }
                else if (count % 2 == 0)
                {
                    Console.WriteLine("プレイヤー２の反則まけ");
                }
            }

        }

        #region 石をとる操作
        static int pulled_stone(int stone)
        {
            Console.Write("何個石をとる（1～3個）？");
            int number = int.Parse(Console.ReadLine());
            if (number > 3)
            {
                Console.WriteLine("4個以上はダメ。もう一回選んで");
                return pulled_stone(stone);
            }
            stone -= number;
            Console.WriteLine("石の数：" + stone);
            return stone;
        }
        #endregion


    }
}
