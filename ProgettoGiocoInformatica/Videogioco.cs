using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace ProgettoGiocoInformatica
{
    public class Videogioco
    {
        private List<Personaggio> _listaPersognaggi;
        private List<Arma> _listaArma;
        private Impostazioni _impostazioni;

        public Videogioco()
        {
            _listaPersognaggi = LeggiFileXmlPersonaggio();
            _listaArma = LeggiFileXmlArma();
            _impostazioni = LeggiFileXmlImpostazioni();
        }

        public List<Personaggio> ListaPersognaggi
        {
            get
            {
                return _listaPersognaggi;
            }
        }

        public List<Arma> ListaArma
        {
            get
            {
                return _listaArma;
            }
        }

        public Impostazioni Impostazioni
        {
            get
            {
                return _impostazioni;
            }
        }

        private List<Personaggio> LeggiFileXmlPersonaggio()
        {
            XmlSerializer deserializzatore = new XmlSerializer(typeof(List<Personaggio>));
            using (StreamReader sr = new StreamReader("personaggi.xml"))
            {
                if (sr.ReadLine() != null)
                    return deserializzatore.Deserialize(sr) as List<Personaggio>;
                else
                    throw new Exception("Non sono stati trovati personaggi");
            }
        }

        private List<Arma> LeggiFileXmlArma()
        {
            XmlSerializer deserializzatore = new XmlSerializer(typeof(List<Arma>));
            using (StreamReader sr = new StreamReader("armi.xml"))
            {
                if (sr.ReadLine() != null)
                    return deserializzatore.Deserialize(sr) as List<Arma>;
                else
                    throw new Exception("Non sono state trovate armi");
            }
        }

        private Impostazioni LeggiFileXmlImpostazioni()
        {
            XmlSerializer deserializzatore = new XmlSerializer(typeof(Impostazioni));
            using (StreamReader sr = new StreamReader("impostazioni.xml"))
            {
                if (sr.ReadLine() != null)
                    return deserializzatore.Deserialize(sr) as Impostazioni;
                else
                    throw new Exception("Errore");
            }
        }
    }
}