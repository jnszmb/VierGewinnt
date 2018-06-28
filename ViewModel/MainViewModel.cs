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
using System.Windows.Controls;
using System.Windows.Media;
using System.Drawing;

namespace ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        Spiel spiel;
        int punkteSp1;
        int punkteSp2;
        
        ICommand btdStart;
        ICommand btdReg;
        ICommand btdSave;
        ICommand btd1;
  

        public event PropertyChangedEventHandler PropertyChanged;

        public void onPropertyChanged(PropertyChangedEventArgs e)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, e);
            }
        }

        public MainViewModel()
        {
            spiel = new Spiel();
            spiel.LoadSpieler();
            spiel.BesterSpieler();
            BtdReg = new UserCommands(Registrieren);
            BtdStart = new UserCommands(starten);
            BtdStart = new UserCommands(speichern);
            Btd1 = new UserCommands(setzeStein);
        }

        private void setzeStein(object o)
        {
            
        }
        private void speichern(object obj)
        {
            spiel.Speichern();
            Window w = (Window)obj;
            w.Close();
        }
        private void Registrieren(object obj)
        {
            String name = (String)obj;
            Spieler s = spiel.Registrieren(name);
        }
        private void starten(object obj)
        {
            
        }
        public ObservableCollection<Spieler> LSTSpieler
        {
            get { return spiel.LstSpieler; }
        }
        public String Best
        {
            get { return spiel.Best; }
        }

        public int PunkteSp1
        {
            get
            {
                return punkteSp1;
            }

            set
            {
                punkteSp1 = value;
            }
        }

        public int PunkteSp2
        {
            get
            {
                return punkteSp2;
            }

            set
            {
                punkteSp2 = value;
            }
        }

        public ICommand BtdStart
        {
            get
            {
                return btdStart;
            }

            set
            {
                btdStart = value;
            }
        }

        public ICommand BtdReg
        {
            get
            {
                return btdReg;
            }

            set
            {
                btdReg = value;
            }
        }

        public ICommand BtdSave
        {
            get
            {
                return btdSave;
            }

            set
            {
                btdSave = value;
            }
        }

        public ICommand Btd1
        {
            get
            {
                return btd1;
            }

            set
            {
                btd1 = value;
            }
        }

        private void SetzeStein(object obj)
        {
            onPropertyChanged(new PropertyChangedEventArgs("Background"));
        }
    }
}
