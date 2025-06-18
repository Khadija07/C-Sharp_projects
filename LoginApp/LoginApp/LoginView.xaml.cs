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

namespace LoginApp
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var passwordInfo = PasswordBox.Password; //gets the password entered by the user
            string originalPass = System.Environment.GetEnvironmentVariable("LoginApp"); //getting the password that is set in the system environment variable,
                                                                                         //under the variable name "LoginApp", pass Test123

            if (originalPass != null)
            {
                if (passwordInfo == originalPass)
                {
                    //MessageBox.Show("Login Successful");

                    //opens new window PersonInfo
                    Window window = Window.GetWindow(this);
                    window.Content = new PersonInfo();
                }
                else
                {
                    MessageBox.Show("Wrong password");
                }

            }
            else
            {
                MessageBox.Show("password not found");
            }
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            //login button will be disabled if there is no password in the input box
            //to disable the button from the start of the application, disable in the property section
            //of button
            ClickedButton.IsEnabled = !string.IsNullOrEmpty(PasswordBox.Password);

        }
    }
}
