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
        
        Rect giocatore1HitBox;
        Rect giocatore2HitBox;

        public Combattimento(CombattimentoClasse cl)
        {
            ClasseCombattimento = cl;

            InitializeComponent();
            ImpostaCombattimento();
            canvasCombattimento.Focus();
        }

        private void ImpostaCombattimento()
        {
            imgPersonaggio1.Source = new BitmapImage(new Uri(ClasseCombattimento.P1.PercorsoImmagine, UriKind.Relative));
            imgPersonaggio2.Source = new BitmapImage(new Uri(ClasseCombattimento.P2.PercorsoImmagine, UriKind.Relative));

            progressBarP1.Maximum = ClasseCombattimento.P1.PuntiVita;
            progressBarP1.Value = ClasseCombattimento.P1.PuntiVita;

            progressBarP2.Maximum = ClasseCombattimento.P2.PuntiVita;
            progressBarP2.Value = ClasseCombattimento.P2.PuntiVita;

            MovimentoP1();
            MovimentoP2();
            AttaccoP1();
            AttaccoP2();
        }

        private void PartitaFinita(string nomeVincitore)
        {
            canvasCombattimento.Focusable = false;
            lblVincitore.Visibility = Visibility.Visible;
            BtnGiocaAncora.Visibility = Visibility.Visible;
            BtnHome.Visibility = Visibility.Visible;
            lblVincitore.Content = $"Il vincitore è: {nomeVincitore}";
        }

        private async void MovimentoP1()
        {
            await Task.Run(() =>
            {
                while (!ClasseCombattimento.CombattimentoConcluso)
                {
                    this.Dispatcher.BeginInvoke(new Action(() => {
                        if (ClasseCombattimento.P1.Sinistra && Canvas.GetLeft(stackPanelP1) > 5)
                        {
                            Canvas.SetLeft(stackPanelP1, Canvas.GetLeft(stackPanelP1) - ClasseCombattimento.P1.VelocitaPersonaggio);
                        }
                        if (ClasseCombattimento.P1.Destra && Canvas.GetLeft(stackPanelP1) + (stackPanelP1.Width + 20) < Application.Current.MainWindow.Width)
                        {
                            Canvas.SetLeft(stackPanelP1, Canvas.GetLeft(stackPanelP1) + ClasseCombattimento.P1.VelocitaPersonaggio);
                        }

                        if (ClasseCombattimento.P1.Salta && Canvas.GetTop(stackPanelP1) <= 170 && ClasseCombattimento.P1.Gravita > 0)
                        {
                            Canvas.SetTop(stackPanelP1, Canvas.GetTop(stackPanelP1) - ClasseCombattimento.P1.VelocitaSalto);

                            ClasseCombattimento.P1.Gravita -= 1;
                        }
                        else if (Canvas.GetTop(stackPanelP1) < 170)
                        {
                            Canvas.SetTop(stackPanelP1, Canvas.GetTop(stackPanelP1) + ClasseCombattimento.P1.VelocitaSalto);
                        }

                        if (ClasseCombattimento.P1.Gravita < 0)
                        {
                            ClasseCombattimento.P1.Salta = false;
                        }

                        giocatore1HitBox = new Rect(Canvas.GetLeft(stackPanelP1), Canvas.GetTop(stackPanelP1), stackPanelP1.Width, stackPanelP1.Height);
                    }));
                    Thread.Sleep(18);
                }

            });
        }

        private async void MovimentoP2()
        {
            await Task.Run(() =>
            {
                while (!ClasseCombattimento.CombattimentoConcluso)
                {
                    this.Dispatcher.BeginInvoke(new Action(() => {
                        if (ClasseCombattimento.P2.Sinistra && Canvas.GetLeft(stackPanelP2) > 5)
                        {
                            Canvas.SetLeft(stackPanelP2, Canvas.GetLeft(stackPanelP2) - ClasseCombattimento.P2.VelocitaPersonaggio);
                        }
                        if (ClasseCombattimento.P2.Destra && Canvas.GetLeft(stackPanelP2) + (stackPanelP2.Width + 20) < Application.Current.MainWindow.Width)
                        {
                            Canvas.SetLeft(stackPanelP2, Canvas.GetLeft(stackPanelP2) + ClasseCombattimento.P2.VelocitaPersonaggio);
                        }
                        if (ClasseCombattimento.P2.Salta && Canvas.GetTop(stackPanelP2) <= 170 && ClasseCombattimento.P2.Gravita > 0)
                        {
                            Canvas.SetTop(stackPanelP2, Canvas.GetTop(stackPanelP2) - ClasseCombattimento.P2.VelocitaSalto);
                            ClasseCombattimento.P2.Gravita -= 1;
                        }
                        else if (Canvas.GetTop(stackPanelP2) < 170)
                        {
                            Canvas.SetTop(stackPanelP2, Canvas.GetTop(stackPanelP2) + ClasseCombattimento.P2.VelocitaSalto);
                        }
                        if (ClasseCombattimento.P2.Gravita < 0)
                        {
                            ClasseCombattimento.P2.Salta = false;
                        }
                        giocatore2HitBox = new Rect(Canvas.GetLeft(stackPanelP2), Canvas.GetTop(stackPanelP2), stackPanelP2.Width, stackPanelP2.Height);
                    }));
                    Thread.Sleep(18);
                }
            });
        }

        private async void AttaccoP1()
        {
            await Task.Run(() =>
            {
                try
                {
                    while (!ClasseCombattimento.CombattimentoConcluso)
                    {
                        double posp1Left = giocatore1HitBox.Left;
                        double posp1Top = giocatore1HitBox.Top;

                        double posp2Left = giocatore2HitBox.Left;
                        double posp2Top = giocatore2HitBox.Top;
                        
                        if (ClasseCombattimento.P1.Attacca && Math.Abs(posp2Left - posp1Left) < 30 && Math.Abs(posp1Top - posp2Top) < 10)
                        {
                            int danno = ClasseCombattimento.AttaccoP1();
                            
                            this.Dispatcher.BeginInvoke(new Action(() =>
                            {
                                 progressBarP2.Value -= danno;
                            }));
                            
                            ClasseCombattimento.P1.Attacca = false;
                        }
                        Thread.Sleep(1);
                    }
                }
                catch(PersonaggioSenzaVitaException ex)
                {
                    this.Dispatcher.BeginInvoke(new Action(() =>
                    {
                        progressBarP2.Value = 0;
                        PartitaFinita(ex.Vincitore.Nome);
                    }));
                }
            });
        }

        private async void AttaccoP2()
        {
            await Task.Run(() =>
            {
                try
                {
                    while (!ClasseCombattimento.CombattimentoConcluso)
                    {
                        double posp1Left = giocatore1HitBox.Left;
                        double posp1Top = giocatore1HitBox.Top;

                        double posp2Left = giocatore2HitBox.Left;
                        double posp2Top = giocatore2HitBox.Top;

                        if (ClasseCombattimento.P2.Attacca && Math.Abs(posp2Left - posp1Left) < 30 && Math.Abs(posp1Top - posp2Top) < 10)
                        {
                            int danno = ClasseCombattimento.AttaccoP2();

                            this.Dispatcher.BeginInvoke(new Action(() =>
                            {
                                progressBarP1.Value -= danno;
                            }));

                            ClasseCombattimento.P2.Attacca = false;
                        }
                        Thread.Sleep(1);
                    }
                }
                catch (PersonaggioSenzaVitaException ex)
                {
                    this.Dispatcher.BeginInvoke(new Action(() =>
                    {
                        progressBarP1.Value = 0;
                        PartitaFinita(ex.Vincitore.Nome);
                    }));
                }
            });
        }

        private void TastoPremuto(object sender, KeyEventArgs e)
        {
            //tasti p1
            if (e.Key == Key.A)
            {
                ClasseCombattimento.P1.Sinistra = true;
            }
            if (e.Key == Key.D)
            {
                ClasseCombattimento.P1.Destra = true;
            }
            if (e.Key == Key.W && !ClasseCombattimento.P1.Salta)
            {
                ClasseCombattimento.P1.Salta = true;
            }
            if(e.Key == Key.S && !ClasseCombattimento.P1.Attacca)
            {
                ClasseCombattimento.P1.Attacca = true;
            }
            //tasti p2
            if (e.Key == Key.Left)
            {
                ClasseCombattimento.P2.Sinistra = true;
            }
            if (e.Key == Key.Right)
            {
                ClasseCombattimento.P2.Destra = true;
            }
            if (e.Key == Key.Up && !ClasseCombattimento.P2.Salta)
            {
                ClasseCombattimento.P2.Salta = true;
            }
            if (e.Key == Key.Down && !ClasseCombattimento.P2.Attacca)
            {
                ClasseCombattimento.P2.Attacca = true;
            }
        }

        private void TastoLasciato(object sender, KeyEventArgs e)
        {
            //tasti p1
            if (e.Key == Key.A)
            {
                ClasseCombattimento.P1.Sinistra = false;
            }
            if (e.Key == Key.D)
            {
                ClasseCombattimento.P1.Destra = false;
            }
            if (ClasseCombattimento.P1.Salta)
            {
                ClasseCombattimento.P1.Salta = false;
                ClasseCombattimento.P1.Gravita = 10;
            }
            if (ClasseCombattimento.P1.Attacca)
            {
                ClasseCombattimento.P1.Attacca = false;
            }
            //tasti p2
            if (e.Key == Key.Left)
            {
                ClasseCombattimento.P2.Sinistra = false;
            }
            if (e.Key == Key.Right)
            {
                ClasseCombattimento.P2.Destra = false;
            }
            if (ClasseCombattimento.P2.Salta)
            {
                ClasseCombattimento.P2.Salta = false;
                ClasseCombattimento.P2.Gravita = 10;
            }
            if (ClasseCombattimento.P2.Attacca)
            {
                ClasseCombattimento.P2.Attacca = false;
            }
        }

        private void BtnHome_Click(object sender, RoutedEventArgs e)
        {
            SceltaPersonaggi finestra = new SceltaPersonaggi(new Videogioco());
            finestra.Show();
            this.Close();
        }

        private void BtnGiocaAncora_Click(object sender, RoutedEventArgs e)
        {
            Combattimento finestra = new Combattimento(ResetParita());
            finestra.Show();
            this.Close();
        }

        private CombattimentoClasse ResetParita()
        {
            CombattimentoClasse cl = new CombattimentoClasse(ClasseCombattimento.P1, ClasseCombattimento.P2, ClasseCombattimento.ArmaP1, ClasseCombattimento.ArmaP2);
            cl.P1.PuntiVita = int.Parse(progressBarP1.Maximum.ToString());
            cl.P2.PuntiVita = int.Parse(progressBarP2.Maximum.ToString());
            cl.P1.Sinistra = false;
            cl.P2.Sinistra = false;
            cl.P1.Destra = false;
            cl.P2.Destra = false;
            cl.P1.Salta = false;
            cl.P2.Salta = false;
            cl.P1.Attacca = false;
            cl.P2.Attacca = false;
            cl.P1.Gravita = 10;
            cl.P2.Gravita = 10;

            return cl;
        }
    }
}
