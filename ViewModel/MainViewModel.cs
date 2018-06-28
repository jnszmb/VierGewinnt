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
        SolidColorBrush background;
        SolidColorBrush background1;
        
        ICommand btdStart;
        ICommand btdReg;
        ICommand btdSave;
        ICommand btd1;
        ICommand btd2;
        ICommand btd3;
        ICommand btd4;
        ICommand btd5;
        ICommand btd6;
        ICommand btd7;



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
            Btd2 = new UserCommands(setzeStein);
            Btd3 = new UserCommands(setzeStein);
            Btd4 = new UserCommands(setzeStein);
            Btd5 = new UserCommands(setzeStein);
            Btd6 = new UserCommands(setzeStein);
            Btd7 = new UserCommands(setzeStein);
        }

        private void setzeStein(object o)
        {
            String name = (String)o;
            if (name.Equals("1"))
            {
                Background1 = System.Windows.Media.Brushes.Red;
                onPropertyChanged(new PropertyChangedEventArgs("Background1"));
            }
            else
            {
                Background = System.Windows.Media.Brushes.Cyan;
                onPropertyChanged(new PropertyChangedEventArgs("Background"));
            }
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

        public SolidColorBrush Background
        {
            get
            {
                return background;
            }

            set
            {
                background = value;
            }
        }

        public ICommand Btd2
        {
            get
            {
                return btd2;
            }

            set
            {
                btd2 = value;
            }
        }

        public ICommand Btd3
        {
            get
            {
                return btd3;
            }

            set
            {
                btd3 = value;
            }
        }

        public ICommand Btd4
        {
            get
            {
                return btd4;
            }

            set
            {
                btd4 = value;
            }
        }

        public ICommand Btd5
        {
            get
            {
                return btd5;
            }

            set
            {
                btd5 = value;
            }
        }

        public ICommand Btd6
        {
            get
            {
                return btd6;
            }

            set
            {
                btd6 = value;
            }
        }

        public ICommand Btd7
        {
            get
            {
                return btd7;
            }

            set
            {
                btd7 = value;
            }
        }

        public SolidColorBrush Background1
        {
            get
            {
                return background1;
            }

            set
            {
                background1 = value;
            }
        }
    }
}
