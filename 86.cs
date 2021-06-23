using System;

namespace _210622_86
{
    class Program
    {
        static void Main(string[] args)
        {//石の入力
            Console.Write("石の数を入力してください（10以上）：");
            int stone = int.Parse(Console.ReadLine());
            int count ;
            int stone_plyer_pulled = 0;
            int temp = 0;

            //１回目のターン
            if (stone % 4 == 1)
            {
                count = 0;
                temp = stone;
                //プレイヤーのターン
                stone = pulled_stone_plyer(stone);
                stone_plyer_pulled = temp - stone;
            }
            else
            {
                count = 1;
                //CPUのターン
                stone = pulled_stone_cpu(stone,stone_plyer_pulled);
            }

            //2回目以降のターン
            while (stone > 1)
            {
                count++;

                if (count % 2 == 1)
                {
                    //CPUのターン
                    stone = pulled_stone_cpu(stone, stone_plyer_pulled);
                }
                else if (count % 2 == 0)
                {
                    temp = stone;
                    //プレイヤーのターン
                    stone = pulled_stone_plyer(stone);
                    stone_plyer_pulled = temp - stone;
                }
            }

            //勝敗判定
            judge_win_or_lose(stone,count);
        }

        #region 石をとる操作_CPU
        static int pulled_stone_cpu(int stone,int stone_plyer_pulled)
        {

            int number = algo_stone(stone, stone_plyer_pulled);

            Console.WriteLine(number+"個石をとります");
            stone -= number;
            Console.WriteLine("石の数：" + stone);
            return stone;
        }
        #endregion

        #region 石をとる数_CPU_アルゴリズム
        static int algo_stone(int stone, int stone_plyer_pulled)
        {
            int number = 0;

            if (stone_plyer_pulled == 0)
            {
                if (stone % 4 == 0)
                {
                    number = 3;

                }
                else if (stone % 4 == 2)
                {
                    number = 1;
                }
                else if (stone%4 == 3) 
                {
                    number = 2;
                }
            }
            else if (stone_plyer_pulled == 1)
            {
                number = 3;
            }
            else if (stone_plyer_pulled == 2)
            {
                number = 2;
            }
            else if (stone_plyer_pulled == 3)
            {
                number = 1;
            }

            return number;
        }
        #endregion

        #region 石をとる操作_プレイヤー
        static int pulled_stone_plyer(int stone)
        {
            Console.Write("何個石をとる（1～3個）？");
            int number = int.Parse(Console.ReadLine());
            if (number > 3)
            {
                Console.WriteLine("4個以上はダメ。もう一回選んで");
                return pulled_stone_plyer(stone);
            }
            stone -= number;
            Console.WriteLine("石の数：" + stone);
            return stone;
        }
        #endregion

        #region 勝敗判定
        static void judge_win_or_lose(int stone,int count)
        {
            if (stone == 1)
            {
                if (count % 2 == 1)
                {
                    Console.WriteLine("CPUの勝ち");
                }
                else if (count % 2 == 0)
                {
                    Console.WriteLine("プレイヤーの勝ち");
                }
            }
            else if (stone <= 0)
            {
                if (count % 2 == 1)
                {
                    Console.WriteLine("CPUの反則まけ");
                }
                else if (count % 2 == 0)
                {
                    Console.WriteLine("プレイヤーの反則まけ");
                }
            }
        }

        #endregion

    }
}
