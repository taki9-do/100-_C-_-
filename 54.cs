using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace _210511_54
{
    class Program
    {
        static void Main(string[] args)
        {
            //small
            List<int> box_small = new List<int>();
            StreamReader sr_small = new StreamReader(@"small.txt");
            while (!sr_small.EndOfStream)
            {
                box_small.Add(int.Parse(sr_small.ReadLine()));
            }
            sr_small.Close();
            Console.Write("small > 最小値：" + box_small.Min());
            Console.WriteLine("最大値：" + box_small.Max());

            //midlle
            List<int> box_midlle = new List<int>();
            StreamReader sr_midlle = new StreamReader(@"middle.txt");
            while (!sr_midlle.EndOfStream)
            {
                box_midlle.Add(int.Parse(sr_midlle.ReadLine()));
            }
            sr_midlle.Close();
            Console.Write("midlle > 最小値：" + box_midlle.Min());
            Console.WriteLine("最大値：" + box_midlle.Max());

            //large
            List<int> box_large = new List<int>();
            StreamReader sr_large = new StreamReader(@"large.txt");
            while (!sr_large.EndOfStream)
            {
                box_large.Add(int.Parse(sr_large.ReadLine()));
            }
            sr_large.Close();
            Console.Write("large > 最小値：" + box_large.Min());
            Console.WriteLine("最大値：" + box_large.Max());


        }
    }
}
