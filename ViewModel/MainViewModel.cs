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
        int[,] matrix = new int[6, 7];
        Spiel spiel;
        int punkteSp1;
        int punkteSp2;

        int[,] matrix = new int[6, 7];

        SolidColorBrush background1;
        SolidColorBrush background2;
        SolidColorBrush background3;
        SolidColorBrush background4;
        SolidColorBrush background5;
        SolidColorBrush background6;
        SolidColorBrush background7;

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
            switch (name)
            {
                case "1":
                    Background1 = System.Windows.Media.Brushes.Red;
                    onPropertyChanged(new PropertyChangedEventArgs("Background1"));
                    break;
                case "2":
                    Background2 = System.Windows.Media.Brushes.Green;
                    onPropertyChanged(new PropertyChangedEventArgs("Background2"));
                    break;
                case "3":
                    Background3 = System.Windows.Media.Brushes.Green;
                    onPropertyChanged(new PropertyChangedEventArgs("Background3"));
                    break;
                case "4":
                    Background4 = System.Windows.Media.Brushes.Green;
                    onPropertyChanged(new PropertyChangedEventArgs("Background4"));
                    break;
                case "5":
                    Background5 = System.Windows.Media.Brushes.Green;
                    onPropertyChanged(new PropertyChangedEventArgs("Background5"));
                    break;
                case "6":
                    Background6 = System.Windows.Media.Brushes.Green;
                    onPropertyChanged(new PropertyChangedEventArgs("Background6"));
                    break;
                case "7":
                    Background7 = System.Windows.Media.Brushes.Green;
                    onPropertyChanged(new PropertyChangedEventArgs("Background7"));
                    break;
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
            String name = (String)obj;
            spiel.Starten(name);
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
                return Btd41;
            }

            set
            {
                Btd41 = value;
            }
        }

        public ICommand Btd5
        {
            get
            {
                return Btd51;
            }

            set
            {
                Btd51 = value;
            }
        }

        public ICommand Btd6
        {
            get
            {
                return Btd61;
            }

            set
            {
                Btd61 = value;
            }
        }

        public ICommand Btd7
        {
            get
            {
                return Btd71;
            }

            set
            {
                Btd71 = value;
            }
        }

        public SolidColorBrush Background2
        {
            get
            {
                return background2;
            }

            set
            {
                background2 = value;
            }
        }

        public SolidColorBrush Background3
        {
            get
            {
                return background3;
            }

            set
            {
                background3 = value;
            }
        }

        public int[,] Matrix
        {
            get
            {
                return matrix;
            }

            set
            {
                matrix = value;
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

        public int Zaehler
        {
            get
            {
                return zaehler;
            }

            set
            {
                zaehler = value;
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
