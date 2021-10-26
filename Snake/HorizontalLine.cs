﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class HorizontalLine : Figure
    {
        public HorizontalLine(int xleft, int xreight, int y, char sym)
        {
            pList = new List<Point>();
            for (int x = xleft; x <= xreight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }            
        }
    }
}
