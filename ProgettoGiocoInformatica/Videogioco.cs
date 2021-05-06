using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgettoGiocoInformatica
{
    public class Videogioco
    {
        private List<Personaggio> _listaPersognaggi;
        private List<Arma> _listaArma;

        public Videogioco()
        {

        }

        public List<Personaggio> ListaPersognaggi
        {
            get
            {
                return _listaPersognaggi;
            }
            set
            {

            }
        }

        public List<Arma> ListaArma
        {
            get
            {
                return _listaArma;
            }
            set
            {

            }
        }
    }
}