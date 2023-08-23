using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Flappybird
{
    [XmlType("Igralec")]
    public class Igralec : IComparable
    {
        [XmlElement("Ime")]
        public string Ime
        {
            get;
            set; 
        }

        [XmlElement("Točke")]
        public int Tocke
        {
            get;
            set;
        }
        public Igralec()
        {
        }
        public Igralec(string ime, int tocke)
        {
            this.Ime = ime;
            this.Tocke = tocke;
        }

        public int CompareTo(object objekt)
        {
            Igralec igralec = objekt as Igralec;
            return igralec.Tocke.CompareTo(this.Tocke);
        }

    }
}
