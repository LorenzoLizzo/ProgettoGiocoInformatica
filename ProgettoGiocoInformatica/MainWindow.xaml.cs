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
using System.Threading;
using System.IO;
using System.Diagnostics;

namespace ProgettoGiocoInformatica
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Videogioco Videogioco { get; set; }

        private Thread t1;

        public MainWindow()
        {
            InitializeComponent();

            btnGioca.Visibility = Visibility.Hidden;

            //Thread caricamento
            t1 = new Thread(new ThreadStart(Caricamento));
            t1.Start();
        }

        private void Caricamento()
        {
            string[] arr = File.ReadAllLines("frasi.txt");
            double toAdd = 1;

            Dispatcher.BeginInvoke((Action)(() =>
            {
                progressBar.Maximum = arr.Length;
            }));

            try
            {
                Videogioco = new Videogioco();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Debug.WriteLine(ex);
            }

            //Schermo intero?
            if (Videogioco.Impostazioni.SchermoIntero)
            {
                this.WindowState = WindowState.Maximized;
            }

            foreach (string s in arr)
            {
                Dispatcher.BeginInvoke((Action)(() =>
                {
                    lbl.Content = "Caricamento di: " + s;
                    progressBar.Value += toAdd;
                }));

                Thread.Sleep(1000);
            }
        }

        private void progress_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (progressBar.Value == progressBar.Maximum)
            {
                btnGioca.Visibility = Visibility.Visible;
            }
        }

        private void btnGioca_Click(object sender, RoutedEventArgs e)
        {
            SceltaPersonaggi finestra = new SceltaPersonaggi(Videogioco);
            finestra.Show();
            this.Close();
        }
    }
}
