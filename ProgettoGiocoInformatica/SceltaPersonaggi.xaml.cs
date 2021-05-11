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
        private bool _p1Pronto;
        private bool _p2Pronto;

        private Timer _timer;

        public Videogioco Videogioco { get; set; }

        public SceltaPersonaggi(Videogioco v)
        {
            Videogioco = v;

            InitializeComponent();

            imgPersonaggioP1.Source = new BitmapImage(new Uri(Videogioco.ListaPersonaggi[0].PercorsoImmagine, UriKind.Relative));

            //Schermo intero?
            if (v.Impostazioni.SchermoIntero)
            {
                this.WindowState = WindowState.Maximized;
            }
        }

        public SceltaPersonaggi()
        {
            InitializeComponent();
            Videogioco = new Videogioco();
        }

        private void BottonePrimaPersonaggi(Image img)
        {
            for (int i = 0; i < Videogioco.ListaPersonaggi.Count; i++)
            {
                if (img.Source == new BitmapImage(new Uri(Videogioco.ListaPersonaggi[i].PercorsoImmagine, UriKind.Relative)) && i != 0)
                {
                    img.Source = new BitmapImage(new Uri(Videogioco.ListaPersonaggi[i - 1].PercorsoImmagine, UriKind.Relative));
                    break;
                }
                else if (img.Source == new BitmapImage(new Uri(Videogioco.ListaPersonaggi[i].PercorsoImmagine, UriKind.Relative)) && i == 0)
                {
                    img.Source = new BitmapImage(new Uri(Videogioco.ListaPersonaggi[Videogioco.ListaPersonaggi.Count - 1].PercorsoImmagine, UriKind.Relative));
                    break;
                }
            }
        }

        private void BottoneDopoPersonaggi(Image img)
        {
            for (int i = 0; i < Videogioco.ListaPersonaggi.Count; i++)
            {
                if (img.Source == new BitmapImage(new Uri(Videogioco.ListaPersonaggi[i].PercorsoImmagine, UriKind.Relative)) && i != Videogioco.ListaPersonaggi.Count - 1)
                {
                    img.Source = new BitmapImage(new Uri(Videogioco.ListaPersonaggi[i + 1].PercorsoImmagine, UriKind.Relative));
                    break;
                }
                else if (img.Source == new BitmapImage(new Uri(Videogioco.ListaPersonaggi[i].PercorsoImmagine, UriKind.Relative)) && i == Videogioco.ListaPersonaggi.Count - 1)
                {
                    img.Source = new BitmapImage(new Uri(Videogioco.ListaPersonaggi[0].PercorsoImmagine, UriKind.Relative));
                    break;
                }
            }
        }

        private void BottonePrimaArmi(Image img)
        {
            for (int i = 0; i < Videogioco.ListaArmi.Count; i++)
            {
                if (img.Source == new BitmapImage(new Uri(Videogioco.ListaArmi[i].PercorsoImmagine, UriKind.Relative)) && i != 0)
                {
                    img.Source = new BitmapImage(new Uri(Videogioco.ListaArmi[i - 1].PercorsoImmagine, UriKind.Relative));
                    break;
                }
                else if (img.Source == new BitmapImage(new Uri(Videogioco.ListaArmi[i].PercorsoImmagine, UriKind.Relative)) && i == 0)
                {
                    img.Source = new BitmapImage(new Uri(Videogioco.ListaArmi[Videogioco.ListaArmi.Count - 1].PercorsoImmagine, UriKind.Relative));
                    break;
                }
            }
        }

        private void BottoneDopoArmi(Image img)
        {
            for (int i = 0; i < Videogioco.ListaPersonaggi.Count; i++)
            {
                if (img.Source == new BitmapImage(new Uri(Videogioco.ListaArmi[i].PercorsoImmagine, UriKind.Relative)) && i != Videogioco.ListaArmi.Count - 1)
                {
                    img.Source = new BitmapImage(new Uri(Videogioco.ListaArmi[i + 1].PercorsoImmagine, UriKind.Relative));
                    break;
                }
                else if (img.Source == new BitmapImage(new Uri(Videogioco.ListaArmi[i].PercorsoImmagine, UriKind.Relative)) && i == Videogioco.ListaArmi.Count - 1)
                {
                    img.Source = new BitmapImage(new Uri(Videogioco.ListaArmi[0].PercorsoImmagine, UriKind.Relative));
                    break;
                }
            }
        }

        private void BottoniPrimaPersonaggi(object sender, RoutedEventArgs e)
        {
            if ((Button)sender == btnPrimaP1)
            {
                BottonePrimaPersonaggi(imgPersonaggioP1);
            }
            else
            {
                BottonePrimaPersonaggi(imgPersonaggioP2);
            }
        }

        private void BottoniDopoPersonaggi(object sender, RoutedEventArgs e)
        {
            if ((Button)sender == btnDopoP1)
            {
                BottoneDopoPersonaggi(imgPersonaggioP1);
            }
            else
            {
                BottoneDopoPersonaggi(imgPersonaggioP2);
            }
        }

        private void BottoniPrimaArmi(object sender, RoutedEventArgs e)
        {
            if ((Button)sender == btnPrimaArmaP1)
            {
                BottonePrimaArmi(imgArmaPersonaggioP1);
            }
            else
            {
                BottonePrimaArmi(imgArmaPersonaggioP2);
            }
        }

        private void BottoniDopoArmi(object sender, RoutedEventArgs e)
        {
            if ((Button)sender == btnDopoArmaP1)
            {
                BottoneDopoArmi(imgArmaPersonaggioP1);
            }
            else
            {
                BottoneDopoArmi(imgArmaPersonaggioP2);
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
                CombattimentoClasse cl = new CombattimentoClasse(new Personaggio(), new Personaggio(), new Arma(), new Arma());

                Combattimento c = new Combattimento(cl);

                c.Show();
                this.Close();
            }


        }

        private void btnOpzioni_Click(object sender, RoutedEventArgs e)
        {
            ImpostazioniWindow impostazioni = new ImpostazioniWindow(Videogioco);
            impostazioni.Show();
            this.Close();
        }

    }
}
