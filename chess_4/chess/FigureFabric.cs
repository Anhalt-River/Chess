using System;

namespace chess_4
{
    public class FigureFabric
    {
        static public Figure FabricateFigure(string takedfigure, int x, int y)
        {
            Figure newfigure = null;
            switch (takedfigure)
            {
                case "Bishop":
                    newfigure = new Bishop(x, y);
                    break;
                case "King":
                    newfigure = new King(x, y);
                    break;
                case "Rook":
                    newfigure = new Rook(x, y);
                    break;
                case "Knight":
                    newfigure = new Knight(x, y);
                    break;
                case "Queen":
                    newfigure = new Queen(x, y);
                    break;
                case "Pawn":
                    newfigure = new Pawn(x, y);
                    break;
                default:
                    throw new Exception("Unknown piece code.");
                    break;
            }
            return newfigure;
        }
    }
}
