using HomeWork.Buisness;
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
using HomeWork.Models;

namespace HomeWork.pages.UserControls
{
    /// <summary>
    /// Interaction logic for EtudiantUserControl.xaml
    /// </summary>
    public partial class EtudiantUserControl : UserControl
    {
        public EtudiantUserControl()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddForm addForm = new AddForm();    
            Student student = new Student();

            addForm.DataContext = student;

            addForm.ShowDialog();

            StudentBuisness studentBuisness = this.DataContext as  StudentBuisness;

            studentBuisness.StudentsList.Add(student);
            
    }

        //delete button, kindof lazy to change names
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            StudentBuisness studentBuisness = this.DataContext as StudentBuisness;

            if (studentBuisness.SelectedStd != null)
            {
                AddForm addForm = new AddForm();

                addForm.DataContext = studentBuisness.SelectedStd;
                

                addForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("no selected student :(");
            }

        }


        //delete button
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            StudentBuisness studentBuisness = this.DataContext as StudentBuisness;

            if (studentBuisness.SelectedStd != null)
            {

                studentBuisness.StudentsList.Remove(studentBuisness.SelectedStd);              

                
            }
            else
            {
                MessageBox.Show("no selected student to delete:(");
            }
        }
    }
}
