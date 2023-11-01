using HomeWork.Models;
using HomeWork.pages;
using HomeWork.pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;

namespace HomeWork.Buisness
{
    public class LoginPageBuisness
    {
        public LoginPageBuisness()
        {
             
        }
        private LoginWindow ViewModel1 = new LoginWindow();
        public void loginBtn(string username, string password)
        {
            if (username == "zili" && password == "zili")
            {
               MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
            }
            else
            {
                MessageBox.Show("wrong password or wrong username :_(");
            }
        }

    }
}
