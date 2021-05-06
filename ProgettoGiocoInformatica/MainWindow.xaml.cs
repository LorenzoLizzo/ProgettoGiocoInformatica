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

namespace ProgettoGiocoInformatica
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Videogioco Videogioco { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGioca_Click(object sender, RoutedEventArgs e)
        {
            SceltaPersonaggi finestra = new SceltaPersonaggi(Videogioco);
            finestra.Show();
            this.Close();
        }
    }
}
