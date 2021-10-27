using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            //Отрисовка рамки
            HorizontalLine upLine = new HorizontalLine(1, 79, 1, '+');
            HorizontalLine downLine = new HorizontalLine(1, 79, 25, '+');
            VerticalLine leftLine = new VerticalLine(1, 25, 1, '+');
            VerticalLine rightLine = new VerticalLine(1, 25, 79, '+');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();

            //Отрисовка точки
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }
        }
    }
}
