using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using System.Xml.Serialization;
using System.Windows.Input;
using System.Windows;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ProgettoGiocoInformatica
{
    public class CombattimentoClasse
    {
        Personaggio _p1;
        Personaggio _p2;
        Arma _armaP1;
        Arma _armaP2;
        Personaggio _vincitore;

        public CombattimentoClasse(Personaggio p1, Personaggio p2, Arma armaP1, Arma armaP2)
        {
            P1 = p1;
            P2 = p2;
            ArmaP1 = armaP1;
            ArmaP2 = armaP2;
        }

        public CombattimentoClasse()
        {

        }

        public CombattimentoClasse(Personaggio p1)
        {
            P1 = p1;
        }

        public Personaggio P1
        {
            get
            {
                return _p1;
            }
            set
            {
                _p1 = value;
            }
        }

        public Personaggio P2
        {
            get
            {
                return _p2;
            }
            set
            {
                _p2 = value;
            }
        }

        public Arma ArmaP1
        {
            get
            {
                return _armaP1;
            }
            set
            {
                _armaP1 = value;
            }
        }

        public Arma ArmaP2
        {
            get
            {
                return _armaP2;
            }
            set
            {
                _armaP2 = value;
            }
        }

        public Personaggio Vincitore
        {
            get
            {
                return _vincitore;
            }
            set
            {
                _vincitore = value;
            }
        }


        public void AttacoP1()
        {

        }

        public void AttaccoP2()
        {

        }

        public void MovimentoP1(ref Image immagineP1)
        {
            P1.Posizione = immagineP1.Margin;

            P1.Altezza += P1.VelocitaSalto;

            if (P1.Sinistra)
            {
                double nuovaPosizioneSinistra = P1.Posizione.Left;
                nuovaPosizioneSinistra -= P1.VelocitaPersonaggio;
                P1.Posizione = new Thickness(nuovaPosizioneSinistra, P1.Posizione.Top, P1.Posizione.Right, P1.Posizione.Bottom);
            }
            if (P1.Destra)
            {
                double nuovaPosizioneSinistra = P1.Posizione.Left;
                nuovaPosizioneSinistra += P1.VelocitaPersonaggio;
                P1.Posizione = new Thickness(nuovaPosizioneSinistra, P1.Posizione.Top, P1.Posizione.Right, P1.Posizione.Bottom);
            }
            if (P1.Salta && P1.Forza < 0)
            {
                P1.Salta = false;
            }
            if (P1.Salta)
            {
                TogliVita(P2);
                P1.VelocitaSalto = -8;
                P1.Forza -= 1;
            }
            else
            {
                P1.VelocitaSalto = 10;
            }

            immagineP1.Margin = P1.Posizione;
            /*
            Rect p = new Rect();
            p.Location = immagineP1.PointToScreen(new Point(0, 0));     piattaforme da finire
            p.Height = immagineP1.ActualHeight;
            p.Width = immagineP1.ActualWidth;
            */
        }

        public void MovimentoP2(ref Image immagineP2)
        {
            P2.Posizione = immagineP2.Margin;

            P2.Altezza += P2.VelocitaSalto;

            if (P2.Sinistra)
            {
                double nuovaPosizioneSinistra = P2.Posizione.Left;
                nuovaPosizioneSinistra -= P2.VelocitaPersonaggio;
                P2.Posizione = new Thickness(nuovaPosizioneSinistra, P2.Posizione.Top, P2.Posizione.Right, P2.Posizione.Bottom);
            }
            if (P2.Destra)
            {
                double nuovaPosizioneSinistra = P2.Posizione.Left;
                nuovaPosizioneSinistra += P2.VelocitaPersonaggio;
                P2.Posizione = new Thickness(nuovaPosizioneSinistra, P2.Posizione.Top, P2.Posizione.Right, P2.Posizione.Bottom);
            }
            if (P2.Salta && P2.Forza < 0)
            {
                P2.Salta = false;
            }
            if (P2.Salta)
            {
                P2.VelocitaSalto = -8;
                P2.Forza -= 1;
            }
            else
            {
                P2.VelocitaSalto = 10;
            }

            immagineP2.Margin = P2.Posizione;
        }



        private int CalcolaDanno(Personaggio personaggioCheColpisce)
        {
            int danno;

            if (personaggioCheColpisce.Equals(P1))
            {
                danno = P1.PuntiForzaBase + ArmaP1.Danno;
            }
            else
            {
                danno = P2.PuntiForzaBase + ArmaP2.Danno;
            }

            return danno;
        }

        private void TogliVita(Personaggio personaggioColpito)
        {
            int q;
            if (personaggioColpito.Equals(P1))
            {
                q = CalcolaDanno(P2);
            }
            else
            {
                q = CalcolaDanno(P1);
            }

            if (personaggioColpito.PuntiVita - q <= 0)
            {
                throw new PersonaggioSenzaVitaException(personaggioColpito, q);
            }

            personaggioColpito.PuntiVita -= q;

            if (personaggioColpito.Equals(P1))
            {
                P1.PuntiVita = personaggioColpito.PuntiVita;
            }
            else
            {
                P2.PuntiVita = personaggioColpito.PuntiVita;
            }
        }
    }
}
