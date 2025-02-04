namespace Test3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 상하 벽 그리기
            for (int i = 0; i < 80; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("#");
                Console.SetCursorPosition(i, 20);
                Console.Write("#");
            }

            // 좌우 벽 그리기
            for (int i = 0; i < 20; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("#");
                Console.SetCursorPosition(80, i);
                Console.Write("#");
            }
        }
    }
}
