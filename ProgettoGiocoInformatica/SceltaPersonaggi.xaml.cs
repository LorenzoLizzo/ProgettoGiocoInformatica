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

        private Videogioco Videogioco { get; set; }

        public SceltaPersonaggi(Videogioco v)
        {
            Videogioco = v;

            InitializeComponent();

            //Schermo intero?
            if (v.Impostazioni.SchermoIntero)
            {
                this.WindowState = WindowState.Maximized;
            }
        }


        private void BottoniPrimaPersonaggi(object sender, RoutedEventArgs e)
        {
            if ((Button)sender == btnPrimaP1)
            {
                //Cambia P1
            }
            else
            {
                //Cambia P2
            }
        }

        private void BottoniDopoPersonaggi(object sender, RoutedEventArgs e)
        {
            if ((Button)sender == btnDopoP1)
            {
                //Cambia P1
            }
            else
            {
                //Cambia P2
            }
        }

        private void BottoniPrimaArmi(object sender, RoutedEventArgs e)
        {
            if ((Button)sender == btnPrimaArmaP1)
            {
                //Cambia arma P1
            }
            else
            {
                //Cambia arma P2
            }
        }

        private void BottoniDopoArmi(object sender, RoutedEventArgs e)
        {
            if ((Button)sender == btnDopoArmaP1)
            {
                //Cambia arma P1
            }
            else
            {
                //Cambia arma P2
            }
        }

        private void btnProntoClick(object sender, RoutedEventArgs e)
        {
            if ((Button)sender == btnProntoP1)
            {
                //Il giocatore P1 è pronto

                btnProntoP1.IsEnabled = false;
                _p1Pronto = true;
            }
            else
            {
                //Il giocatore P2 è pronto

                btnProntoP2.IsEnabled = false;
                _p2Pronto = true;
            }

            if (_p2Pronto && _p1Pronto)
            {
                //Tutti e due i personaggi sono pronti
                CombattimentoClasse cl = new CombattimentoClasse(_p1, _p2, _armaP1, _armaP2);

                Combattimento c = new Combattimento(cl);

                c.Show();
                this.Close();
            }


        }

        private void btnOpzioni_Click(object sender, RoutedEventArgs e)
        {
            ImpostazioniWindow iw = new ImpostazioniWindow(Videogioco);
            iw.Show();

            this.Close();
        }

    }
}
