using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Windows;
using System.Windows.Controls;

namespace ProgettoGiocoInformatica
{
    public class CombattimentoClasse
    {
        Personaggio _p1;
        Personaggio _p2;
        Arma _armaP1;
        Arma _armaP2;
        private bool _combattimentoConcluso;

        public CombattimentoClasse(Personaggio p1, Personaggio p2, Arma armaP1, Arma armaP2)
        {
            P1 = p1;
            P2 = p2;
            ArmaP1 = armaP1;
            ArmaP2 = armaP2;
            CombattimentoConcluso = false;
        }

        public Personaggio P1
        {
            get
            {
                return _p1;
            }
            private set
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
            private set
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
            private set
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
            private set
            {
                _armaP2 = value;
            }
        }

        public bool CombattimentoConcluso
        {
            get
            {
                return _combattimentoConcluso;
            }
            private set
            {
                _combattimentoConcluso = value;
            }
        }

        public int AttaccoP1()
        {
            TogliVita(P2);
            return CalcolaDanno(P1);
        }

        public int AttaccoP2()
        {
            TogliVita(P1);
            return CalcolaDanno(P2);
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
            int q = 0;
            if (personaggioColpito.Equals(P1))
            {
                q = CalcolaDanno(P2);
            }
            else
            {
                q = CalcolaDanno(P1);
            }

            personaggioColpito.PuntiVita -= q;

            if (personaggioColpito.PuntiVita <= 0)
            {
                personaggioColpito.PuntiVita = 0;
                CombattimentoConcluso = true;
                if (personaggioColpito.Equals(P1))
                {
                    throw new PersonaggioSenzaVitaException(P2);
                }
                else
                {
                    throw new PersonaggioSenzaVitaException(P1);
                }
               
            }
        }
    }
}
