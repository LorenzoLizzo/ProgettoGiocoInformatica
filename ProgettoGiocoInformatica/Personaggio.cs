using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;
using System.Xml.Serialization;

namespace ProgettoGiocoInformatica
{
    [XmlRoot(ElementName = "Personaggio")]
    public class Personaggio : IEquatable<Personaggio>
    {
        private string _nome;
        private int _puntiVita;
        private string _percorsoImmagine;
        private List<Arma> _listaArmi;
        private List<Animazione> _listaAnimazioni;
        private int _puntiForzaBase;
        private bool _salta, _sinistra, _destra;
        private int _velocitaSalto, _forza, _velocitaPersonaggio, _altezza;
        private Thickness _posizione;

        public Personaggio(string nome, int puntiVita, string percorsoImmagine, List<Arma> listaArmi, List<Animazione> listaAnimazioni, int puntiForzaBase)
        {
            Nome = nome;
            PuntiVita = puntiVita;
            PercorsoImmagine = percorsoImmagine;
            ListaArmi = listaArmi;
            ListaAnimazioni = listaAnimazioni;
            PuntiForzaBase = puntiForzaBase;
            Salta = false;
            Sinistra = false;
            Destra = false;
        }

        public Personaggio()
        {

        }

        [XmlElement(ElementName = "Nome")]
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }

        [XmlElement(ElementName = "PercorsoImmagine")]
        public string PercorsoImmagine
        {
            get
            {
                return _percorsoImmagine;
            }
            set
            {
                _percorsoImmagine = value;
            }
        }

        [XmlElement(ElementName = "PuntiVita")]
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

        [XmlElement(ElementName = "ListaArmi")]
        public List<Arma> ListaArmi
        {
            get
            {
                return _listaArmi;
            }
            set
            {

            }
        }

        [XmlElement(ElementName = "ListaAnimazioni")]
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

        [XmlElement(ElementName = "PuntiForzaBase")]
        public int PuntiForzaBase
        {
            get
            {
                return _puntiForzaBase;
            }
            set
            {
                _puntiForzaBase = value;
            }
        }

        [XmlIgnore]
        public bool Salta
        {
            get
            {
                return _salta;
            }
            set
            {
                _salta = value;
            }
        }

        [XmlIgnore]
        public bool Sinistra
        {
            get
            {
                return _sinistra;
            }
            set
            {
                _sinistra = value;
            }
        }

        [XmlIgnore]
        public bool Destra
        {
            get
            {
                return _destra;
            }
            set
            {
                _destra = value;
            }
        }

        [XmlIgnore]
        public int VelocitaSalto
        {
            get
            {
                return _velocitaSalto;
            }
            set
            {
                _velocitaSalto = value;
            }
        }

        [XmlIgnore]
        public int Forza
        {
            get
            {
                return _forza;
            }
            set
            {
                _forza = value;
            }
        }

        [XmlIgnore]
        public int VelocitaPersonaggio
        {
            get
            {
                return _velocitaPersonaggio;
            }
            set
            {
                _velocitaPersonaggio = value;
            }
        }

        [XmlIgnore]
        public int Altezza
        {
            get
            {
                return _altezza;
            }
            set
            {
                _altezza = value;
            }
        }

        public Thickness Posizione
        {
            get
            {
                return _posizione;
            }
            set
            {
                _posizione = value;
            }
        }

        public void Movimento()
        {
            if (Sinistra)
            {
                double nuovaPosizioneSinistra = Posizione.Left;
                nuovaPosizioneSinistra -= VelocitaPersonaggio;
                Posizione = new Thickness(nuovaPosizioneSinistra, Posizione.Top, Posizione.Right, Posizione.Bottom);
            }
            if (Destra)
            {
                double nuovaPosizioneSinistra = Posizione.Left;
                nuovaPosizioneSinistra += VelocitaPersonaggio;
                Posizione = new Thickness(nuovaPosizioneSinistra, Posizione.Top, Posizione.Right, Posizione.Bottom);
            }
            if (Salta && Forza < 0)
            {
                Salta = false;
            }
            if (Salta)
            {
                VelocitaSalto = -8;
                Forza -= 1;
            }
            else
            {
                VelocitaSalto = 10;
            }


        }

        public void TastoPremuto(KeyEventArgs eventoTasto)
        {
            if (eventoTasto.Key == Key.Left)
            {
                Sinistra = true;
            }
            if (eventoTasto.Key == Key.Right)
            {
                Destra = true;
            }
            if (eventoTasto.Key == Key.Up && Salta == false)
            {
                Salta = true;
            }
        }

        public void TastoLasciato(KeyEventArgs eventoTasto)
        {
            if (eventoTasto.Key == Key.Left)
            {
                Sinistra = false;
            }
            if (eventoTasto.Key == Key.Right)
            {
                Destra = false;
            }
            if (Salta == true)
            {
                Salta = false;
            }
        }

        public bool Equals(Personaggio other)
        {
            return this.Nome.Equals(other.Nome);
        }

    }
}