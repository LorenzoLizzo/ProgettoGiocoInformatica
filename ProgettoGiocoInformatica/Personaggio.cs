using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgettoGiocoInformatica
{
    public class Personaggio : IEquatable<Personaggio>
    {
        private string _nome;
        private int _puntiVita;
        private string _percorsoImmagine;
        private List<Arma> _listaArmi;
        private List<Animazione> _listaAnimazioni;
        private int _puntiForzaBase;

        public Personaggio(string nome, int puntiVita, string percorsoImmagine, int puntiForzaBase)
        {
            Nome = nome;
            PuntiVita = puntiVita;
            PercorsoImmagine = percorsoImmagine;
            PuntiForzaBase = puntiForzaBase;
        }

        public string Nome
        {
            get
            {
                return _nome;
            }
            private set
            {
                _nome = value;
            }
        }

        public string PercorsoImmagine
        {
            get
            {
                return _percorsoImmagine;
            }
            private set
            {
                _percorsoImmagine = value;
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
                _puntiVita = value;
            }
        }

        public List<Arma> ListaArmi
        {
            get
            {
                return _listaArmi;
            }
            private set
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
            private set
            {
                _puntiForzaBase = value;
            }
        }

        public bool Equals(Personaggio other)
        {
            return this.Nome.Equals(other.Nome);
        }

    }
}