using System;

namespace _210706_94
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //4桁数字入力
            int input_number;
            Console.Write("4桁の数字を入力：");
            input_number = int.Parse(Console.ReadLine());

            //正解値生成
            int target_number = make_target_number();
            Console.WriteLine(target_number);

            //hitのカウント
            int hit_count = count_hit(input_number,target_number);

            Console.Write(hit_count);


        }

        #region 正解値生成
        static int make_target_number()
        {
            int number = 0;

            for(int i = 0; i < 4; i++)
            {
                Random rnd = new Random();
                number = (number * 10) + rnd.Next(0, 10);
            }
            return number;

        }
        #endregion

        static int count_hit(int input,int target)
        {
            int count = 0;

            while (input > 0)
            {
                if ((input % 10) == (target % 10)) 
                {
                    count++;
                }
                input /= 10;
                target /= 10;
            }

            return count;
        }

    }
}
