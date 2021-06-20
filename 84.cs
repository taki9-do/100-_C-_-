using System;

namespace _210620_84
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //トランプ生成
            string[] trump = generate_trump();

            //トランプシャッフル
            trump = shuffle_trump(trump);

            //トランプ表示
            for(int i = 0; i < trump.Length; i++)
            {
                Console.WriteLine(trump[i]);
            }
        }

        #region トランプ生成
        static string[] generate_trump()
        {
            string[] trump = new string[52];
            for(int i = 0; i < trump.Length; i++)
            {
                int index = i - (i / 13) * 13;
                if (i / 13 == 0)
                {
                    
                    if (index == 0)
                    {
                        trump[i] = "スペード" + "A";
                    }
                    else if (index == 10)
                    {
                        trump[i] = "スペード" + "J";
                    }
                    else if (index == 11)
                    {
                        trump[i] = "スペード" + "Q";
                    }
                    else if (index == 12)
                    {
                        trump[i] = "スペード" + "K";
                    }
                    else
                    {
                        trump[i] = "スペード" + (index+1);
                    }

                }
                else if (i / 13 == 1)
                {
                    if (index == 0)
                    {
                        trump[i] = "ハート" + "A";
                    }
                    else if (index == 10)
                    {
                        trump[i] = "ハート" + "J";
                    }
                    else if (index == 11)
                    {
                        trump[i] = "ハート" + "Q";
                    }
                    else if (index == 12)
                    {
                        trump[i] = "ハート" + "K";
                    }
                    else
                    {
                        trump[i] = "ハート" + (index + 1);
                    }
                }
                else if (i / 13 == 2)
                {
                    if (index == 0)
                    {
                        trump[i] = "ダイヤ" + "A";
                    }
                    else if (index == 10)
                    {
                        trump[i] = "ダイヤ" + "J";
                    }
                    else if (index == 11)
                    {
                        trump[i] = "ダイヤ" + "Q";
                    }
                    else if (index == 12)
                    {
                        trump[i] = "ダイヤ" + "K";
                    }
                    else
                    {
                        trump[i] = "ダイヤ" + (index + 1);
                    }
                }
                else if (i / 13 == 3)
                {
                    if (index == 0)
                    {
                        trump[i] = "クラブ" + "A";
                    }
                    else if (index == 10)
                    {
                        trump[i] = "クラブ" + "J";
                    }
                    else if (index == 11)
                    {
                        trump[i] = "クラブ" + "Q";
                    }
                    else if (index == 12)
                    {
                        trump[i] = "クラブ" + "K";
                    }
                    else
                    {
                        trump[i] = "クラブ" + (index + 1);
                    }
                }
            }
            return trump;
        }
        #endregion

        #region トランプシャッフル
        static string[] shuffle_trump(string[] trump)
        {
            for (int i = 0; i< trump.Length; i++)
            {
                Random rnd = new Random();

                string temp = trump[i];
                int index = rnd.Next(0, 52);

                trump[i] = trump[index];
                trump[index] = temp;

                
            }
            return trump;
        }
        #endregion

    }
}
