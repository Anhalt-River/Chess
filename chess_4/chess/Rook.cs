namespace chess_4
{
    public partial class MainWindow
    {
        class Rook : Figure
        {
            public Rook(Point a, Point b) : base(a, b)
            { }

            public override bool Answer()
            {
                return (A.X == B.X || A.Y == B.Y);
            }
        }
    }
}
