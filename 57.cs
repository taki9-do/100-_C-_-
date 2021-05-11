using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace _210511_57
{
    class Program
    {
        static void Main(string[] args)
        {
            //読み込み
            List<string> temp = new List<string>();
            StreamReader sr_small = new StreamReader(@"examSmall.txt");
            while (!sr_small.EndOfStream)
            {
                temp.AddRange(sr_small.ReadLine().Split(" "));
                temp.Remove("");
            }
            var box_small = temp.ConvertAll(int.Parse);
            sr_small.Close();
            int number = box_small[0];//生徒の人数
            box_small.RemoveAt(0);//配列を点数データのみに


            //点数計算
            int  ave_english = 0, ave_math = 0, ave_japanese = 0;
            int[] each_sum = new int[number];

            for (int i = 0; i < box_small.Count; i++)
            {
                
                if (i % 3 == 0)
                {
                    ave_english += box_small[i];
                    each_sum[i/3] += box_small[i];
                }
                else if (i % 3 == 1)
                {
                    ave_math += box_small[i];
                    each_sum[i/3] += box_small[i];

                }
                else if (i % 3 == 2)
                {
                    ave_japanese += box_small[i];
                    each_sum[i/3] += box_small[i];
                }
            }
            Console.Write("平均点　英語："+ave_english/number+", ");
            Console.Write("数学：" + ave_math / number + ", ");
            Console.WriteLine("国語：" + ave_japanese / number );
            Console.WriteLine("個人平均点");
            for(int j = 0; j < number; j++)
            {
                Console.WriteLine(j+":"+each_sum[j]);
            }



        }
    }
}
