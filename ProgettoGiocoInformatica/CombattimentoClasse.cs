using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoGiocoInformatica
{
    class CombattimentoClasse
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


        public void AttaccoP1()
        {
            
        }

        public void AttaccoP2()
        {
            
        }

        public void SchivaP1()
        {
            
        }

        public void SchivaP2()
        {
            
        }

        public void TogliVita(ref Personaggio p, int q)
        {
            if (p.PuntiVita - q <= 0)
            {
                throw new PersonaggioSenzaVitaException(p, q);
            }

            p.PuntiVita -= q;
        }

        private Personaggio Perdente()
        {
            if (Vincitore.Equals(P1))
            {
                return P2;
            }
            else if (Vincitore.Equals(P2))
            {
                return P1;
            }
            else
            {
                throw new Exception("Errore");
            }
        }
    }
}
