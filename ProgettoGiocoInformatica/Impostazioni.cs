using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgettoGiocoInformatica
{
    public class Impostazioni
    {
        private bool _musica;
        private bool _schermoIntero;
        private bool _effettiSonori;
        private bool _comeSiGioca;

        public Impostazioni(bool musica, bool schermoIntero, bool effettiSonori, bool comeSiGioca)
        {
            Musica = musica;
            SchermoIntero = schermoIntero;
            EffettiSonori = effettiSonori;
            ComeSiGioca = comeSiGioca;
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

        public bool ComeSiGioca
        {
            get
            {
                return _comeSiGioca;
            }
            set
            {
                _comeSiGioca = value;
            }
        }
    }
}