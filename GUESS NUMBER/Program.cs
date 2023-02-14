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
            int[] numbers = Enumerable.Range(0, 10).OrderBy(x => Guid.NewGuid()).Take(4).ToArray();
            int numberOfGuesses = 0;
            int a, b;

            Console.WriteLine("歡迎來到 1A2B 猜數字的遊戲～");

            while (true)
            {
                Console.Write("請輸入 4 個數字：");
                int[] guess = Console.ReadLine().Select(c => c - '0').ToArray();
                numberOfGuesses++;

                a = 0;
                b = 0;
                for (int i = 0; i < 4; i++)
                {
                    if (guess[i] == numbers[i])
                    {
                        a++;
                    }
                    else if (numbers.Contains(guess[i]))
                    {
                        b++;
                    }
                }

                if (a == 4)
                {
                    Console.WriteLine("恭喜，您猜對了！");
                    Console.Write("您要繼續玩嗎？(y/n): ");
                    string answer = Console.ReadLine();
                    if (answer == "n")
                    {
                        Console.WriteLine("遊戲結束，下次再來玩喔～");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine($"判斷結果是{a}A{b}B");
                }

            }
            Console.ReadKey();

        }
    }
}
