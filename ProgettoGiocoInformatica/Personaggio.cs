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
        private List<Animazione> _listaAnimazioni;
        private int _puntiForzaBase;
        private bool _salta, _sinistra, _destra;
        private int _velocitaSalto, _gravita, _velocitaPersonaggio;

        public Personaggio(string nome, int puntiVita, string percorsoImmagine, List<Animazione> listaAnimazioni, int puntiForzaBase)
        {
            Nome = nome;
            PuntiVita = puntiVita;
            PercorsoImmagine = percorsoImmagine;
            ListaAnimazioni = listaAnimazioni;
            PuntiForzaBase = puntiForzaBase;
            Salta = false;
            Sinistra = false;
            Destra = false;
        }

        public Personaggio()
        {
            VelocitaSalto = 8;
            Gravita = 10;
            VelocitaPersonaggio = 8;

            Salta = false;
            Sinistra = false;
            Destra = false;
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
        public int Gravita
        {
            get
            {
                return _gravita;
            }
            set
            {
                _gravita = value;
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

        public bool Equals(Personaggio other)
        {
            return this.Nome.Equals(other.Nome);
        }

    }
}