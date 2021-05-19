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
using System.Threading;

namespace ProgettoGiocoInformatica
{
    /// <summary>
    /// Logica di interazione per Combattimento.xaml
    /// </summary>
    public partial class Combattimento : Window
    {
        private CombattimentoClasse ClasseCombattimento { get; set; }
        private Videogioco Videogioco { get; set; }

        Personaggio p1;
        Personaggio p2;

        Rect giocatore1HitBox;
        Rect giocatore2HitBox;

        public Combattimento(CombattimentoClasse cl)
        {
            ClasseCombattimento = cl;
            p1 = cl.P1;
            p2 = cl.P2;

            InitializeComponent();
            ImpostaCombattimento();
            canvasCombattimento.Focus();
        }

        private void ImpostaCombattimento()
        {
            imgPersonaggio1.Source = new BitmapImage(new Uri(p1.PercorsoImmagine, UriKind.Relative));
            imgPersonaggio2.Source = new BitmapImage(new Uri(p2.PercorsoImmagine, UriKind.Relative));

            progressBarP1.Maximum = p1.PuntiVita;
            progressBarP1.Value = progressBarP1.Maximum;

            progressBarP2.Maximum = p2.PuntiVita;
            progressBarP2.Value = progressBarP2.Maximum;

            MovimentoP1();
            MovimentoP2();
        }

        private async void MovimentoP1()
        {
            await Task.Run(() =>
            {
                while (true)
                {
                    this.Dispatcher.BeginInvoke(new Action(() => {
                        if (p1.Sinistra && Canvas.GetLeft(stackPanelP1) > 5)
                        {
                            Canvas.SetLeft(stackPanelP1, Canvas.GetLeft(stackPanelP1) - p1.VelocitaPersonaggio);
                        }
                        if (p1.Destra && Canvas.GetLeft(stackPanelP1) + (stackPanelP1.Width + 20) < Application.Current.MainWindow.Width)
                        {
                            Canvas.SetLeft(stackPanelP1, Canvas.GetLeft(stackPanelP1) + p1.VelocitaPersonaggio);
                        }

                        if (p1.Salta && Canvas.GetTop(stackPanelP1) <= 170 && p1.Gravita > 0)
                        {
                            Canvas.SetTop(stackPanelP1, Canvas.GetTop(stackPanelP1) - p1.VelocitaSalto);

                            p1.Gravita -= 1;
                        }
                        else if (Canvas.GetTop(stackPanelP1) < 170)
                        {
                            Canvas.SetTop(stackPanelP1, Canvas.GetTop(stackPanelP1) + p1.VelocitaSalto);
                        }

                        if (p1.Gravita < 0)
                        {
                            p1.Salta = false;
                        }

                        giocatore1HitBox = new Rect(new Size(imgPersonaggio1.Width, imgPersonaggio1.Height));
                    }));
                    Thread.Sleep(18);
                }

            });
        }

        private async void MovimentoP2()
        {
            await Task.Run(() =>
            {
                while (true)
                {
                    this.Dispatcher.BeginInvoke(new Action(() => {
                        if (p2.Sinistra && Canvas.GetLeft(stackPanelP2) > 5)
                        {
                            Canvas.SetLeft(stackPanelP2, Canvas.GetLeft(stackPanelP2) - p2.VelocitaPersonaggio);
                        }
                        if (p2.Destra && Canvas.GetLeft(stackPanelP2) + (stackPanelP2.Width + 20) < Application.Current.MainWindow.Width)
                        {
                            Canvas.SetLeft(stackPanelP2, Canvas.GetLeft(stackPanelP2) + p2.VelocitaPersonaggio);
                        }
                        if (p2.Salta && Canvas.GetTop(stackPanelP2) <= 170 && p2.Gravita > 0)
                        {
                            Canvas.SetTop(stackPanelP2, Canvas.GetTop(stackPanelP2) - p2.VelocitaSalto);
                            p2.Gravita -= 1;
                        }
                        else if (Canvas.GetTop(stackPanelP2) < 170)
                        {
                            Canvas.SetTop(stackPanelP2, Canvas.GetTop(stackPanelP2) + p2.VelocitaSalto);
                        }
                        if (p2.Gravita < 0)
                        {
                            p2.Salta = false;
                        }
                        giocatore2HitBox = new Rect(new Size(imgPersonaggio2.Width, imgPersonaggio2.Height));
                    }));
                    Thread.Sleep(18);
                }
            });
        }

        private async void AttaccoP1()
        {
            await Task.Run(() =>
            {
                while (true)
                {
                    /*
                    this.Dispatcher.BeginInvoke(new Action(() => {
                       
                    }));
                    */
                    if (p1.Attacca && giocatore1HitBox.IntersectsWith(giocatore2HitBox))
                    {
                        int danno = ClasseCombattimento.AttaccoP1();
                        this.Dispatcher.BeginInvoke(new Action(() => {
                            progressBarP1.Value -= danno;
                        }));
                    }
                    Thread.Sleep(1);
                }

            });
        }

        private async void AttaccoP2()
        {
            await Task.Run(() =>
            {
                while (true)
                {
                    /*
                    this.Dispatcher.BeginInvoke(new Action(() => {
                       
                    }));
                    */
                    if (p2.Attacca && giocatore2HitBox.IntersectsWith(giocatore1HitBox))
                    {
                        int danno = ClasseCombattimento.AttaccoP2();
                        this.Dispatcher.BeginInvoke(new Action(() => {
                            progressBarP2.Value -= danno;
                        }));
                    }
                    Thread.Sleep(1);
                }

            });
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
            if(e.Key == Key.S && !p1.Attacca)
            {
                p1.Attacca = true;
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
            if (e.Key == Key.Down && !p2.Attacca)
            {
                p2.Attacca = true;
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
            if (p1.Attacca)
            {
                p1.Attacca = false;
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
            if (p2.Attacca)
            {
                p2.Attacca = false;
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
