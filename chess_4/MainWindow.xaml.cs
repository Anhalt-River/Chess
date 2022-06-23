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
        private string takedfigure = "";

        public void CreateBoard()
        {
            chessBoard.Rows = 8;
            chessBoard.Columns = 8;

            for (int i = 0; i < 32; i++)
            {
                if ((i / 4) % 2 == 0)
                {
                    Button b1 = new Button();
                    b1.Background = Brushes.Black;
                    chessBoard.Children.Add(b1);

                    Button b2 = new Button();
                    b2.Background = Brushes.LightCoral;
                    chessBoard.Children.Add(b2);
                }
                else
                {
                    Button b2 = new Button();
                    b2.Background = Brushes.LightCoral;
                    chessBoard.Children.Add(b2);

                    Button b1 = new Button();
                    b1.Background = Brushes.Black;
                    chessBoard.Children.Add(b1);
                }
            }

        }

        private void decisionFigure_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            takedfigure = (string)decisionFigure.SelectedValue;
        }
    }
}
