namespace _13_1
{
    internal class Program
    {
        delegate void MyDelegate(string massage);

        static void Method1(string massage)
        {
            Console.WriteLine("Method1: " + massage);
        }

        static void Method2(string massage)
        {
            Console.WriteLine("Method2: " + massage);
        }

        static void Main(string[] args)
        {
            MyDelegate myDelegate = Method1;
            myDelegate += Method2;

            myDelegate("Hello!");
            
        }
    }
}
