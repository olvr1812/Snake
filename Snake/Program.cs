using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(7, 4, '*');
            p1.Draw();

            Point p2 = new Point(8, 4, '*');
            p2.Draw();

            Point p3 = new Point(9, 4, '*');
            p3.Draw();

            HorizontalLine upLine = new HorizontalLine(6, 19 , 8, '_');
            VerticalLine leftLine = new VerticalLine(9, 20, 5, '|');
            HorizontalLine downLine = new HorizontalLine(6, 19, 20, '_');
            VerticalLine rightLine = new VerticalLine(9, 20, 20, '|');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();
            
            Console.ReadLine();
        }
    }
}
