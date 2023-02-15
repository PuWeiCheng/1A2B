using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUESS_NUMBER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("歡迎來到 1A2B 猜數字的遊戲～");


            Random random = new Random();
            int[] answer = new int[4];
            for (int i = 0; i < 4; i++)
            {
                int num = random.Next(0, 10);
                if (Array.IndexOf(answer, num) == -1)
                {
                    answer[i] = num;
                }
                else
                {
                    i--;
                }
                
            }
          foreach(int ans in answer)
                {
                    Console.WriteLine(ans);
                }

            while (true)
            {
                Console.Write("請輸入 4 個數字：");
                string input = Console.ReadLine();

                int A = 0;
                int B = 0;
                for (int i = 0; i < 4; i++)
                {
                    int num = input[i] - '0';
                    if (Array.IndexOf(answer, num) != -1)
                    {
                        if (answer[i] == num)
                        {
                            A++;
                        }
                        else
                        {
                            B++;
                        }
                    }
                }

                Console.WriteLine("判定結果是 " + A + "A" + B + "B");
                Console.WriteLine("------");
                if (A == 4)
                {
                    Console.WriteLine("恭喜你！猜對了！！");
                    break;
                }

            }

            Console.Write("你要繼續玩嗎？(y/n): ");
            string playAgain = Console.ReadLine();
            if (playAgain.ToLower() == "n")
            {
                Console.WriteLine("遊戲結束，下次再來玩喔～");
            }
            else
            {
                Main(null);
            }
        }
    }
}
