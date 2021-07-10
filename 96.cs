using System;

namespace _210729_96
{
    class Program
    {
        static void Main(string[] args)
        {
            //正解値生成
            int[] target_number = make_target_number();

            //入力値
            int[] input_number ;

            //ループ回数
            int count_loop = 0;

            //ヒットカウント
            int hit_count = 0;

            //ブローカウント
            int blow_count = 0;

            while (1 >= 0)
            {
                count_loop++;
                Console.WriteLine(count_loop+"回目");

                //4桁数字入力
                Console.Write("4桁の数字を入力：");
                int number = int.Parse(Console.ReadLine());
                input_number = convert_input_number(number);

                //退避
                int[] target_number_temp = target_number;
                int[] input_number_temp = input_number;

                Console.WriteLine(target_number[0].ToString() + target_number[1].ToString() + target_number[2].ToString() + target_number[3].ToString());
                Console.WriteLine(target_number_temp[0].ToString() + target_number_temp[1].ToString() + target_number_temp[2].ToString() + target_number_temp[3].ToString());



                


                //hit,blowのカウント
                target_number_temp = count_hit(input_number_temp, target_number_temp);
                hit_count = retrun_count(target_number_temp);
                Console.Write(hit_count + " ヒット ");


                target_number_temp = count_blow(input_number_temp, target_number_temp);
                blow_count = retrun_count(target_number_temp);
                blow_count -= hit_count;
                Console.WriteLine(blow_count + " ヒット");


               


                if (hit_count == 4)
                {
                    break;
                }

                //target_number_temp = null;
                //input_number_temp = null;
            }




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
        static int[] count_hit(int[] input, int[] target)
        {
            int[] a = target;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == target[i])
                {
                    a[i] = -1;
                    
                }
            }

           

            return a;
        }
        #endregion

        #region ブローカウント部分
        static int[] count_blow(int[] input, int[] target)
        {
            int[] a = input;
            int[] b = target;


            for (int i = 0; i < target.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if ((target[i] > -1) && (input[j] > -1))
                    {
                        if (target[i] == input[j])
                        {
                            a[j] = -1;
                            b[i] = -1;
                            

                        }
                    }

                }

            }
            return a;
        }
        #endregion

        #region フラグ配列生成（指定インデックスの値を-1に変換）
        static int retrun_count(int[] box)
        {
            int count = 0;

            for(int i = 0; i < box.Length; i++)
            {
                if (box[i] == -1)
                {
                    count++;
                }
            }

            return count;

        }
        #endregion

    }
}
