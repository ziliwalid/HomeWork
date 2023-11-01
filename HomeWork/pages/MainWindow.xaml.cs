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
using HomeWork.pages;
using HomeWork.pages.UserControls;
using HomeWork.Buisness;

namespace HomeWork
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

       

        private void student_Click(object sender, RoutedEventArgs e)
        {
           EtudiantUserControl controlStd = new EtudiantUserControl();
            StudentBuisness stdBuisness = new StudentBuisness();    
            controlStd.DataContext = stdBuisness;

            ContentGrid.Children.Clear();
            ContentGrid.Children.Add(controlStd);
            
            
        }
        private void presence_Click(object sender, RoutedEventArgs e)
        {

            IntheWorks intheWorks = new IntheWorks();

            ContentGrid.Children.Clear();
            ContentGrid.Children.Add(intheWorks);

        }

        private void login_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
