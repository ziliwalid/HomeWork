using HomeWork.Buisness;
using HomeWork.Models;
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
using System.Windows.Shapes;

namespace HomeWork.pages
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        UserModel _user;
        LoginPageBuisness _pageBuisness;
        public LoginWindow()
        {
            InitializeComponent();
            _user = new UserModel();
            this.DataContext = _user;
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
           _pageBuisness = new LoginPageBuisness();
            _pageBuisness.loginBtn(_user.UserName, _user.Password);
        }
    }
}
