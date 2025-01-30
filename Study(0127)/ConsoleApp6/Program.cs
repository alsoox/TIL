using System;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// 1) 가위바위보
            //string[] choices = {"가위", "바위", "보"};
            //string playerChoice = "";
            //string computerChoice = choices[new Random().Next(0,3)];

            //while (playerChoice != computerChoice)
            //{
            //    Console.WriteLine("가위,바위,보 중 하나를 선택하세요: ");
            //    playerChoice = Console.ReadLine();

            //    if (playerChoice == computerChoice)
            //    {
            //        Console.WriteLine("비겼습니다");
            //    }
            //    else if((playerChoice == "가위" && computerChoice == "보") ||
            //            (playerChoice == "바위" && computerChoice == "가위") ||
            //            (playerChoice == "보" && computerChoice == "바위"))
            //    {
            //        Console.WriteLine("플레이어 승리!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("컴퓨터 승리!");
            //    }

            int targetNumber = new Random().Next(1,101);
            int guess = 0;
            int count = 0;
            Console.WriteLine("1부터 100 사이의 숫자를 맞춰보세요.");

            while (guess != targetNumber) 
            {
                guess = int.Parse(Console.ReadLine());
                if (guess > targetNumber)
                {
                    Console.WriteLine("더 작은숫자입니다.");
                }
                else
                {
                    Console.WriteLine("더 큰숫자입니다.");
                }
                count++;
            }
            Console.WriteLine($"정답입니다. {count} 만에 맞췄어요");
        }
    }
}
