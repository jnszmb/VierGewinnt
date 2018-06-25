using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.ComponentModel;
using System.Windows.Media;

namespace ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private System.Windows.Media.Brush _b;
        private System.Windows.Media.Brush BackgroundColour;

        public Brush B
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

        private string _s;
        public string SomeOtherProperty
        {
            get
            {
                return _s;
            }

            set
            {
                _s = value; NotifyPropertyChanged("SomeOtherProperty"); BackgroundColour = System.Windows.Media.Brushes.Green;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName = "")
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public MainViewModel()
        {
            
        }

    }
}
