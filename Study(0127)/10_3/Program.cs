namespace _10_3
{
    internal class Program
    {
        public enum Month
        {
            Jan =1 ,
            Feb,
            MAr,
            Apr,
            May,
            Jun,
            Jul,
            Aug,
            Sep,
            Oct,
            Nov,
            Dec
        }

        public static void ProcessMonth(int month)
        {
            if (month >= (int)Month.Jan && month <= (int)Month.Dec)
            {
                Month selectMonth = (Month)month;
                Console.WriteLine("선택한 월은 {0}입니다.", selectMonth );
            }
            else
            {
                Console.WriteLine("올바른 월을 입력 해 주세요");
            }
        }


        static void Main(string[] args)
        {
            int userInput = 7;
            ProcessMonth(userInput);
        }
    }
}
