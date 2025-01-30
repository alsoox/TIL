namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////1) 홀 / 짝 구분하기
            //Console.Write("번호를 입력하세요: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("짝수입니다.");
            //}
            //else
            //{
            //    Console.WriteLine("홀수입니다.");
            //}

            ////2) 등급 출력
            //int playerScore = 100;
            //string playerRank = "";

            //switch (playerScore / 10)
            //{
            //    case 10:
            //    case 9:
            //        playerRank = "Diamond";
            //        break;
            //    case 8:
            //        playerRank = "Platinum";
            //        break;
            //    case 7:
            //        playerRank = "Gold";
            //        break;
            //    case 6:
            //        playerRank = "Silver";
            //        break;
            //    default:
            //        playerRank = "Bronze";
            //        break;
            //}

            ////3) 로그인 프로그램
            //string id = "id";
            //string password = "pw";

            //Console.Write("아이디를 입력하세요: ");
            //string inputId = Console.ReadLine();
            //Console.Write("비밀번호를 입력하세요: ");
            //string inputPassword = Console.ReadLine();

            //if (id == inputId && password == inputPassword)
            //{
            //    Console.WriteLine("로그인 했습니다.");
            //}
            //else
            //{
            //    Console.WriteLine("로그인 실패.");
            //}

            //4) 알파펫 판별 프로그램
            Console.Write("문자를 입력하세요: ");
            char input = Console.ReadLine()[0];

            if ( (input >= 'a' && input <= 'z') || (input >= 'A' && input <= 'Z') )
            {
                Console.Write("알파펫입니다 ");
            }
            else
            {
                Console.Write("알파펫이 아닙니다. ");
            }
        }
    }
}
