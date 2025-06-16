using dataBinding.Data;
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

namespace dataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //there are three types of mode: oneway,twoway,onewaytosource. to update the property from input -> use twoway
        Person person = new Person 
        { 
            //initialize obj
            Name = "Test",
            Age = 20
        
        };
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = person;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string personInfo = person.Name + " is " + person.Age + " old ";
            MessageBox.Show(personInfo);
        }
    }
}