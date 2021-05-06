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
using System.Windows.Shapes;
using System.Threading;

namespace ProgettoGiocoInformatica
{
    /// <summary>
    /// Logica di interazione per SceltaPersonaggi.xaml
    /// </summary>
    public partial class SceltaPersonaggi : Window
    {
        private Personaggio _p1;
        private Personaggio _p2;
        private Image _immagineP1;
        private Image _immagineP2;

        private Arma _armaP1;
        private Arma _armaP2;
        private Image _immagineArmaP1;
        private Image _immagineArmaP2;

        private bool _p1Pronto;
        private bool _p2Pronto;

        private Timer _timer;

        public SceltaPersonaggi()
        {
            InitializeComponent();
        }


        private void BottoniPrimaPersonaggi(object sender, RoutedEventArgs e)
        {

        }

        private void BottoniDopoPersonaggi(object sender, RoutedEventArgs e)
        {

        }

        private void BottoniPrimaArmi(object sender, RoutedEventArgs e)
        {

        }

        private void BottoniDopoArmi(object sender, RoutedEventArgs e)
        {

        }

        private void btnProntoP1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnProntoP2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnOpzioni_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
