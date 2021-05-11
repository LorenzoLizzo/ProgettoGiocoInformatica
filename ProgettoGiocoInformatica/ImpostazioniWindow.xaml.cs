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

namespace ProgettoGiocoInformatica
{
    /// <summary>
    /// Logica di interazione per ImpostazioniWindow.xaml
    /// </summary>
    public partial class ImpostazioniWindow : Window
    {
        public Videogioco Videogioco { get; set; }

        public ImpostazioniWindow(Videogioco v)
        {
            Videogioco = v;

            InitializeComponent();

            //Schermo intero?
            if (v.Impostazioni.SchermoIntero)
            {
                this.WindowState = WindowState.Maximized;
            }

            //Imposta le checkbox
            ckIntero.IsChecked = v.Impostazioni.SchermoIntero;
            ckMusica.IsChecked = v.Impostazioni.Musica;
            ckXfx.IsChecked = v.Impostazioni.EffettiSonori;
        }

        private void ckXfx_Click(object sender, RoutedEventArgs e)
        {
            //Effetti sonori
            Videogioco.Impostazioni.EffettiSonori = (bool)ckXfx.IsChecked;
        }

        private void ckMusica_Click(object sender, RoutedEventArgs e)
        {
            //Musica
            Videogioco.Impostazioni.Musica = (bool)ckMusica.IsChecked;
        }

        private void ckIntero_Click(object sender, RoutedEventArgs e)
        {
            //Schermo intero
            Videogioco.Impostazioni.SchermoIntero = (bool)ckIntero.IsChecked;
        }

        private void btnIndietro_Click(object sender, RoutedEventArgs e)
        {
            Videogioco.SalvaImpostazioni();
            SceltaPersonaggi finestra = new SceltaPersonaggi(Videogioco);
            finestra.Show();
            this.Close();
        }

        
    }
}
