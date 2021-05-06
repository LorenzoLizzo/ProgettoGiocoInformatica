using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgettoGiocoInformatica
{
    public class Frame
    {
        private string _percorso;
        public Frame(string percorso)
        {
            Percorso = percorso;
        }

        public Frame()
        {

        }

        public string Percorso
        {
            get
            {
                return _percorso;
            }
            set
            {
                _percorso = value;
            }
        }
    }
}