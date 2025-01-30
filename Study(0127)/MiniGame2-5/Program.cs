﻿namespace MiniGame2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int targetNumber = rand.Next(1, 101);
            int attemps = 0;
            int guess = 0;  

            Console.WriteLine("숫자 맞추기 게임을 시작합니다. 1에서 100까지의 숫자 중 하나를 맞춰보세요.");


            while (guess != targetNumber)
            {
                Console.Write("숫자를 입력하세요: ");
                guess = int.Parse(Console.ReadLine());

                if (guess > targetNumber)
                {
                    Console.WriteLine("너무 큽니다!");
                }

                if (guess < targetNumber)
                {
                    Console.WriteLine("너무 작습니다!");       
                }
                attemps++;
            }

            Console.WriteLine($"축하합니다! {attemps}번 만에 숫자를 맞추었습니다.");

        }
    }
}
