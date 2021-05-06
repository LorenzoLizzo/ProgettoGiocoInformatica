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
        private Videogioco Videogioco { get; set; }

        DispatcherTimer timerP1;
        DispatcherTimer timerP2;
        Personaggio p1;
        Personaggio p2;

        Rect giocatore1HitBox;
        Rect giocatore2HitBox;

        public Combattimento(CombattimentoClasse cl)
        {
            ClasseCombattimento = cl;

            InitializeComponent();
            canvasCombattimento.Focus();
            p1 = new Personaggio();
            p2 = new Personaggio();
            SetImpostazioniP1();
            SetImpostazioniP2();
        }

        public Combattimento()
        {

        }

        private void SetImpostazioniP1()
        {
            timerP1 = new DispatcherTimer();
            timerP1.Tick += new EventHandler(MetodoTimerP1);
            timerP1.Interval = TimeSpan.FromMilliseconds(10);
            timerP1.Start();
        }

        private void SetImpostazioniP2()
        {
            timerP2 = new DispatcherTimer();
            timerP2.Tick += new EventHandler(MetodoTimerP2);
            timerP2.Interval = TimeSpan.FromMilliseconds(10);
            timerP2.Start();
        }

        private void MetodoTimerP1(object sender, EventArgs e)
        {
            /*
            await Task.Run(() =>
            {
                
                this.Dispatcher.BeginInvoke(new Action(() => {
                    giocatore1HitBox = new Rect(Canvas.GetLeft(imgPersonaggio1), Canvas.GetTop(imgPersonaggio1), imgPersonaggio1.Width - 15, imgPersonaggio1.Height);
                    if (p1.Sinistra && Canvas.GetLeft(imgPersonaggio1) > 5)
                    {
                        Canvas.SetLeft(imgPersonaggio1, Canvas.GetLeft(imgPersonaggio1) - p1.VelocitaPersonaggio);
                    }
                    if (p1.Destra && Canvas.GetLeft(imgPersonaggio1) + (imgPersonaggio1.Width + 20) < Application.Current.MainWindow.Width)
                    {
                        Canvas.SetLeft(imgPersonaggio1, Canvas.GetLeft(imgPersonaggio1) + p1.VelocitaPersonaggio);
                    }
                    if (p1.Salta && Canvas.GetTop(imgPersonaggio1) <= 200 && p1.Gravita > 0)
                    {
                        Canvas.SetTop(imgPersonaggio1, Canvas.GetTop(imgPersonaggio1) - p1.VelocitaSalto);
                        p1.Gravita -= 1;
                    }
                    else if (Canvas.GetTop(imgPersonaggio1) < 200)
                    {
                        Canvas.SetTop(imgPersonaggio1, Canvas.GetTop(imgPersonaggio1) + p1.VelocitaSalto);
                    }
                }));
                */
            giocatore1HitBox = new Rect(Canvas.GetLeft(imgPersonaggio1), Canvas.GetTop(imgPersonaggio1), imgPersonaggio1.Width - 15, imgPersonaggio1.Height);

            if (p1.Sinistra && Canvas.GetLeft(imgPersonaggio1) > 5)
            {
                Canvas.SetLeft(imgPersonaggio1, Canvas.GetLeft(imgPersonaggio1) - p1.VelocitaPersonaggio);
            }
            if (p1.Destra && Canvas.GetLeft(imgPersonaggio1) + (imgPersonaggio1.Width + 20) < Application.Current.MainWindow.Width)
            {
                Canvas.SetLeft(imgPersonaggio1, Canvas.GetLeft(imgPersonaggio1) + p1.VelocitaPersonaggio);
            }

            if (p1.Salta && Canvas.GetTop(imgPersonaggio1) <= 200 && p1.Gravita > 0)
            {
                Canvas.SetTop(imgPersonaggio1, Canvas.GetTop(imgPersonaggio1) - p1.VelocitaSalto);

                p1.Gravita -= 1;
            }
            else if (Canvas.GetTop(imgPersonaggio1) < 200)
            {
                Canvas.SetTop(imgPersonaggio1, Canvas.GetTop(imgPersonaggio1) + p1.VelocitaSalto);
            }

            if (p1.Gravita < 0)
            {
                p1.Salta = false;
            }
            //  });

        }

        private void MetodoTimerP2(object sender, EventArgs e)
        {
            /*
            await Task.Run(() =>
            {
                Canvas.SetLeft(imgPersonaggio1, Canvas.GetLeft(imgPersonaggio1) - velocitaGiocatore);
                this.Dispatcher.BeginInvoke(new Action(() => {
                    giocatore2HitBox = new Rect(Canvas.GetLeft(imgPersonaggio2), Canvas.GetTop(imgPersonaggio2), imgPersonaggio2.Width - 15, imgPersonaggio2.Height);
                    if (p2.Sinistra && Canvas.GetLeft(imgPersonaggio2) > 5)
                    {
                        Canvas.SetLeft(imgPersonaggio2, Canvas.GetLeft(imgPersonaggio2) - p2.VelocitaPersonaggio);
                    }
                    if (p2.Destra && Canvas.GetLeft(imgPersonaggio2) + (imgPersonaggio2.Width + 20) < Application.Current.MainWindow.Width)
                    {
                        Canvas.SetLeft(imgPersonaggio2, Canvas.GetLeft(imgPersonaggio2) + p2.VelocitaPersonaggio);
                    }
                    if (p2.Salta && Canvas.GetTop(imgPersonaggio2) <= 200 && p2.Gravita > 0)
                    {
                        Canvas.SetTop(imgPersonaggio2, Canvas.GetTop(imgPersonaggio2) - p2.VelocitaSalto);
                        p2.Gravita -= 1;
                    }
                    else if (Canvas.GetTop(imgPersonaggio2) < 200)
                    {
                        Canvas.SetTop(imgPersonaggio2, Canvas.GetTop(imgPersonaggio2) + p2.VelocitaSalto);
                    }
                }));
                */

            giocatore2HitBox = new Rect(Canvas.GetLeft(imgPersonaggio2), Canvas.GetTop(imgPersonaggio2), imgPersonaggio2.Width - 15, imgPersonaggio2.Height);

            if (p2.Sinistra && Canvas.GetLeft(imgPersonaggio2) > 5)
            {
                Canvas.SetLeft(imgPersonaggio2, Canvas.GetLeft(imgPersonaggio2) - p2.VelocitaPersonaggio);
            }
            if (p2.Destra && Canvas.GetLeft(imgPersonaggio2) + (imgPersonaggio2.Width + 20) < Application.Current.MainWindow.Width)
            {
                Canvas.SetLeft(imgPersonaggio2, Canvas.GetLeft(imgPersonaggio2) + p2.VelocitaPersonaggio);
            }
            if (p2.Salta && Canvas.GetTop(imgPersonaggio2) <= 200 && p2.Gravita > 0)
            {
                Canvas.SetTop(imgPersonaggio2, Canvas.GetTop(imgPersonaggio2) - p2.VelocitaSalto);
                p2.Gravita -= 1;
            }
            else if (Canvas.GetTop(imgPersonaggio2) < 200)
            {
                Canvas.SetTop(imgPersonaggio2, Canvas.GetTop(imgPersonaggio2) + p2.VelocitaSalto);
            }
            if (p2.Gravita < 0)
            {
                p2.Salta = false;
            }
            // });
        }

        private void TastoPremuto(object sender, KeyEventArgs e)
        {
            //tasti p1
            if (e.Key == Key.A)
            {
                p1.Sinistra = true;
            }
            if (e.Key == Key.D)
            {
                p1.Destra = true;
            }
            if (e.Key == Key.W && !p1.Salta)
            {
                p1.Salta = true;
            }
            //tasti p2
            if (e.Key == Key.Left)
            {
                p2.Sinistra = true;
            }
            if (e.Key == Key.Right)
            {
                p2.Destra = true;
            }
            if (e.Key == Key.Up && !p2.Salta)
            {
                p2.Salta = true;
            }
        }

        private void TastoLasciato(object sender, KeyEventArgs e)
        {
            //tasti p1
            if (e.Key == Key.A)
            {
                p1.Sinistra = false;
            }
            if (e.Key == Key.D)
            {
                p1.Destra = false;
            }
            if (p1.Salta)
            {
                p1.Salta = false;
                p1.Gravita = 10;
            }
            //tasti p2
            if (e.Key == Key.Left)
            {
                p2.Sinistra = false;
            }
            if (e.Key == Key.Right)
            {
                p2.Destra = false;
            }
            if (p2.Salta)
            {
                p2.Salta = false;
                p2.Gravita = 10;
            }
        }

        private void BtnHome_Click(object sender, RoutedEventArgs e)
        {
            MainWindow finestra = new MainWindow();
            finestra.Show();
            this.Close();
        }

        private void BtnGiocaAncora_Click(object sender, RoutedEventArgs e)
        {
            SceltaPersonaggi finestra = new SceltaPersonaggi(Videogioco);
            finestra.Show();
            this.Close();
        }
    }
}
