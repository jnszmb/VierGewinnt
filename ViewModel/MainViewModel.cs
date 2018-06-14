using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.ComponentModel;
using Model;
using System.Collections.ObjectModel;

namespace ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        Spiel spiel;
        ICommand bdt1;
  

        public event PropertyChangedEventHandler PropertyChanged;

        public void onPropertyChanged(PropertyChangedEventArgs e)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, e);
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
            spiel = new Spiel();
            spiel.LoadSpieler();
            bdt1 = new UserCommands(SetzeStein);
        }
        public ObservableCollection<Spieler>LSTSpieler
        {
            get { return spiel.LstSpieler; }
        }

        private void SetzeStein(object obj)
        {

            onPropertyChanged(new PropertyChangedEventArgs("Background"));
        }
    }
}
