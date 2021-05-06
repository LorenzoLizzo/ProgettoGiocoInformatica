using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace ProgettoGiocoInformatica
{
    public class Impostazioni
    {
        private bool _musica;
        private bool _schermoIntero;
        private bool _effettiSonori;

        public Impostazioni(bool musica, bool schermoIntero, bool effettiSonori)
        {
            Musica = musica;
            SchermoIntero = schermoIntero;
            EffettiSonori = effettiSonori;
        }

        public Impostazioni() 
        {
            
        }

        public bool Musica
        {
            get
            {
                return _musica;
            }
            set
            {
                _musica = value;
            }
        }

        public bool SchermoIntero
        {
            get
            {
                return _schermoIntero;
            }
            set
            {
                _schermoIntero = value;
            }
        }

        public bool EffettiSonori
        {
            get
            {
                return _effettiSonori;
            }
            set
            {
                _effettiSonori = value;
            }
        }

    }
}