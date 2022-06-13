using System;

namespace chess_4
{
    public partial class MainWindow
    {
        class Knight : Figure
        {
            public Knight(Point a, Point b) : base(a, b)
            { }

            public override bool Answer()
            {
                return ((Math.Abs(A.X - B.X) == 2 && Math.Abs(A.Y - B.Y) == 1) ||
                        (Math.Abs(A.X - B.X) == 1 && Math.Abs(A.Y - B.Y) == 2));
            }
        }
    }
}
