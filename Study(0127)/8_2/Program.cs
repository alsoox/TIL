namespace _8_2
{
    internal class Program
    {
        //    class Person
        //    {
        //        private string name;
        //        private int age;

        //        //디폴트 생성자
        //        public Person()
        //        {
        //            name = "UnKnown";
        //            age = 0;
        //            Console.WriteLine("Person1 객체생성");
        //        }

        //        public Person(string newName, int newAge)
        //        {
        //            name = newName;
        //            age = newAge;
        //            Console.WriteLine("Person2 객체생성");
        //        }

        //        public void PrintInfo()
        //        {
        //            Console.WriteLine($"Name: {name}, Age: {age}");
        //        }
        //    }

        //    static void Main(string[] args)
        //    {
        //        Person person1 = new Person();
        //        Person person2 = new Person("Jhon",25);
        //        person2.PrintInfo();
        //    }

        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "John";     // 값을 설정
            person.Age = 25;          // 값을 설정

            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");  // 값을 읽어 출력
        }
    }
}
