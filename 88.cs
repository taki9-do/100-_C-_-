using System;

namespace _210625_88
{
    class Program
    {
        static void Main(string[] args)
        {
            //正解値
            Random rnd = new Random();
            int number_output = rnd.Next(1, 100);

            //入力値
            int number_input = 0;

            //カウンタ
            int count = 0;

            while (number_input != number_output)
            {
                //入力値
                Console.WriteLine("数を入力:");
                number_input = int.Parse(Console.ReadLine());

                if (number_input == number_output)
                {
                    Console.WriteLine("正解！");
                    break;

                }
                else if(number_input > number_output)
                {
                    Console.WriteLine("それより小さいよ！");

                }
                else if(number_input < number_output)
                {
                    Console.WriteLine("それより大きいよ！");

                }
                count++;
            }

            Console.WriteLine(count + "回でクリア");

        }
    }
}
