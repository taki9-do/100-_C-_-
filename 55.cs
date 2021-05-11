using System;

namespace _210511_55
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for(int i = 0; i < 3; i++)
            {
                while (count != 9)
                {
                    Console.Write("とんで");
                    count++;
                }
                count = 0;

                while (count != 3)
                {
                    Console.Write("まわって");
                    count++;
                }
                count = 0;
                Console.WriteLine("まわる");

            }
        }
    }
}
