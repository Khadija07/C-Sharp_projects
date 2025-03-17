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

namespace ToDoApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddToDoButton(object sender, RoutedEventArgs e)
        {
            string todoText = TodoInput.Text;
            if (!string.IsNullOrEmpty(todoText))
            {
                TextBlock item = new TextBlock()
                {
                    Text = todoText,
                    Margin = new Thickness(10), //padding around the text
                    //Foreground = new SolidColorBrush(Colors.White), text color

                };
                TodoList.Children.Add(item);  //The TodoList is a StackPanel, and it has a Children collection where you can add child elements (like controls)
                TodoInput.Clear();
            }
            else
            {
                MessageBox.Show("Please type something!");
            }
        }

        
    }
}