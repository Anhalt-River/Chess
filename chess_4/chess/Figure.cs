namespace chess_4
{
    public partial class MainWindow
    {
        class Figure
        {
            public Point A;
            public Point B;

            public Figure(Point a, Point b)
            {
                A = a;
                B = b;
            }

            public virtual bool Answer()
            {
                bool move = false;
                return move;
            }
        }
    }
}
