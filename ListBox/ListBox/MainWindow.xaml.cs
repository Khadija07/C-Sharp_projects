using ListBox.Data;
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

namespace ListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //calls public class Person
        public List<Person> People = new List<Person>
        { 
            //creating four instances of Person in List
            new Person{Name = "ktk", Age= 20},
            new Person{Name = "Abc", Age= 40},
            new Person{Name = "ayn", Age= 30},
            new Person{Name = "def", Age= 10}

        };
        public MainWindow()
        {
            InitializeComponent();
            ListBox_People.ItemsSource = People; 
            //binds the ListBox control to the People list.
            //This means the list box will display one item for each Person in the list.


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = ListBox_People.SelectedItems; //"SelectedItems" Works only if ListBox has SelectionMode="Multiple" set in XAML.

            foreach (var item in selectedItem)
            {
                var person = (Person)item; //casted item obj as Person
                //MessageBox.Show(person.Name,person.Age.ToString()); MessageBox.Show(string text, string caption)

                MessageBox.Show($"Name: {person.Name} , Age: {person.Age}");
            }

        }
    }
}