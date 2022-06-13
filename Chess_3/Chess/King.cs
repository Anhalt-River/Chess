
public partial class Program
{
    class King : Figure
    {
        public King(Point a, Point b) : base(a, b)
        { }

        public override bool Answer()
        {
            return (Math.Abs(A.X - B.X) <= 1 && Math.Abs(A.Y - B.Y) <= 1);
        }
    }
}
