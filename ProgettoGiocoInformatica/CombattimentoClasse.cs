﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        Personaggio _vincitore;

        public CombattimentoClasse(Personaggio p1, Personaggio p2, Arma armaP1, Arma armaP2)
        {
            P1 = p1;
            P2 = p2;
            ArmaP1 = armaP1;
            ArmaP2 = armaP2;
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
