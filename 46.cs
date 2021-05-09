using System;

namespace _210509_46
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("人数：");
            int people = int.Parse(Console.ReadLine());
            int money = 600;

            if (people >= 20)
            {
                money = 500;
            }
            else if (people<20 && people >= 5)
            {
                money = 550;
            }


            Console.WriteLine("料金："+money*people);
        }
    }
}
