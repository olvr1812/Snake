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

            HorizontalLine line = new HorizontalLine(5, 20 , 8, '*');
            line.Drow();

            VerticalLine line1 = new VerticalLine(8, 20, 5, '*');
            line1.Drow();


            HorizontalLine line2 = new HorizontalLine(5, 20, 20, '*');
            line2.Drow();

            VerticalLine line3 = new VerticalLine(8, 20, 20, '*');
            line3.Drow();
            Console.ReadLine();
        }
    }
}
