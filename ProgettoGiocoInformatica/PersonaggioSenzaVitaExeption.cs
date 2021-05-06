using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoGiocoInformatica
{
    class PersonaggioSenzaVitaException : Exception
    {
        public Personaggio Interessato
        {
            get; private set;
        }

        public int QuantitativoPerso
        {
            get; private set;
        }

        public PersonaggioSenzaVitaException(Personaggio p, int q) : base()
        {
            Interessato = p;
            QuantitativoPerso = q;
        }
    }
}