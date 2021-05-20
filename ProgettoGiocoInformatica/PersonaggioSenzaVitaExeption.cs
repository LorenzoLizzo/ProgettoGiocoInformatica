using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoGiocoInformatica
{
    class PersonaggioSenzaVitaException : Exception
    {
        public Personaggio Vincitore
        {
            get; private set;
        }

        public PersonaggioSenzaVitaException(Personaggio p) : base()
        {
            Vincitore = p;
        }
    }
}