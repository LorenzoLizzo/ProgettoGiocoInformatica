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
            ListaPersonaggi = LeggiFileXmlPersonaggio();
            ListaArmi = LeggiFileXmlArma();
            Impostazioni = LeggiFileXmlImpostazioni();
        }

        public List<Personaggio> ListaPersonaggi
        {
            get
            {
                return _listaPersognaggi;
            }
            set
            {
                _listaPersognaggi = value;
            }
        }

        public List<Arma> ListaArmi
        {
            get
            {
                return _listaArma;
            }
            set
            {
                _listaArma = value;
            }
        }

        public Impostazioni Impostazioni
        {
            get
            {
                return _impostazioni;
            }
            set
            {
                _impostazioni = value;
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

        private void SerializzaImpostazioni()
        {
            XmlSerializer serializzazione = new XmlSerializer(typeof(Impostazioni));
            using (StreamWriter sw = new StreamWriter("impostazioni.xml"))
            {
                serializzazione.Serialize(sw, Impostazioni);
            }
        }

        public void SalvaImpostazioni()
        {
            SerializzaImpostazioni();
        }
    }
}