using HomeWork.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Buisness
{
    public class StudentBuisness
    {
        //public List<Student> StudentsList { get; set; }
        public ObservableCollection<Student> StudentsList { get; set; }

        public Student SelectedStd {  get; set; } 
        public StudentBuisness()
        {
            StudentsList = new ObservableCollection<Student>(); 
            for (int i = 0; i < 3; i++)
            {
                Student std = new Student();
                std.Id = i;
                std.FullName = "Link Hyrulish"+i;
                std.Email = "email@hyurilishexemple.hy" + i;
                StudentsList.Add(std);
            }
        }

    }
}
