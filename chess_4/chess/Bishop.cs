using System;

namespace chess_4
{
    public partial class MainWindow
    {
        class Bishop : Figure
        {
            public Bishop(int newX, int newY) : base(newX, newY)
            { }

            public override bool Answer(int newX, int newY)
            {
                return (Math.Abs(x - newX) == Math.Abs(y - newY));
            }
        }
    }
}
