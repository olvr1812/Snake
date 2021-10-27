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
            VerticalLine vl = new VerticalLine(0, 10, 5, '%');
            Draw(vl);

            //Отрисовка точки
            Point p = new Point(4, 5, '*');
            Figure fSnake = new Snake(p, 4, Direction.RIGHT);
            Draw(fSnake);
            Snake snake = (Snake) fSnake;

            HorizontalLine hl = new HorizontalLine(0, 5, 6, '&');

            List<Figure> figures = new List<Figure>();
            figures.Add(fSnake);
            figures.Add(vl);
            figures.Add(hl);

            foreach (var f in figures)
            {
                f.Draw();
            }
        }

        static void Draw(Figure figure)
        {
            figure.Draw();
        }
    }
}
