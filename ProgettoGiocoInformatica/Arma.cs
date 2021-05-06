using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EsGioco
{
    public class Arma
    {
        private string _nome;
        private string _percorsoImmagine;
        private int _danno;
        private string _fileAudio;
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

        public int Danno
        {
            get
            {
                return _danno;
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
    }
}