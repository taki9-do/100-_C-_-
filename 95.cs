using System;

namespace _210708_95
{
    class Program
    {
        static void Main(string[] args)
        {
            //4桁数字入力
            int number;
            Console.Write("4桁の数字を入力：");
            number = int.Parse(Console.ReadLine());
            int[] input_number = convert_input_number(number);

            //正解値生成
            int[] target_number = make_target_number();

            //hitのカウント
            int hit_count = count_hit(input_number, target_number);


        }



        #region 入力値を配列に格納
        static int[] convert_input_number(int input_number)
        {
            int[] number = new int[4];

            for (int i = number.Length - 1; i >= 0; i--)
            {
                number[i] = input_number % 10;
                input_number /= 10;
            }

            return number;

        }
        #endregion

        #region 正解値生成
        static int[] make_target_number()
        {
            //４桁の整数
            int[] number = new int[4];

            for (int i = 0; i < number.Length; i++)
            {
                Random rnd = new Random();
                number[i] = rnd.Next(0, 10);
                Console.Write(number[i]);

            }
            Console.WriteLine();

            return number;

        }
        #endregion

        #region ヒットカウント&ブローカウント
        static int count_hit(int[] input, int[] target)
        {
            int hit_count = 0;
            int blow_count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]  == target[i] )
                {
                    hit_count++;
                    target = retrun_flaged_box(target, i);
                    input = retrun_flaged_box(input, i);
                }
            }

            Console.Write(hit_count+" ヒット");


            blow_count = count_blow(input, target);

            Console.WriteLine(blow_count + " ブロー");

            return hit_count;
        }
        #endregion

        #region ブローカウント部分
        static int count_blow(int[] input,int[] target)
        {
            int count = 0;

            for (int i = 0; i < target.Length; i++)
            {
                for(int j = 0; j < input.Length; j++)
                {
                    if ( (target[i] > -1)&&(input[j] > -1))
                    {
                        if (target[i] == input[j])
                        {
                            count++;
                            input = retrun_flaged_box(input, j);
                            target = retrun_flaged_box(target, i);

                        }
                    }
                    
                }
                
            }
            return count;
        }
        #endregion

        #region フラグ配列生成（指定インデックスの値を-1に変換）
        static int[] retrun_flaged_box(int[] box,int index)
        {
            box[index] = -1;

            return box;

        }
        #endregion
    }
}
