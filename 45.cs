using System;

namespace _210509_45
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("距離：");
            int distance = int.Parse(Console.ReadLine());
            int money=610;

            

            if (distance>=0 && distance <= 1700)
            {
                Console.WriteLine("金額："+money);


            }
            else
            {
                distance -= 1700;

                while (distance > 0)
                {
                    money += 80;
                    distance -= 313;
                }
                Console.WriteLine("金額：" + money);

            }

        }
    }
}
