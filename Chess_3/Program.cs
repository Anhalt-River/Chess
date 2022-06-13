/*
*   Chess-3.
*   Bakirov_Karim_220
*/

public partial class Program
{
    public static void Main()
    {
        Figure King = new King(new Point(2, 4), new Point(3, 4));
        Console.WriteLine(King.Answer());

        Figure Queen = new Queen(new Point(0, 0), new Point(9, 9));
        Console.WriteLine(Queen.Answer());

        Figure Bishop = new Bishop(new Point(3, 0), new Point(0, 3));
        Console.WriteLine(Bishop.Answer());

        Figure Knight = new Knight(new Point(0, 0), new Point(1, 2));
        Console.WriteLine(Knight.Answer());

        Figure Rook = new Rook(new Point(3, 0), new Point(3, 4));
        Console.WriteLine(Rook.Answer());
    }
}
