﻿using System;

namespace chess_4
{
    public partial class MainWindow
    {
        class Queen : Figure
        {
            public Queen(Point a, Point b) : base(a, b)
            { }

            public override bool Answer()
            {
                return (A.X == B.X || A.Y == B.Y ||
                         Math.Abs(A.X - B.X) == Math.Abs(A.Y - B.Y));
            }
        }
    }
}
