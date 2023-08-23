using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using System.Xml;
//using System.Xml.Schema;
using System.Xml.Serialization;
//using System.Xml;


namespace Flappybird
{
    public partial class Flappy : Form
    {
        int hitrost_ovir = 8;
        int gravitacija = 15;
        int sttocke = 0;
        int najboljsi = 0;
        Igralec uporabnik;
        Igralec pomoc;


        private List<Igralec> igralci = new List<Igralec> ();
        //private List<Igralec> igralci;

        bool konecIgre = false;
        bool zacetek = true;

        SeznamIgralcev uporabniki = new SeznamIgralcev();
        


        private string pot = @"rezultati1.json";
        private string xmlpot = @"xmlIgralcipoiskus.xml";
        //private string pot = @"C:\Users\Polona\Desktop\Prak_mat\Prog\Predstavitev\Flappybird\rezultati.json";
        public Flappy(string igralec, List<Igralec>seznam)
        {
            InitializeComponent();
            uporabniki.Ime = "Igralci";
            pomoc = new Igralec();
            pomoc.Ime = igralec;
            igralci = seznam;
            //igralci = XmlBranje(xmlpot);
            //RestartIgre();
        } 

        private void timer1_Tick(object sender, EventArgs e)
        {
            flappybird.Top += gravitacija;
            oviraSpodaj.Left -= hitrost_ovir;
            oviraZgoraj.Left -= hitrost_ovir;
            tockeL.Text = sttocke.ToString();

            // premik spodnje ovire ko pride na rob frame-a
            if (oviraSpodaj.Left <= -150)
            {
                oviraSpodaj.Left = 785;
                sttocke++;

            }
            // premik zgornje ovire ko pride na rob frama-a
            if (oviraZgoraj.Left < -180)
            {
                oviraZgoraj.Left = 950;
                sttocke++;
            }

            // povečamo hitrost
            if (sttocke > 5 && sttocke < 10)
            {
                hitrost_ovir += 1;
            }
            // njaboljši reultat se spremeni
            if (najboljsi < sttocke)
            {
                najboljsi = sttocke;
                najboljseTocke.Text = sttocke.ToString();
            }

            // robni pogoji (igra se zaklči)
            if (flappybird.Bounds.IntersectsWith(oviraSpodaj.Bounds) || 
                (flappybird.Bounds.IntersectsWith(oviraZgoraj.Bounds)) ||
                (flappybird.Bounds.IntersectsWith(tla.Bounds)))
            {
                KonecIgre();
            }

            if (flappybird.Top < -25)
            {
                KonecIgre();
            }
        }

        /// <summary>
        /// Flappi se bo spuščal ko tipaka space ne bo pritisnjena
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tipka_dol(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravitacija = -15;
            }
        }

        /// <summary>
        /// Flappi se bo vzdignil ko tipka space bo pritisnjena
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tipka_gor(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravitacija = 15;
            }
        }



        /// <summary>
        /// Klik na sličico restart omogoči ponovno igranje igre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            RestartIgre();
        }

        /// <summary>
        /// Kaj se zgodi ob koncu igre
        /// </summary>
        private void KonecIgre()
        {

            timer1.Stop();
            //tukaj preberemo json datoteko
            

            najboljseTocke.Text = najboljsi.ToString();

            label1.Text = "Konec Igre !!! " + label1.Text;

            konecIgre = true;


            uporabnik.Tocke = sttocke;

            igralci.Add(uporabnik);
            uporabniki.DodajIgralec(uporabnik);
            pictureBox1.Enabled = true;
            pictureBox1.Visible = true;
            // shranimo rezultate v json file 
            igralci.Sort();
            Shranimo();

            // shranimo se v xml
            XmlShranjevanje();
            // prikaz rezultatov
            Rezultati rezultati = new Rezultati(igralci);
            rezultati.Show();


        }


        private void Shranimo()
        {
            string json = JsonSerializer.Serialize(igralci);
            File.WriteAllText(pot, json);

        }

        /// <summary>
        /// Shranimo seznam objektov v xml datoteko
        /// </summary>
        private void XmlShranjevanje()
        {
            //TextWriter fs = new StreamWriter(@"xmlIgralci.xml");
            XmlSerializer xmlserializer = new XmlSerializer(typeof(Igralec));
            FileStream fs = new FileStream(xmlpot, FileMode.OpenOrCreate);

            //xmlserializer.Serialize(fs, uporabniki.Uporabniki);
            foreach (Igralec i in igralci)
            {
                xmlserializer.Serialize(fs, i);
            }
            fs.Close();
            //uporabniki = null;
        }


        /// <summary>
        /// Preberemo objekte igralec iz datoteke tipa xml in vrne vrnemo seznam igralcev
        /// </summary>
        /// <param name="niz"></param>
        /// <returns></returns>
        private List<Igralec> XmlBranje(string niz)
        {
            if (!File.Exists(xmlpot))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Igralec));

                FileStream fs = new FileStream(xmlpot, FileMode.Open);
                uporabniki = (SeznamIgralcev)xmlSerializer.Deserialize(fs);

                List<Igralec> seznam = new List<Igralec>();
                //using (StreamReader reader = new StreamReader(niz))
                //{
                //    Igralec igralec;
                //    igralec = (Igralec)xmlSerializer.Deserialize(reader);
                //    seznam.Add(igralec);
                //}
                seznam = uporabniki.Uporabniki;
                seznam.Sort();
                return seznam;
            }
            else
            {
                return new List<Igralec>() ;
            }


        }


        /// <summary>
        /// Restart igre
        /// </summary>
        private void RestartIgre()
        {
            uporabnik = new Igralec();
            uporabnik.Ime = pomoc.Ime;
            konecIgre = false;

            flappybird.Location = new Point(98, 252);

            oviraSpodaj.Left = 780;
            oviraZgoraj.Left = 850;

            sttocke = 0;
            hitrost_ovir = 8;
            label1.Text = "Točke: ";
            tockeL.Text = "0";
            pictureBox1.Enabled = false;
            pictureBox1.Visible = false;

            timer1.Start();

            // najboljši rezultat takoj ko zaženemo aplikacijo
            if (zacetek)
            {
                //List<Igralec> igr = LoadJson(pot);
                if (igralci.Count() > 0)
                {
                    najboljsi = igralci[0].Tocke;
                    najboljseTocke.Text = najboljsi.ToString();
                }
            }
            // branje xml datoteke
            //igralci = XmlBranje(xmlpot);

        }
    }

    /// <summary>
    /// //////
    /// </summary>
    [Serializable()]
    [XmlRoot("Igralci")]
    public class SeznamIgralcev
    {
        [XmlArray("Igralci")]
        [XmlArrayItem("Igralec", typeof(Igralec))]
        public List<Igralec> uporabniki = new List<Igralec>();

        public SeznamIgralcev()
        {

        }

        [XmlElement("Ime seznama")]
        public string Ime
        {
            get;
            set;
        }
        public SeznamIgralcev(string ime)
        {
            this.Ime = ime;
        }
        public List<Igralec> Uporabniki
        {
            get 
            {
                return uporabniki;
            }
        }
        public void DodajIgralec(Igralec igralec)
        {
            uporabniki.Add(igralec);
        }
    }
}
