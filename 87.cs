using System;

namespace _210623_87
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("誕生日をYYYYMMDDの形式で入力してください:");
            int number = int.Parse(Console.ReadLine());

            //YYYYMMDDの合計
            int sum = sum_number(number);

            //１桁になるまでループ
            while (sum > 9)
            {
                //11、22...のゾロ目で脱出
                if ((sum / 10) == (sum % 10))
                {
                    break;
                }
                sum = sum_number(sum);
            }

            //運命数
            Console.WriteLine("運命数は" + sum);
        }

        static int sum_number(int number)
        {
            int sum=0;

            //最後の1桁まで加算
            while (number > 0)
            {
                sum += (number % 10);
                number /= 10;
            }

            return sum;
        }
    }
}
