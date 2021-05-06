using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace ProgettoGiocoInformatica
{
    public class Arma
    {
        private string _nome;
        private string _percorsoImmagine;
        private int _danno;
        public Arma(string nome, string percorsoImmagine, int danno)
        {
            Nome = nome;
            PercorsoImmagine = percorsoImmagine;
            Danno = danno;
        }

        public Arma()
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

        public int Danno
        {
            get
            {
                return _danno;
            }
            set
            {
                _danno = value;
            }
        }

    }
}