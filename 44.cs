using System;

namespace _210505_44
{
    class Program
    {
        static void Main(string[] args)
        {
            int money;
            Console.Write("何円?:");
            money = int.Parse(Console.ReadLine());
            int rate_Dollar;
            Console.Write("１ドルは何円?:");
            rate_Dollar = int.Parse(Console.ReadLine());

            int dollar = money / rate_Dollar;
            int St = (money % rate_Dollar) * 100 / rate_Dollar;

            Console.Write(money+"円は"+dollar+"ドル"+St+"セント");
        }
    }
}
