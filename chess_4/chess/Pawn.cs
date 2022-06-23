namespace chess_4
{
    public partial class MainWindow
    {
        class Pawn : Figure
        {
            public Pawn(int newX, int newY) : base(newX, newY)
            { }

            public override bool Answer(int newX, int newY)
            {
                return ((x == newX && y == 2 && y + 2 >= newY) ||
                        (x == newX && y + 1 == newY));
            }
        }
    }
}
