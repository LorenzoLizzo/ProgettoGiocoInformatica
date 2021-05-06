using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EsGioco
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