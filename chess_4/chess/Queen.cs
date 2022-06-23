using System;

namespace chess_4
{
    public partial class MainWindow
    {
        class Queen : Figure
        {
            public Queen(int newX, int newY) : base(newX, newY)
            { }

            public override bool Answer(int newX, int newY)
            {
                return (x == newX || y == newY ||
                         Math.Abs(x - newX) == Math.Abs(y - newY));
            }
        }
    }
}
