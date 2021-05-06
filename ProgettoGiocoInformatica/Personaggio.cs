using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;

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
        private bool _schiva, _salta, _sinistra, _destra;
        private int _velocitaSalto, _forza, _velocitaPersonaggio;
        private Thickness _posizione;

        public Personaggio(string nome, int puntiVita, string percorsoImmagine, List<Arma> listaArmi, List<Animazione> listaAnimazioni, int puntiForzaBase, bool schiva = false)
        {
            Nome = nome;
            PuntiVita = puntiVita;
            PercorsoImmagine = percorsoImmagine;
            ListaArmi = listaArmi;
            ListaAnimazioni = listaAnimazioni;
            PuntiForzaBase = puntiForzaBase;
            Schiva = false;
            Salta = false;
            Sinistra = false;
            Destra = false;
        }

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
                _nome = value;
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
                _puntiForzaBase = value;
            }
        }

        public bool Schiva
        {
            get
            {
                return _schiva;
            }
            set
            {
                _schiva = value;
            }
        }

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

        private void TastoPremuto(KeyEventArgs eventoTasto)
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
            if (eventoTasto.Key == Key.Down && Schiva == false)
            {
                Schiva = true;
            }
        }

        private void TastoLasciato(KeyEventArgs eventoTasto)
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
            if (Schiva == true)
            {
                Schiva = false;
            }
        }

        public bool Equals(Personaggio other)
        {
            return this.Nome.Equals(other.Nome);
        }

    }
}