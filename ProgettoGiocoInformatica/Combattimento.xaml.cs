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
using System.Windows.Threading;

namespace ProgettoGiocoInformatica
{
    /// <summary>
    /// Logica di interazione per Combattimento.xaml
    /// </summary>
    public partial class Combattimento : Window
    {
        private CombattimentoClasse ClasseCombattimento { get; set; }

        DispatcherTimer timer;
        CombattimentoClasse gioco;
        Personaggio p1;

        public Combattimento(CombattimentoClasse cl)
        {
            ClasseCombattimento = cl;

            InitializeComponent();
        }

        bool sinistra, destra, salta;
        int velocitaGiocatore = 8;
        int gravita = 10;
        int velocitaSalto = 8;

        Rect giocatore1HitBox;

        public Combattimento()
        {
            InitializeComponent();

            canvasCombattimento.Focus();

            timer = new DispatcherTimer();
            timer.Tick += MetodoTimer;
            timer.Interval = TimeSpan.FromMilliseconds(10);
            salta = false;
            sinistra = false;
            destra = false;
            timer.Start();
        }

        private void MetodoTimer(object sender, EventArgs e)
        {
            giocatore1HitBox = new Rect(Canvas.GetLeft(imgPersonaggio1), Canvas.GetTop(imgPersonaggio1), imgPersonaggio1.Width - 15, imgPersonaggio1.Height);

            if (sinistra && Canvas.GetLeft(imgPersonaggio1) > 5)
            {
                Canvas.SetLeft(imgPersonaggio1, Canvas.GetLeft(imgPersonaggio1) - velocitaGiocatore);
            }
            if (destra && Canvas.GetLeft(imgPersonaggio1) + (imgPersonaggio1.Width + 20) < Application.Current.MainWindow.Width)
            {
                Canvas.SetLeft(imgPersonaggio1, Canvas.GetLeft(imgPersonaggio1) + velocitaGiocatore);
            }

            if (salta && Canvas.GetTop(imgPersonaggio1) <= 200 && gravita > 0)
            {
                Canvas.SetTop(imgPersonaggio1, Canvas.GetTop(imgPersonaggio1) - velocitaSalto);

                gravita -= 1;
            }
            else if (Canvas.GetTop(imgPersonaggio1) < 200)
            {
                Canvas.SetTop(imgPersonaggio1, Canvas.GetTop(imgPersonaggio1) + velocitaSalto);
            }

            if (gravita < 0)
            {
                salta = false;
            }
        }

        private void prova(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left)
            {
                sinistra = true;
            }
            if (e.Key == Key.Right)
            {
                destra = true;
            }
            if (e.Key == Key.Up && !salta)
            {
                salta = true;
            }
        }

        private void prova2(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left)
            {
                sinistra = false;
            }
            if (e.Key == Key.Right)
            {
                destra = false;
            }
            if (salta)
            {
                salta = false;
                gravita = 10;
            }
        }
    }
}
