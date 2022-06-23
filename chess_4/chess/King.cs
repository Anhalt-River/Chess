using System;

namespace chess_4
{
    public partial class MainWindow
    {
        class King : Figure
        {
            public King(int newX, int newY) : base(newX, newY)
            { }

            public override bool Answer(int newX, int newY)
            {
                return (Math.Abs(x - newX) <= 1 && Math.Abs(y - newY) <= 1);
            }
        }
    }
}
