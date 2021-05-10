using System;

namespace _210511_51
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input money:");
            int money = int.Parse(Console.ReadLine());
            int coin_100=0, coin_10=0, coin_1=0;

            if (money >= 100)
            {
                coin_100 = money / 100;
                money %=  100;
                coin_10 = money / 10;
                money %=  10;
                coin_1 = money / 1;

            }
            else if(money >= 10)
            {
                coin_10 = money / 10;
                money %=  10;
                coin_1 = money / 1;

            }
            else if (money >= 1)
            {
                coin_1 = money / 1;
            }
            Console.Write("100円玉" + coin_100 + "枚,");
            Console.Write("10円玉" + coin_10 + "枚,");
            Console.Write("1円玉" + coin_1 + "枚");

        }
    }
}
