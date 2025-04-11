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

namespace WpfBrowserApp1
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Password; // PasswordBox uses the Password property

            if (username == "admin" && password == "password123")
            {
                MessageBox.Show("Login successful!");
                // Add logic here to navigate to another page or perform other actions
            }
            else
            {
                MessageBox.Show("Login failed. Incorrect username or password.");
            }
        }
        private void txtUsername_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Your logic here
        }

    }
}
