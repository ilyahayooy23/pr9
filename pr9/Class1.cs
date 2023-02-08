namespace Snake
{
    internal class Program
    {

        static void Main(string[] args)
        {
            bool finished = false;
            Map map = new Map();
            Snake snake = new Snake();
            Food food = new Food();
            Console.WriteLine("------------------------------------Нажмите Enter для начала игры------------------------------------");
            Console.Read();

            while (!finished)
            {
                try
                {
                    map.DrawCanvas();
                    Console.SetCursorPosition(60, 1);
                    Console.Write("Счет: {0}", snake.score);
                    snake.Input();
                    food.DrawFood();
                    snake.DrawSnake();
                    snake.MoveSnake();
                    snake.Eat(food.FoodLoc(), food);
                    snake.Kill();
                    snake.HitWalls(map);
                }
                catch (Exception e)
                {
                    finished = true;
                }

            }
        }
    }
}