using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Food
    {
        public Position FoodPos = new Position();
        Random rand = new Random();
        Map map = new Map();
        public Food()
        {
            FoodPos.x = rand.Next(5, map.Width);
            FoodPos.y = rand.Next(5, map.Height);
        }
        public void DrawFood()
        {
            Console.SetCursorPosition(FoodPos.x, FoodPos.y);
            Console.Write("$");
        }
        public Position FoodLoc()
        {
            return FoodPos;
        }
        public void FoodNewLoc()
        {
            FoodPos.x = rand.Next(5, map.Width);
            FoodPos.y = rand.Next(5, map.Height);
        }
    }
}