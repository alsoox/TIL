namespace MiniGame2_6
{
    internal class Program
    {
        static int[] location = {1,2,3,4,5,6,7,8,9,10};
        static bool gameWin = false;
        static int player = 1;

        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("플레이어 1: X 와 플레이어 2: O");
                Console.WriteLine();
                if (player % 2 == 0)
                {
                    Console.WriteLine("플레이어 2의 차례");
                }
                else
                {
                    Console.WriteLine("플레이어 1의 차례");
                }
                Console.WriteLine();

                Board();

                string input = Console.ReadLine();
                int choice = int.Parse(input);


                if (location[choice-1] != 'X' && location[choice - 1] != 'O')
                {
                    if (player % 2 == 0)
                    {
                        location[choice - 1] = 0;
                    }
                    else
                    {
                        location[choice - 1] = 0;
                    }
                }

                gameWin = GameWin();
            }
            while (gameWin);

            

        }

        static bool GameWin()
        {

            return true;
        }

        public static void Board()
        {

            string[,] board = new string[9,17];

            for (int i = 1; i <= 9; i++) // 세로
            {
                for (int j = 1; j <= 17; j++) // 가로
                {     
                    if (j % 6 == 0 && j != 0)//세로선 경계
                    {
                        Console.Write("|");
                    }
                    else if (j % 6 != 0 && i % 3 ==0 && i !=9)//가로선 경계
                    {
                        Console.Write("_");
                    }
                    else if ((j-3) % 6 == 0 && (i - 2) % 3 == 0) // 숫자
                    {
                        
                        if (i == 2)
                        {
                            if (j == 3)
                            {
                                Console.Write($"{location[0]}");
                            }
                            if (j == 9)
                            {
                                Console.Write($"{location[1]}");
                            }
                            if (j == 15)
                            {
                                Console.Write($"{location[2]}");
                            }
                        }
                        if (i == 5)
                        {
                            if (j == 3)
                            {
                                Console.Write($"{location[3]}");
                            }
                            if (j == 9)
                            {
                                Console.Write($"{location[4]}");
                            }
                            if (j == 15)
                            {
                                Console.Write($"{location[5]}");
                            }
                        }
                        if (i == 8)
                        {
                            if (j == 3)
                            {
                                Console.Write($"{location[6]}");
                            }
                            if (j == 9)
                            {
                                Console.Write($"{location[7]}");
                            }
                            if (j == 15)
                            {
                                Console.Write($"{location[8]}");
                            }
                        }
                    }
                    else//빈칸
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
