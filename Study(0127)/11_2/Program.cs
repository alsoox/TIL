﻿namespace _11_2
{
    internal class Program
    {
        public interface IUsable
        {
            void Use();
        }

        public class Item : IUsable
        {
            public string Name { get; set; }

            public void Use()
            {
                Console.WriteLine("아이템 {0}을 사용 했습니다.", Name);
            }
        }

        public class Player
        {
            public void UseItem(IUsable item)
            {
                item.Use();
            }
        }

        static void Main(string[] args)
        {
            
            Player player = new Player();
            Item item = new Item() { Name = "Health Positon" }; // Name 초기화
            player.UseItem(item);
        }
    }
}
