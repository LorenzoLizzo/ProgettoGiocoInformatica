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
        private Personaggio _p1Selezionato; 
        private Personaggio _p2Selezionato; 
        private Arma _armaP1Selezionata; 
        private Arma _armaP2Selezionata; 

        private List <KeyValuePair <BitmapImage, Personaggio>> _immaginiPersonaggi;
        private List <KeyValuePair <BitmapImage, Arma>> _immaginiArmi;

        private Videogioco Videogioco { get; set; }

        public SceltaPersonaggi(Videogioco v)
        {
            Videogioco = v;
            _immaginiPersonaggi = new List<KeyValuePair<BitmapImage, Personaggio>>();
            _immaginiArmi = new List<KeyValuePair<BitmapImage, Arma>>();

            InitializeComponent();

            //Caricamento percorsi
            CaricamentoImmagini();

            //Immagini a schermo dei personaggi
            imgPersonaggioP1.Source = _immaginiPersonaggi[0].Key;
            imgPersonaggioP2.Source = _immaginiPersonaggi[0].Key;

            //Immagini a schermo delle armi
            imgArmaPersonaggioP1.Source = _immaginiArmi[0].Key;
            imgArmaPersonaggioP2.Source = _immaginiArmi[0].Key;

            //Schermo intero?
            if (v.Impostazioni.SchermoIntero)
            {
                this.WindowState = WindowState.Maximized;
            }
        }

        private void CaricamentoImmagini()
        {
            //Carica immagini personaggi
            foreach(Personaggio personaggio in Videogioco.ListaPersonaggi)
            {
                _immaginiPersonaggi.Add(new KeyValuePair<BitmapImage, Personaggio> (new BitmapImage(new Uri(personaggio.PercorsoImmagine, UriKind.Relative)), personaggio));
            }

            //Carica immagini armi
            foreach (Arma arma in Videogioco.ListaArmi)
            {
                _immaginiArmi.Add(new KeyValuePair<BitmapImage, Arma> (new BitmapImage(new Uri(arma.PercorsoImmagine, UriKind.Relative)), arma));
            }
        }

        private void BottonePrimaPersonaggi(Image img)
        {
            for (int i = 0; i < _immaginiPersonaggi.Count; i++)
            {
                if (img.Source.Equals(_immaginiPersonaggi[i].Key) && i != 0)
                {
                    img.Source = _immaginiPersonaggi[i - 1].Key;
                    break;
                }
                else if (img.Source.Equals(_immaginiPersonaggi[i].Key) && i == 0)
                {
                    img.Source = _immaginiPersonaggi[_immaginiPersonaggi.Count - 1].Key;
                    break;
                }
            }
        }

        private void BottoneDopoPersonaggi(Image img)
        {
            for (int i = 0; i < _immaginiPersonaggi.Count; i++)
            {
                if (img.Source.Equals(_immaginiPersonaggi[i].Key) && i != _immaginiPersonaggi.Count - 1)
                {
                    img.Source = _immaginiPersonaggi[i + 1].Key;
                    break;
                }
                else if (img.Source.Equals(_immaginiPersonaggi[i].Key) && i == _immaginiPersonaggi.Count - 1)
                {
                    img.Source = _immaginiPersonaggi[0].Key;
                    break;
                }
            }
        }

        private void BottonePrimaArmi(Image img)
        {
            for (int i = 0; i < _immaginiArmi.Count; i++)
            {
                if (img.Source.Equals(_immaginiArmi[i].Key) && i != 0)
                {
                    img.Source = _immaginiArmi[i - 1].Key;
                    break;
                }
                else if (img.Source.Equals(_immaginiArmi[i].Key) && i == 0)
                {
                    img.Source = _immaginiArmi[_immaginiArmi.Count - 1].Key;
                    break;
                }
            }
        }

        private void BottoneDopoArmi(Image img)
        {
            for (int i = 0; i < _immaginiArmi.Count; i++)
            {
                if (img.Source.Equals(_immaginiArmi[i].Key) && i != _immaginiArmi.Count - 1)
                {
                    img.Source = _immaginiArmi[i + 1].Key;
                    break;
                }
                else if (img.Source.Equals(_immaginiArmi[i].Key) && i == _immaginiArmi.Count - 1)
                {
                    img.Source = _immaginiArmi[0].Key;
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
            if ((Button)sender == btnProntoP1 && !imgPersonaggioP1.Source.Equals(imgPersonaggioP2.Source))
            {
                //Il giocatore P1 è pronto
                btnPrimaP1.IsEnabled = false;
                btnDopoP1.IsEnabled = false;
                btnPrimaArmaP1.IsEnabled = false;
                btnDopoArmaP1.IsEnabled = false;
                btnProntoP1.IsEnabled = false;

                for (int i = 0; i < _immaginiPersonaggi.Count; i++)
                {
                    if (imgPersonaggioP1.Source.Equals(_immaginiPersonaggi[i].Key))
                    {
                        _p1Selezionato = _immaginiPersonaggi[i].Value;
                    }
                }

                for (int i = 0; i < _immaginiArmi.Count; i++)
                {
                    if (imgArmaPersonaggioP1.Source.Equals(_immaginiArmi[i].Key))
                    {
                        _armaP1Selezionata = _immaginiArmi[i].Value;
                    }
                }
            }
            else if ((Button)sender == btnProntoP2 && !imgPersonaggioP2.Source.Equals(imgPersonaggioP1.Source))
            {
                //Il giocatore P2 è pronto
                btnPrimaP2.IsEnabled = false;
                btnDopoP2.IsEnabled = false;
                btnPrimaArmaP2.IsEnabled = false;
                btnDopoArmaP2.IsEnabled = false;
                btnProntoP2.IsEnabled = false;

                for (int i = 0; i < _immaginiPersonaggi.Count; i++)
                {
                    if (imgPersonaggioP2.Source.Equals(_immaginiPersonaggi[i].Key))
                    {
                        _p2Selezionato = _immaginiPersonaggi[i].Value;
                    }
                }

                for (int i = 0; i < _immaginiArmi.Count; i++)
                {
                    if (imgArmaPersonaggioP2.Source.Equals(_immaginiArmi[i].Key))
                    {
                        _armaP2Selezionata = _immaginiArmi[i].Value;
                    }
                }
            }

            if (!btnProntoP1.IsEnabled && !btnProntoP2.IsEnabled)
            {
                //Tutti e due i personaggi sono pronti
                CombattimentoClasse classeCombattimento = new CombattimentoClasse(_p1Selezionato, _p2Selezionato, _armaP1Selezionata, _armaP2Selezionata);

                Combattimento combattimento = new Combattimento(classeCombattimento);
                combattimento.Show();
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
