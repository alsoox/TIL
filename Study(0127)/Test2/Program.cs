using System.ComponentModel.DataAnnotations;

namespace Test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// 2-1 구구단 출력하기
            //for (int i =1; i < 10; i++)
            //{
            //    for(int j = 2; j < 10; j++)
            //    {
            //        Console.Write($"{j} X {i} = {i*j}\t");
            //    }
            //    Console.WriteLine();
            //}

            // 2-2 별찍기 "*"

            //string star = "*";
            //string pyramid = "";

            //for (int i = 0; i < 5; i++)
            //{
            //    pyramid = pyramid + star;
            //    Console.WriteLine(pyramid);
            //}
            //풀이
            //for (int i = 0; i < 5; i++)
            //{
            //    for(int j = 0; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine(); 

            //for (int i = 4; i >= 0; i--)
            //{
            //    for (int j = 0; j <= i ; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();



            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 5 - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= (2 * i) - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            //// 2-3 최대값,최소값 찾기
            //int[] number = new int[5] ;
            //for (int i = 0; i < number.Length; i++)
            //{
            //    Console.Write("숫자를 입력하세요: ");
            //    number[i] = int.Parse(Console.ReadLine()) ;
            //}
            //int max = number[0];
            //int min = number[0];

            //for (int i = 1; i < number.Length; i++)
            //{
            //    if (max < number[i])
            //    {
            //        max = number[i];
            //    }
            //    if (min > number[i])
            //    {
            //        min = number[i];
            //    }
            //}

            //Console.WriteLine($"최대값 : {max}");
            //Console.WriteLine($"최소값 : {min}");

            //2-4 소수판별하기
            //Console.Write("숫자를 입력하세요: ");
            //int num = int.Parse(Console.ReadLine()); 

            //if (IsPrime(num))
            //{
            //    Console.WriteLine(num + "은 소수입니다.");
            //}
            //else // 소수가 아니라면
            //{
            //    Console.WriteLine(num + "은 소수가 아닙니다.");
            //}

        }

        //static bool IsPrime(int num)
        //{
        //    if (num <= 1)
        //    {
        //        return false;
        //    }

        //    for (int i = 2; i < num; i++)
        //    {
        //        if (num % i == 0)
        //        {
        //            return false;
        //        }

        //        else
        //        {
        //            continue;
        //        }
        //    }
        //    return true;
        //}
    }
}
