using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace chess_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CreateBoard();
        }

        public void CreateBoard()
        {
            chessBoard.Rows = 8;
            chessBoard.Columns = 8;

            for (int i = 0; i < 32; i++)
            {
                if ((i / 4) % 2 == 0)
                {
                    Rectangle r1 = new Rectangle();
                    r1.Fill = Brushes.Black;
                    chessBoard.Children.Add(r1);

                    Rectangle r2 = new Rectangle();
                    r2.Fill = Brushes.LightCoral;
                    chessBoard.Children.Add(r2);
                }
                else
                {
                    Rectangle r2 = new Rectangle();
                    r2.Fill = Brushes.LightCoral;
                    chessBoard.Children.Add(r2);

                    Rectangle r1 = new Rectangle();
                    r1.Fill = Brushes.Black;
                    chessBoard.Children.Add(r1);
                }
            }
        }
    }
}
