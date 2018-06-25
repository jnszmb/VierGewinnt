using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.ComponentModel;
using Model;
using System.Collections.ObjectModel;
using System.Windows;

namespace ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        ICommand bdt1;

        public event PropertyChangedEventHandler PropertyChanged;

        public void onPropertyChanged(PropertyChangedEventArgs e)
        {
            get
            {
                return _b;
            }
            
            set
            {
                _b = value; NotifyPropertyChanged("BackgroundColour");
            }
        }

        public ICommand Bdt1
        {
            get
            {
                return bdt1;
            }

            set
            {
                bdt1 = value;
            }
        }

        public MainViewModel()
        {
            bdt1 = new UserCommands(SetzeStein);
        }

        public MainViewModel()
        {
            
        }

    }
}
