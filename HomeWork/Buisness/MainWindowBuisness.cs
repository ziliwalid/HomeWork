using HomeWork.Models;
using HomeWork.pages;
using HomeWork.pages.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace HomeWork.Buisness
{
    public class MainWindowBuisness
    {
        private EtudiantUserControl stdControl = new EtudiantUserControl();
        public MainWindowBuisness()
        {
            
        }

        private ICommand _clickCommand;
        public ICommand ClickCommand
        {
            get
            {
                return _clickCommand ?? (_clickCommand = new CommandHandler(() => addClick(), () => CanExecute));
            }
        }
        public bool CanExecute
        {
            get
            {
                return true;
            }
        }

        public void addClick()
        {
            MessageBox.Show("hello");
        }
    }
}
