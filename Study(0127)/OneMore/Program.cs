using System;
using System.Xml.Serialization;

namespace OneMore
{
    internal class Program
    {
        static char[] arr = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', };
        static int player = 1;
        static int flag = 0;
        static int choice;
        static bool numberCheck = true;

        static void Main(string[] args)
        {

            do
            {
                Console.Clear();
                Console.WriteLine("플레이어 1: X 와 플레이어 2: O\n");

                if (player % 2 == 1)
                {
                    Console.WriteLine("플레이어 1의 차례\n");
                }
                else
                {
                    Console.WriteLine("플레이어 2의 차례\n");
                }

                Board();

                if (numberCheck = int.TryParse(Console.ReadLine(), out choice))
                {
                    if (arr[choice] != 'X' && arr[choice] != 'O') // 선택한게 숫자일때
                    {
                        if (player % 2 == 1)
                        {
                            arr[choice] = 'X';
                        }
                        else
                        {
                            arr[choice] = 'O';
                        }
                        player++;
                    }
                    else // 선택한게 숫자가 아니라면
                    {
                        Console.WriteLine("이미 해당 자리는 선택된 자리입니다.");
                        Console.ReadLine();
                    }
                }

                else
                {
                    Console.WriteLine("숫자를 적어 주세요.");
                    Console.ReadLine();
                }
                flag = CheckWin();
            }
            while (flag == 0);

            if (flag == 1)
            {
                if (player % 2 == 1)
                {
                    Console.WriteLine("플레이어 2승리");
                }
                else
                {
                    Console.WriteLine("플레이어 1승리");
                }
            }
            else if (flag == -1)
            {
                Console.WriteLine("무승부입니다.");
            }
        }

        static void Board()
        {
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", arr[1], arr[2], arr[3]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", arr[4], arr[5], arr[6]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", arr[7], arr[8], arr[9]);
            Console.WriteLine("     |     |     ");
        }

        static int CheckWin()
        {
            //가로승
            if ((arr[1] == arr[2] && arr[2] == arr[3]) || (arr[4] == arr[5] && arr[5] == arr[6]) || (arr[7] == arr[8] && arr[8] == arr[9]))
            {
                return 1;
            }
            //세로승
            else if ((arr[1] == arr[4] && arr[4] == arr[7]) || (arr[2] == arr[5] && arr[5] == arr[8]) || (arr[3] == arr[6] && arr[6] == arr[9]))
            {
                return 1;
            }
            //대각선승
            else if ((arr[1] == arr[5] && arr[5] == arr[9]) || (arr[3] == arr[5] && arr[5] == arr[7]))
            {
                return 1;
            }
            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
            {
                return -1;
            }
            else return 0;
        }
    }
}
