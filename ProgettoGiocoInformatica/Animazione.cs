using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgettoGiocoInformatica
{
    public class Animazione
    {
        private string _nome;
        private int _fps;
        private List<Frame> _frame;

        public Animazione()
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

        public int Fps
        {
            get
            {
                return _fps;
            }
            set
            {
                _fps = value;
            }
        }

        public List<Frame> Frame
        {
            get
            {
                return _frame;
            }
            set
            {
            }
        }
    }
}