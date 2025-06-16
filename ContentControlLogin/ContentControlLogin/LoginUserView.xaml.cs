using System;
using System.Collections.Generic;
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

namespace ContentControlLogin
{
    /// <summary>
    /// Interaction logic for LoginUserView.xaml
    /// </summary>
    public partial class LoginUserView : UserControl
    {
        public LoginUserView()
        {
            InitializeComponent();
        }

        private void LoginbuttonClicked(object sender, RoutedEventArgs e)
        {
            Window window = Window.GetWindow(this);  //Gets the top-level Window that contains the current control (for here, its login window).
            window.Content = new invoice(); //Replaces the entire content of the window with a new instance of invoice
        }
    }
}
