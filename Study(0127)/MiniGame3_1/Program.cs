﻿using System;
using System.Reflection;
using System.Xml.Linq;

namespace MiniGame3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 뱀의 초기 위치와 방향을 설정하고, 그립니다.
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            // 음식의 위치를 무작위로 생성하고, 그립니다.
            //FoodCreator foodCreator = new FoodCreator(80, 20, '$');
            //Point food = foodCreator.CreateFood();
            //food.Draw();

            // 게임 루프: 이 루프는 게임이 끝날 때까지 계속 실행됩니다.
            while (true)
            {
                // 키 입력이 있는 경우에만 방향을 변경합니다.

                // 뱀이 이동하고, 음식을 먹었는지, 벽이나 자신의 몸에 부딪혔는지 등을 확인하고 처리하는 로직을 작성하세요.
                // 이동, 음식 먹기, 충돌 처리 등의 로직을 완성하세요.
                snake.Move();
                Thread.Sleep(100); // 게임 속도 조절 (이 값을 변경하면 게임의 속도가 바뀝니다)

                // 뱀의 상태를 출력합니다 (예: 현재 길이, 먹은 음식의 수 등)
            }
        }
    }

    public class Point
    {
        public int x { get; set; }
        public int y { get; set; }
        public char sym { get; set; }

        // Point 클래스 생성자
        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        // 점을 그리는 메서드
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        // 점을 지우는 메서드
        public void Clear()
        {
            sym = ' ';
            Draw();
        }

        // 두 점이 같은지 비교하는 메서드
        public bool IsHit(Point p)
        {
            return p.x == x && p.y == y;
        }
    }
    // 방향을 표현하는 열거형입니다.
    public enum Direction
    {
        LEFT,
        RIGHT,
        UP,
        DOWN
    }
    
    public class Snake()
    {
        //뱀을 그려주기
         // 

        //뱀을 움직이기
         //dir 방향에 따라 생성 및 제거 

        //뱀이 먹이를 먹었을때
          //
    }

    public class FoodCreator()
    {
        //맵 크기(80/20 내에 랜덤하게 생성)
           //뱀이 있는자리에는 생성x

    }


    //public class Snake
    //{
    //    Point head;
    //    int length;
    //    Direction dir;
    //    Queue<Point> points = new Queue<Point>();

    //    public  Snake(Point _p, int _length, Direction _dir)
    //    {
    //        head = _p;
    //        length = _length;
    //        dir = _dir;

    //        for (int i = 0; i < length; i++)
    //        {
    //            Point p = new Point(_p.x, _p.y, '*');
    //            points.Enqueue(p);
    //        }
    //    }


    //    //뱀 그려주는 메서드 - point 위치에서 dir 방향으로 뱀길이 만큼 *
    //    public void Draw()
    //    {
    //        for (int x = 0; x < length; x++)
    //        {
    //            head.Draw();
    //            head.x++;
    //        }
    //    }

    //    public void Clear()
    //    {
    //        points.Dequeue().Clear();
    //    }

    //    // 뱀 이동해주는 메서드 - 방향을 주는 쪽에 *생성 꼬리 위치 ''
    //    public void Move()
    //    {
    //        if (dir == Direction.LEFT)
    //        {
    //            points.Enqueue(head);
    //            head.Draw();
    //            head.x--;
    //        }
    //        else if (dir == Direction.RIGHT)
    //        {
    //            points.Enqueue(head);
    //            head.Draw();
    //            head.x++;
    //        }
    //        else if (dir == Direction.UP)
    //        {
    //            points.Enqueue(head);
    //            head.Draw();
    //            head.y++;
    //        }
    //        else if (dir == Direction.UP)
    //        {
    //            points.Enqueue(head);
    //            head.Draw();
    //            head.y--;
    //        }
    //    }

    //}

}
