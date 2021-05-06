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
        private string _comeSiGioca;

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
            }
        }

        public string ComeSiGioca
        {
            get
            {
                return _comeSiGioca;
            }
            set
            {
            }
        }
    }
}