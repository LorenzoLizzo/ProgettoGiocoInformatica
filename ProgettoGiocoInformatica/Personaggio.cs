using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EsGioco
{
    public class Personaggio
    {
        private string _nome;
        private int _puntiVita;
        private string _percorsoImmagine;
        private List<ArmaEstratta> _listaArmiAstratte;
        private List<Animazione> _listaAnimazioni;
        private string _fileAudio;
        private int _puntiForzaBase;
        private Arma _armaSelezionata;

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

        public List<ArmaEstratta> ListaArmiAstratte
        {
            get
            {
                return _listaArmiAstratte;
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

        public string FileAudio
        {
            get
            {
                return _fileAudio;
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

        public Arma ArmaSelezionata
        {
            get
            {
                return _armaSelezionata;
            }
            set
            {
            }
        }
    }
}