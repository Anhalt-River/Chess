namespace chess_4
{
    public partial class MainWindow
    {
        class Rook : Figure
        {
            public Rook(int newX, int newY) : base(newX, newY)
            { }

            public override bool Answer(int newX, int newY)
            {
                return (x == newX || y == newY);
            }
        }
    }
}
