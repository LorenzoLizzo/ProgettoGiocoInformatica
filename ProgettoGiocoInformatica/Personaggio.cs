using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgettoGiocoInformatica
{
    public class Personaggio
    {
        private string _nome;
        private int _puntiVita;
        private string _percorsoImmagine;
        private List<Arma> _listaArmi;
        private List<Animazione> _listaAnimazioni;
        private int _puntiForzaBase;

        public Personaggio()
        {

        }

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
            }
        }

        public string PercorsoImmagine
        {
            get
            {
                return _percorsoImmagine;
            }
            set
            {
            }
        }

        public int PuntiVita
        {
            get
            {
                return _puntiVita;
            }
            set
            {
            }
        }

        public List<Arma> ListaArmiAstratte
        {
            get
            {
                return _listaArmi;
            }
            set
            {
            }
        }

        public List<Animazione> ListaAnimazioni
        {
            get
            {
                return _listaAnimazioni;
            }
            set
            {
            }
        }


        public int PuntiForzaBase
        {
            get
            {
                return _puntiForzaBase;
            }
            set
            {
            }
        }

    }
}