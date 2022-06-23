using System;

namespace chess_4
{
    public partial class MainWindow
    {
        class Figure
        {
            protected int x;
            protected int y;

            public Figure(int newX, int newY)
            {
                x = newX;
                y = newY;
            }

            public virtual bool Answer(int newX, int newY)
            {
                bool move = false;
                return move;
            }
        }
    }
}
