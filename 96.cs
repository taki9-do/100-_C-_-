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
                var target_number_temp = (int[])target_number.Clone();
                var input_number_temp = (int[])input_number.Clone();



                //hitのカウント
                target_number_temp = count_hit(input_number_temp, target_number_temp);
                hit_count = retrun_count_hit(target_number_temp);
                Console.Write(hit_count + " ヒット ");

                //blowのカウント
                target_number_temp = count_blow(input_number_temp, target_number_temp);
                blow_count = retrun_count_blow(target_number_temp);
                
                
                Console.WriteLine(blow_count + " ヒット");


                if (hit_count == 4)
                {
                    break;
                }

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
                //Console.Write(number[i]);

            }
            //Console.WriteLine();

            return number;

        }
        #endregion

        #region ヒットカウント
        static int[] count_hit(int[] input, int[] target)
        {
            var a = (int[])target;

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

        #region ブローカウント
        static int[] count_blow(int[] input, int[] target)
        {
            var a = (int[])input.Clone();
            var b = (int[])target.Clone();


            for (int i = 0; i < target.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if ((target[i] > -1) && (input[j] > -1))
                    {
                        if (target[i] == input[j])
                        {
                            //a[j] = -1;
                            //b[i] = -1;

                            a[j] = -2;
                            b[i] = -2;


                        }
                    }

                }

            }
            //return a;
            return b;

        }
        #endregion

        #region フラグ配列カウント（-1はヒットカウント）
        static int retrun_count_hit(int[] box)
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

        #region フラグ配列カウント（-２はブローカウント）
        static int retrun_count_blow(int[] box)
        {
            int count = 0;

            for (int i = 0; i < box.Length; i++)
            {
                if (box[i] == -2)
                {
                    count++;
                }
            }

            return count;

        }
        #endregion

    }
}
