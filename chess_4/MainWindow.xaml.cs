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
        private Figure ourFigure;
        private string takedfigure = "";
        private List<string> figuresNames;

        public MainWindow()
        {
            InitializeComponent();
            figuresNames = new List<string> {"King", "Queen", "Bishop", "Rook", "Knight", "Pawn"};
            decisionFigure.ItemsSource = figuresNames;
        }

        //Клик по кнопке доски. Имелась ли возможность реализации на UniformGrid?
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = (Button)sender;
            int x = Grid.GetColumn(clickedButton);
            int y = Grid.GetRow(clickedButton);

            // Постановка и ходьба фигуры
            if (clickedButton.Content.ToString() == "")
            {
                if (ourFigure == null)
                {
                    ourFigure = FigureFabric.FabricateFigure(takedfigure, x, y);
                    ourFigure.TakedButton = clickedButton;
                    clickedButton.Content = takedfigure;
                }
                else if (ourFigure.MotionAnswer(x, y))
                {
                    clickedButton.Content = takedfigure;
                    Button tempBut = (Button)ourFigure.TakedButton;
                    tempBut.Content = "";
                    ourFigure.TakedButton = clickedButton;
                }
                return;
            }

            // Очищение клетки повторным нажатием
            if (clickedButton.Content.ToString() != "")
            {
                clickedButton.Content = "";
                ourFigure = null;
                return;
            }
        }

        //Выбор одной из фигур в списке
        private void decisionFigure_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            takedfigure = figuresNames[decisionFigure.SelectedIndex];
            ourFigure = null;
        }
    }
}
