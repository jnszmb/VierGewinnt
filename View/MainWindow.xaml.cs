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
using ViewModel;

namespace View
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int x;
        int y; 
        SolidColorBrush rot = Brushes.Red;
        SolidColorBrush blau = Brushes.Blue;
        bool flag = true;
        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_start_Click(object sender, RoutedEventArgs e)
        {
            GridFeld.IsEnabled = true;
        }
    }
}
