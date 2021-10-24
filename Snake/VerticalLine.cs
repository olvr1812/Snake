using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class VerticalLine
    {
        List<Point> plist;

        public VerticalLine(int yup, int ydown, int x, char sym)
        {
            plist = new List<Point>();
            for (int y = yup; y <= ydown; y++)
            {
                Point p = new Point(x, y, sym);
                plist.Add(p);
            }

        }
        public void Drow()
        {
            foreach (Point p in plist)
            {
                p.Draw();
            }
        }
        }
}
