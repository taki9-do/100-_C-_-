using System;

namespace _210511_52
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input year:");
            int year = int.Parse(Console.ReadLine());
            if (year % 4 == 0)
            {
                if (year % 400==0)
                {
                    Console.WriteLine(year + "年はうるう年である");

                }
                else if (year % 100 != 0)
                {
                    Console.WriteLine(year + "年はうるう年である");

                }
                else
                {
                    Console.WriteLine(year + "年はうるう年でない");

                }

            }
            else
            {
                Console.WriteLine(year + "年はうるう年でない");
            }

        }
    }
}
