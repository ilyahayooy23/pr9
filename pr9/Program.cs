using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{

    public class Snake
    {


        ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
        char key = 'w';
        char dir = 'u';

        public int x { get; set; }
        public int y { get; set; }
        public int score { get; set; }

        public List<Position> SnakeBody { get; set; }

        public Snake()
        {
            x = 20;
            y = 20;
            score = 0;
            SnakeBody = new List<Position>();
            SnakeBody.Add(new Position(x, y));
        }

        public void DrawSnake()
        {
            foreach (Position pos in SnakeBody)
            {

                Console.SetCursorPosition(pos.x, pos.y);
                Console.Write("*");
            }
        }

        public void Input()
        {
            if (Console.KeyAvailable)
            {
                keyInfo = Console.ReadKey(true);
                key = keyInfo.KeyChar;

            }
        }
        private void direction()
        {
            if (key == 'w' && dir != 'd')
            {
                dir = 'u';
            }
            else if (key == 's' && dir != 'u')
            {
                dir = 'd';
            }
            else if (key == 'd' && dir != 'l')
            {
                dir = 'r';
            }
            else if (key == 'a' && dir != 'r')
            {
                dir = 'l';
            }
        }

        public void MoveSnake()
        {
            direction();
            if (dir == 'u')
            {
                y--;
            }
            else if (dir == 'd')
            {
                y++;
            }
            else if (dir == 'l')
            {
                x--;
            }
            else if (dir == 'r')
            {
                x++;
            }
            SnakeBody.Add(new Position(x, y));
            SnakeBody.RemoveAt(0);
            Thread.Sleep(100);
        }
        public void Eat(Position food, Food fd)
        {
            Position HeadSnake = SnakeBody[SnakeBody.Count - 1];
            if (HeadSnake.x == food.x && HeadSnake.y == food.y)
            {
                SnakeBody.Add(new Position(x, y));
                fd.FoodNewLoc();
                score++;
            }
        }

        public void Kill()
        {
            Position HeadSnake = SnakeBody[SnakeBody.Count - 1];
            for (int i = 0; i < SnakeBody.Count - 2; i++)
            {
                Position sb = SnakeBody[i];
                if (HeadSnake.x == sb.x && HeadSnake.y == sb.y)
                {
                    throw new Exception("ВЫ ПРОИГРАЛИ");
                }
            }
        }

        public void HitWalls(Map map)
        {
            Position HeadSnake = SnakeBody[SnakeBody.Count - 1];
            if (HeadSnake.x >= map.Width || HeadSnake.x <= 0 || HeadSnake.y >= map.Height || HeadSnake.y <= 0)
            {
                throw new Exception("ВЫ ПРОИГРАЛИ");
            }
        }
    }
}