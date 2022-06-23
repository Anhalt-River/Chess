using System.Windows.Documents;

namespace chess_4
{
    public class FigureFabric
    {
        public void Move (string takedfigure)
        {
            Figure newfigure;
            switch (takedfigure)
            {
                case "Bishop":
                    newfigure = new Figure();
                    break;
                case "King":

                    break;
                case "Rook":

                    break;
                case "Knight":

                    break;
                case "Queen":

                    break;
                default:
                    break;
            }

        }
    }
}
