using System;

namespace _210613_83
{
    class Program
    {
        static void Main(string[] args)
        {
            int choise_you=0 ;
            int count_youwin=0;
            int choise_cpu=0 ;
            int count_cpuwin = 0;


            for(int i = 0; i < 5; i++)
            {
                bool flag_aiko = true;
                bool flag_out = false;


                //trueで繰り返す
                while (flag_aiko == true)
                {
                    flag_aiko = false;
                    //手の入力（自分）
                    Console.Write("あなたの手を選んでください（グー0、チョキ1、パー2）");
                    choise_you = int.Parse(Console.ReadLine());
                    if (choise_you != 0 && choise_you != 1 && choise_you != 2)
                    {
                        flag_out = true;
                        Console.WriteLine("そんな手はありません。あなたの負け");
                        break;
                    }

                    //手の入力(cpu)
                    Random rnd = new Random();
                    choise_cpu = rnd.Next(0, 3);
                    if (choise_cpu == 0)
                    {
                        Console.WriteLine("コンピュータはグー");
                    }
                    else if (choise_cpu == 1)
                    {
                        Console.WriteLine("コンピュータはチョキ");

                    }
                    else if (choise_cpu == 2)
                    {
                        Console.WriteLine("コンピュータはパー");

                    }

                    rnd = null;

                    if (choise_cpu == choise_you)
                    {
                        flag_aiko = true;
                        Console.WriteLine("あいこ！");

                    }

                }

                if (flag_out == true)
                {
                    count_cpuwin++;
                    flag_out = false;
                }
                else if ((choise_you - choise_cpu + 3) % 3 == 1)
                {
                    count_cpuwin++;
                    Console.WriteLine("わたしのかち");
                }
                else if((choise_you - choise_cpu + 3) % 3 == 2)
                {
                    count_youwin++;
                    Console.WriteLine("あなたのかち");
                }

                Console.WriteLine("あなた" + count_youwin + "勝、わたし"+count_cpuwin+"勝");


            }


        }
    }
}
