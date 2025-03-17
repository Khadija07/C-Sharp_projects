using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //creating button manually

            Button myButton = new Button();
            myButton.Content = "B";
            Grid.SetColumn(myButton, 4);
            Grid.SetRow(myButton, 3);

            Grid myGrid = (Grid)FindName("myGrid"); // casts the result of FindName to a Grid type.
            myGrid.Children.Add(myButton); //adds the myButton to the Children collection of the Grid, which makes the button appear within the grid.
        }

        private void RowDefinition_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}