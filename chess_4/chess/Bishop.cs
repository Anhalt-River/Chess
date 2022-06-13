using System;

namespace chess_4
{
    public partial class MainWindow
    {
        class Bishop : Figure
        {
            public Bishop(Point a, Point b) : base(a, b)
            { }

            public override bool Answer()
            {
                return (Math.Abs(A.X - B.X) == Math.Abs(A.Y - B.Y));
            }
        }
    }
}
