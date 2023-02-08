using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Map
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Map()
        {
            Width = 60;
            Height = 25;

            Console.CursorVisible = false;
        }
        public void DrawCanvas()
        {
            Console.Clear();
            for (int x = 0; x < Width; x++)
            {
                Console.SetCursorPosition(x, 0);
                Console.Write("#");
            }
            for (int x = 0; x < Width; x++)
            {
                Console.SetCursorPosition(x, Height);
                Console.Write("#");

            }
            for (int x = 0; x < Height; x++)
            {
                Console.SetCursorPosition(0, x);
                Console.Write("#");

            }
            for (int x = 0; x < Height; x++)
            {
                Console.SetCursorPosition(Width, x);
                Console.Write("#");
            }
        }
    }
}