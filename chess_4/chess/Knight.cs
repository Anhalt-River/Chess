using System;

namespace chess_4
{
    public partial class MainWindow
    {
        class Knight : Figure
        {
            public Knight(int newX, int newY) : base(newX, newY)
            { }

            public override bool Answer(int newX, int newY)
            {
                return ((Math.Abs(x - newX) == 2 && Math.Abs(y - newY) == 1) ||
                        (Math.Abs(x - newX) == 1 && Math.Abs(y - newY) == 2));
            }
        }
    }
}
