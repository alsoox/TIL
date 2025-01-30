namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] inventory = { "검", "방패", "활", "화살", "물약" };

            //foreach (string item in inventory)
            //{
            //    Console.WriteLine(item);
            //}

            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int j = 2; j <= 9; j++)
            //    {
            //        Console.Write(j + " x " + i + " = " + (i * j) + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        continue; // 3의 배수인 경우 다음 숫자로 넘어감
            //    }

            //    Console.WriteLine(i);
            //    if (i == 7)
            //    {
            //        break; // 7이 출력된 이후에는 반복문을 빠져나감
            //    }
            //}

            int sum = 0;

            while (true)
            {
                Console.Write("숫자를 입력하세요: ");
                int input = int.Parse(Console.ReadLine());

                if(input == 0)
                {
                    Console.Write("프로그램 종료 ");
                    break;
                }

                if (input < 0)
                {
                    Console.Write("프로그램 종료 ");
                    continue;
                }

                sum += input;
                Console.WriteLine(sum);

            }

            Console.WriteLine("합계: " + sum);
        }
    }
}
