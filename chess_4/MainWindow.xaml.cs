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


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = (Button)sender;
            int x = Grid.GetColumn(clickedButton);
            int y = Grid.GetRow(clickedButton);

            // set
            if (clickedButton.Content.ToString() == "")
            {
                if (ourFigure == null)
                {
                    ourFigure = FigureFabric.FabricateFigure(takedfigure, x, y);
                    ourFigure.TakedButton = clickedButton;
                    clickedButton.Content = takedfigure;
                }
                else if (ourFigure.Move(x, y))
                {
                    clickedButton.Content = takedfigure;
                    (ourFigure.TakedButton as Button).Content = "";
                    ourFigure.TakedButton = clickedButton;
                }
                return;
            }

            // clear
            if (clickedButton.Content.ToString() != "")
            {
                clickedButton.Content = "";
                ourFigure = null;
                return;
            }
        }

        private void decisionFigure_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            takedfigure = figuresNames[decisionFigure.SelectedIndex];
        }
    }
}
