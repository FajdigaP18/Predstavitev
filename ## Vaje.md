## Vaje

1. Naloga:
    Nadgrdite projekt T-Rex tako, da bo na grafičnem vmesniku ves čas viden najboljši rezultat. Najboljši rezultat naj se ohrani tudi ob ponovnem odprtju zagonu aplikacije.


2. Projekt T-Rex dopolnite šte tako, da se bo na koncu izpisalo 10 najbolkših rezultatov. Pri tem naj se ob ponovnem zaginu aplikacije ti rezultati ohranijo.
V pomoč vam je podan razred : 
```csharp
    public class Igralec : IComparable
    {
        public string Ime
        {
            get;
            set; 
        }

        public int Tocke
        {
            get;
            set;
        }
        public int CompareTo(object objekt)
        {
            Igralec igralec = objekt as Igralec;
            return this.Tocke.CompareTo(igralec.Tocke);
        }

    }
```