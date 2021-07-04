using System;

namespace _210704_93
{
    class Program
    {
        static void Main(string[] args)
        {

            int value_start = 0;
            int value_end = 0;

            Console.Write("START ;");
            value_start = int.Parse(Console.ReadLine());
            Console.Write("END ;");
            value_end = int.Parse(Console.ReadLine());

            //判定
            show(value_start, value_end);
        }

        static void show(int value_start,int value_end)
        {
            //フラグ変数
            bool flag = false;

            for (int i = value_start; i <= value_end; i++)
            {
                if (flag == false)
                {
                    flag = show_multiple_of_3(i);
                }

                if (flag == false)
                {
                    flag = show_inspect_3(i);

                }


                Console.WriteLine(i);
                flag = false;

            }
        }

        //3の倍数判定
        static bool show_multiple_of_3(int i)
        {
            bool flag = false;
            if (i % 3 == 0 && (i != 0))
            {
                Console.Write("aho ");
                flag = true;
            }
            return flag;
        }

        static bool show_inspect_3(int i)
        {
            bool flag = false;
            //最後の1桁まで加算
            while (i > 0)
            {
                if ((i % 10) == 3)
                {
                    Console.Write("aho ");
                    flag = true;
                    break;

                }
                i /= 10;
            }
            return flag;
        }

    }
}
